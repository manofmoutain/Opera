using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "寶石" , menuName = "資料庫/寶石資料庫" , order = 0)]
public class GemDatabase : ScriptableObject
{
    public GemType gemType;
    public List<GameObject> gemModel;
}



public enum GemType
{
    紅寶石,
    藍寶石,
    黃寶石,
    綠寶石,
    紫寶石,
    青玉石
}
