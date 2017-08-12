using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable]
public class CumulativeDistribution<T> 
{
    public List<Probability<T>> items;
    private List<Probability<T>> cumulativeItems;
    private bool hasCalculatedCumulative = false;

    public T GetItem(float value)
    {
        if (!hasCalculatedCumulative) CalculateCumulative();

        for (int i = 0; i < cumulativeItems.Count; i++)
        {
            if (value < cumulativeItems[i].probability) return cumulativeItems[i].item;
        }

        return items[0].item;
    }

    private void CalculateCumulative()
    {
        float totalProbability = 0.0f;
        foreach (var item in items) totalProbability += item.probability;

        cumulativeItems = new List<Probability<T>>();
        cumulativeItems.Add(new Probability<T>(items[0].item, items[0].probability / totalProbability));
        for (int i = 1; i < items.Count; i++)
        {
            cumulativeItems.Add(new Probability<T>(items[i].item, (items[i].probability / totalProbability) + cumulativeItems[i - 1].probability));
        }
    }


}

[Serializable]
public class Probability<U>
{
    public U item;
    public float probability;

    public Probability(U item, float probability)
    {
        this.item = item;
        this.probability = probability;
    }
}
