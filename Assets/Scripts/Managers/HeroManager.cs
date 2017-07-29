using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroManager : RegisterList<HeroController>
{
    public HeroController Hero { get { if (list.Count > 0) return list[0]; else return null; } }
    public int experience = 0;
    public int level = 1;

    public HeroManager() : base() { }

    public void Save(ref SaveGame save)
    {
        save.experience = experience;
        save.level = level;
    }

    public static HeroManager Load(SaveGame save = null)
    {
        var heroManager = new HeroManager();

        if (save != null)
        {
            heroManager.experience = save.experience;
            heroManager.level = save.level;
        }

        return heroManager;
    }

    public void AddHeroToList(ref List<GameCharacterController> addToList)
    {
        if (list.Count > 0) addToList.Add(list[0]);
    }
}
