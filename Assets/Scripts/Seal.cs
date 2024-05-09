using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seal : MonoBehaviour
{
    [SerializeField] private SealManager manager;
    [SerializeField] private GemControl insertGem;


    private void Start()
    {
       manager.Init();
    }

    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     manager.Reset();
        // }
    }

    public void InsertGem(int insertGemIndex , GemControl newGem)
    {
        insertGem = newGem;
        if (manager.IsThisGemCorrect(insertGemIndex))
        {
            StartCoroutine(nameof(Co_CorrectAndShowGem));
        }
        else
        {
            StartCoroutine(nameof(Co_WrongAndRemoveGem));
        }
        
    }

    IEnumerator Co_CorrectAndShowGem()
    {
        yield return new WaitForSeconds(1.0f);
        manager.ShowGem();
        insertGem.RemoveFromPool();
    }

    IEnumerator Co_WrongAndRemoveGem()
    {
        yield return new WaitForSeconds(1.0f);
        insertGem.RemoveFromPool();
    }
}
