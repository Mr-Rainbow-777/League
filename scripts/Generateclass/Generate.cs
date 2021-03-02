using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  生成器
/// </summary>
public class Generate : MonoBehaviour
{
    public int randindex;
    public Wayline[] ChoiceLine { set; get; }
    public Wayline CurrentLine { set; get; }

    private void Awake()
    {
        ChoiceLine = Object.FindObjectsOfType<Wayline>();
        randindex = Random.Range(0, 3);
        CurrentLine = ChoiceLine[randindex];
    }

    


}
