using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 主人公的属性
/// </summary>
public class Chararcter : MonoBehaviour
{
    public  Vector3 position;

    public  void Awake()
    {
        position=this.transform.position;
    }
}
