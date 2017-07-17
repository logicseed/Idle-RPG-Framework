using UnityEngine;
using System.Collections.Generic;
using System;

public class RegisterList<T> where T : MonoBehaviour
{
    [SerializeField]
    protected List<T> list;

    public RegisterList()
    {
        RemoveAll();
    }

    public virtual List<T> GetAll()
    {
        return list;
    }

    public virtual void RemoveAll(bool destroy = false)
    {
        if (destroy)
        {
            foreach (var item in list)
            {
                GameObject.Destroy(item.gameObject);
            }
        }

        list = new List<T>();
    }

    public virtual void Register(T item)
    {
        if (!list.Contains(item)) list.Add(item);
    }

    public virtual void Unregister(T item)
    {
        if (list.Contains(item)) list.Remove(item);
    }

    public virtual void AddAllToList(ref List<T> addToList)
    {
        if (list.Count > 0) addToList.AddRange(list);
    }
}
