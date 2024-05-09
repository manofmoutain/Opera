using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class SealManager
{
    [SerializeField] private SealDatabase data;

    // [SerializeField] private List<GemDatabase> gems;
    [SerializeField] private GemDatabase gem;

    [SerializeField] private List<GameObject> slots;

    public int showSlotIndex;

    public int CorrectIndex(int index) => data.correctIndex[index];

    [SerializeField] private List<GameObject> spawnedGems;


    public void Init()
    {
        // for (int i = 0; i < sealedGemStone.Count; i++)
        // {
        //     switch (data.seal[i])
        //     {
        //         case GemType.紅寶石:
        //             sealedGemStone[i] = gems[0].gemModel[data.correctIndex[i]];
        //             break;
        //         case GemType.藍寶石:
        //             sealedGemStone[i] = gems[1].gemModel[data.correctIndex[i] - 6];
        //             break;
        //         case GemType.黃寶石:
        //             sealedGemStone[i] = gems[2].gemModel[data.correctIndex[i] - 12];
        //             break;
        //         case GemType.綠寶石:
        //             sealedGemStone[i] = gems[3].gemModel[data.correctIndex[i] - 18];
        //             break;
        //         case GemType.紫寶石:
        //             sealedGemStone[i] = gems[4].gemModel[data.correctIndex[i] - 24];
        //             break;
        //         case GemType.青玉石:
        //             sealedGemStone[i] = gems[5].gemModel[data.correctIndex[i] - 30];
        //             break;
        //         default:
        //             throw new ArgumentOutOfRangeException();
        //     }
        // }
        for (int i = 0; i < slots.Count; i++)
        {
            GameObject newGem = GameObject.Instantiate(gem.gemModel[data.correctIndex[i]], slots[i].transform);

            spawnedGems.Add(newGem);
            slots[i].SetActive(false);
        }
    }


    public void Reset()
    {
        for (int i = 0; i < spawnedGems.Count; i++)
        {
            GameObject.Destroy(spawnedGems[i]);
        }

        spawnedGems.Clear();
    }

    public bool IsThisGemCorrect(int insertGemIndex)
    {
        for (int i = 0; i < data.correctIndex.Count; i++)
        {
            if (insertGemIndex == data.correctIndex[i])
            {
                // slots[i].SetActive(true);
                showSlotIndex = i;
                return true;
            }
        }

        return false;
    }

    public void ShowGem()
    {
        slots[showSlotIndex].SetActive(true);
    }
}