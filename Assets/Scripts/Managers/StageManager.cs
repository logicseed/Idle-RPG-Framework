using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public List<string> stagesToUnlock;
    public List<string> zonesToUnlock;
    public Enemy boss;
    public Transform bossSpawnLocation;
    public LootCollection lootCollection;
    [HideInInspector] public bool hasSpawnedBoss = false;
    public Ally allyReward;

    private void Start()
    {
        GameManager.Instance.stageManager = this;
    }

    public Equipment GetReward()
    {
        // set currency reward with lootCollections.GetCurrency();
        var equipment = lootCollection.GetEquipment();
        if (equipment != null) GameManager.InventoryManager.AddUnlocked(equipment.name, false);
        return equipment;
    }

    public BossController SpawnBoss()
    {
        if (boss != null)
        {
            var position = bossSpawnLocation.position;
            var rotation = Quaternion.identity; // No rotation
            var boss = Instantiate(GameManager.GameSettings.Prefab.Enemy, position, rotation) as GameObject;
            boss.name = "Boss";
            var bossController = boss.GetComponent<BossController>();
            bossController.enemy = this.boss;
            return bossController;
        }
        else return null;
    }

    public void EndStage()
    {
        foreach (var stage in stagesToUnlock) GameManager.WorldManager.UnlockStage(stage);

        foreach (var zone in zonesToUnlock) GameManager.WorldManager.UnlockZone(zone);

        if (allyReward != null) GameManager.RosterManager.AddUnlocked(allyReward.name);

        GameManager.WorldManager.SetLastStage("Scenes/Stages/" + SceneManager.GetActiveScene().name);

        GameManager.LoadWorld();
    }
}
