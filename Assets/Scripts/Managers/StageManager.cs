using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the functionality of a stage.
/// </summary>
public class StageManager : MonoBehaviour
{
    [SerializeField]
    protected List<string> stagesToUnlock;

    [SerializeField]
    protected List<string> zonesToUnlock;

    [SerializeField]
    protected LootCollection lootCollection;

    [SerializeField]
    protected Ally allyReward;

    [SerializeField]
    protected float idleRewardsFactor = 1.0f;

    [SerializeField]
    protected Enemy boss;

    [SerializeField]
    protected Transform bossSpawnLocation;

    [SerializeField]
    protected float bossSpawnDelay = 3.0f;

    protected bool hasSpawnedBoss = false;

    protected bool hasInvokedSpawnBoss = false;

    public bool HasSpawnedBoss { get { return hasSpawnedBoss; } }

    /// <summary>
    /// Constructs the stage manager.
    /// </summary>
    protected void Start()
    {
        GameManager.StageManager = this;
        if (boss == null) hasSpawnedBoss = true;
    }

    /// <summary>
    /// Ends the stage.
    /// </summary>
    public void EndStage(bool stageLost = false)
    {
        GameManager.OnStage = false;
        if (stageLost)
        {
            var canvas = GameObject.Find("UiCanvas");
            Instantiate(GameManager.GameSettings.Prefab.UI.StageLostPopup, canvas.transform, false);
            foreach (var ally in GameManager.AllFriendlies)
            {
                Destroy(ally.gameObject);
            }
        }
        else
        {
            foreach (var stage in stagesToUnlock) GameManager.WorldManager.UnlockStage(stage);

            foreach (var zone in zonesToUnlock) GameManager.WorldManager.UnlockZone(zone);

            if (allyReward != null)
            {
                GameManager.RosterManager.AddUnlocked(allyReward.name, allyReward.Level);
                GameManager.AbilityManager.AddUnlocked(allyReward.Lesson.name, false);
            }


            GameManager.WorldManager.SetIdleFactor(idleRewardsFactor);

            GameManager.Hero.HeroMovementController.Location = new Vector2(100, 0);
            GameManager.Hero.CombatController.TargetController = null;

            var canvas = GameObject.Find("UiCanvas");
            Instantiate(GameManager.GameSettings.Prefab.UI.StageCompletePopup, canvas.transform, false);
        }
        GameManager.Instance.SaveGame();
    }

    /// <summary>
    /// Tries to get the next reward from the stage's loot collection.
    /// </summary>
    public void GetReward(Vector2 location)
    {
        if (lootCollection != null && lootCollection.DropEquipment)
        {
            var nextEquipment = lootCollection.GetNextEquipment();
            GameManager.InventoryManager.AddUnlocked(nextEquipment.name, false);

            var droppedEquipmentObject = Instantiate(GameManager.GameSettings.Prefab.UI.DroppedEquipment, location, Quaternion.identity);
            var droppedEquipmentController = droppedEquipmentObject.GetComponent<DroppedEquipmentController>();
            droppedEquipmentController.Image.sprite = nextEquipment.icon;
        }
    }

    /// <summary>
    /// Spawns the boss for the stage immediately.
    /// </summary>
    public void SpawnBoss()
    {
        hasSpawnedBoss = true;
        if (boss != null)
        {
            var position = bossSpawnLocation.position;
            var rotation = Quaternion.identity; // No rotation
            var boss = Instantiate(GameManager.GameSettings.Prefab.Boss, position, rotation) as GameObject;
            boss.name = "Boss";
            var bossController = boss.GetComponent<BossController>();
            bossController.EnemyObject = this.boss;
        }
    }

    /// <summary>
    /// Spawns the boss for the stage after the delay specified on the stage manager.
    /// </summary>
    public void SpawnBossAfterDelay()
    {
        if (!hasInvokedSpawnBoss)
        {
            hasInvokedSpawnBoss = true;
            Invoke("SpawnBoss", bossSpawnDelay);
        }
    }
}