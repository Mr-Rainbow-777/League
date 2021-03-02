using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 找到距离主人公最近的物体
/// </summary>
public class Findnearestenemy : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("find nearest enemy"))
        {
            distance Min = Judgeneardis();
            Min.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    private distance Judgeneardis()
    {
        distance[] Dis = Object.FindObjectsOfType<distance>();
        distance NearDis = Dis[0];
        for (int i = 1; i < Dis.Length; i++)
        {
            if (NearDis.Distance > Dis[i].Distance)
            {
                NearDis = Dis[i];
            }
        }
        return NearDis;
    }
}
