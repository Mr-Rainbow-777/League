using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 查找子物体（只需知道物体名称）
/// </summary>
public class findchild : MonoBehaviour
{
    public static Transform Findchild(Transform partrsform, string name)
    {
        Transform Child = partrsform.Find(name);
        if (Child != null) { return Child; }

        int count = partrsform.childCount;

        for (int i = 0; i < count; i++)
        {
            Child=Findchild(partrsform.GetChild(i),name);
            if (Child != null) { return Child; }
        }
        return null;
    }
}
