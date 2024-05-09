using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class GemManager
{
    [SerializeField] GemDatabase gemData;

    [SerializeField] GemPool gemPool;

    [SerializeField]private GameObject spawnedGem;
    // public List<GemControl> gemControls;
    // [SerializeField] private List<Transform> spawnedSlot;
    // [SerializeField] private List<GameObject> spawnedGems;

    // private void Start()
    // {
    //     Init();
    // }
    //
    // private void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.C))
    //     {
    //         Reset();
    //     }
    // }

    public void Init()
    {
        // for (int i = 0; i < spawnedSlot.Count; i++)
        // {
        //     GameObject go = GameObject.Instantiate(gemData.gemModel[gemControls[i].gemIndex], spawnedSlot[i]);
        //     spawnedGems.Add(go);
        //
        // }
    }

    public void Init(int index , Transform trans)
    {
        spawnedGem = GameObject.Instantiate(gemData.gemModel[index], trans);
        gemPool.AddToGemPools(spawnedGem);
    }


    public void Reset()
    {
        // for (int i = 0; i < spawnedGems.Count; i++)
        // {
        //     GameObject.Destroy(spawnedGems[i]);
        // }
        // spawnedGems.Clear();
    }
    
    

    public void RemoveGem(int index)
    {
        // // int listIndex = spawnedGems.IndexOf(spawnedGems[index]);
        // GameObject.Destroy(spawnedGems[index]);
        // spawnedGems.RemoveAt(index);
    }

    public void RemoveFromGemPool()
    {
        gemPool.RemoveGem(spawnedGem);
        GameObject.Destroy(spawnedGem);
        spawnedGem = null;
    }
}
