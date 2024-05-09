using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPool : MonoBehaviour
{
    [SerializeField] private List<GameObject> gemPools;



    public void AddToGemPools(GameObject gem)
    {
        gemPools.Add(gem);
    }

    public void RemoveGem(GameObject gem)
    {
        gemPools.Remove(gem);
    }
}
