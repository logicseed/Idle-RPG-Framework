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

    protected bool hasSpawnedBoss = false;

    /// <summary>
    /// Constructs the stage manager.
    /// </summary>
    protected void Start()
    {
        GameManager.StageManager = this;
    }

    /// <summary>
    /// Ends the stage.
    /// </summary>
    public void EndStage()
    {
        foreach (var stage in stagesToUnlock) GameManager.WorldManager.UnlockStage(stage);

        foreach (var zone in zonesToUnlock) GameManager.WorldManager.UnlockZone(zone);

        if (allyReward != null) GameManager.RosterManager.AddUnlocked(allyReward.name);

        GameManager.WorldManager.SetLastStage("Scenes/Stages/" + SceneManager.GetActiveScene().name);
        GameManager.WorldManager.SetIdleFactor(idleRewardsFactor);

        GameManager.LoadWorld();
    }

    /// <summary>
    /// Tries to get the next reward from the stage's loot collection.
    /// </summary>
    /// <returns>A piece of equipment if one dropped; null otherwise.</returns>
    public void GetReward()
    {
        if (lootCollection.DropEquipment)
        {
            GameManager.InventoryManager.AddUnlocked(lootCollection.GetNextEquipment().name, false);
        }
    }

    /// <summary>
    /// Spawns the boss for the stage.
    /// </summary>
    /// <returns>The controller for the boss.</returns>
    public BossController SpawnBoss()
    {
        if (boss != null)
        {
            var position = bossSpawnLocation.position;
            var rotation = Quaternion.identity; // No rotation
            var boss = Instantiate(GameManager.GameSettings.Prefab.Enemy, position, rotation) as GameObject;
            boss.name = "Boss";
            var bossController = boss.GetComponent<BossController>();
            bossController.EnemyObject = this.boss;
            return bossController;
        }
        else return null;
    }
}