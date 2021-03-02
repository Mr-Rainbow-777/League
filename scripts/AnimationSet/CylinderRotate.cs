using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///   设置圆柱体的旋转动画
/// </summary>
public class CylinderRotate : MonoBehaviour
{
    public bool State;
    private Animation Anim;
    private string Name;
    private void Start()
    {
        Anim = GetComponent<Animation>();
        Name = "Cylinder";
        State = false;
    }
    private void OnMouseDown()
    {
        if (State)
        {
            if (Anim.isPlaying == false)
            {
                Anim[Name].time = Anim[Name].length;
                Anim[Name].speed = -1;
            }
        }
        else
        {
            Anim[Name].speed = 1;
        }
        Anim.Play(Name);
        State = !State;

    }
}
