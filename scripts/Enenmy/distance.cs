using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  计算敌人与角色的距离
/// </summary>
public class distance : MonoBehaviour
{
    public float Distance;
    Chararcter mainposition = new Chararcter();
    public void Awake()
    {
        Distance=Vector3.Distance(this.transform.position, mainposition.position);
    }
}
