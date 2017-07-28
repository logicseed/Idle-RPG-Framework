using System;
using UnityEngine;

[Serializable]
public class GameSettings
{
    public MaximumContainer Max;
    [Serializable] public class MaximumContainer
    {
        public EntityContainer Abilities = new EntityContainer(9999, 3);
        public EntityContainer Equipment = new EntityContainer(9999, 9999);
        public EntityContainer Allies = new EntityContainer(9999, 3);
        [Serializable] public class EntityContainer
        {
            public int Unlocked;
            public int Assigned;
            public EntityContainer(int unlocked, int assigned) { Unlocked = unlocked; Assigned = assigned; }
        }
    }

    public PathContainer Path;
    [Serializable] public class PathContainer
    {
        public string Abilities = "Abilities/";
        public string Equipment = "Equipment/";
        public string Allies = "Allies/";
    }

    public PrefabContainer Prefab;
    [Serializable] public class PrefabContainer
    {
        public GameObject Hero;
        public GameObject Ally;
        public GameObject Enemy;
    }
}
