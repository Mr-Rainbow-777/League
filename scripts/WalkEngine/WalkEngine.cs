using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///   敌人循迹系统
/// </summary>
public class WalkEngine : MonoBehaviour
{
    public float rotationSpeed;
    public float MoveSpeed=0.5f;
    public Transform[]  Points;    //路点
    private int currentindex;

    private void Start()
    {
        currentindex = 0;
        Points=this.GetComponent<Generate>().CurrentLine.WayPoint;
    }
    private void Update()
    {
        if (Points!=null && currentindex < Points.Length)
        {
            if (JudgeGet() != true)
            {
                Lookrotate(Points[currentindex].position);
                Walkforward();
            }
            else
            {
                currentindex++;
            }
        }
    }
    private void Lookrotate(Vector3 Rotation)
    {
        this.transform.LookAt(Rotation);
    }


    private void Walkforward()
    {
        this.transform.Translate(0,0,MoveSpeed*Time.deltaTime);

    }

    private bool JudgeGet()
    {
        if (Vector3.Distance(this.transform.position , Points[currentindex].position)<=0.1f)
        {
            return true;
        }
        else
            return false;
    }


}
