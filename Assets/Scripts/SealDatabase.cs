using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "封印資料庫", menuName = "資料庫/封印" , order = 1)]
public class SealDatabase : ScriptableObject
{
    public List<GemType> seal;

    public List<int> correctIndex;

}
