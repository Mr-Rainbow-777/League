using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///transform 类的功能
/// </summary>
public class transform : MonoBehaviour
{

    public Transform TF;
    private void OnGUI()
    {
        if (GUILayout.Button("child"))
        {
            foreach (Transform child in this.transform)
            {
                print(child.name);
            }
        }

        {
            //this.transform.position  --> 物体相对于世界坐标原点的位置
            //this.transform.localposition -->物体相对于父物体的相对位置

        }
        if (GUILayout.Button("translate"))
        {
            this.transform.Translate(0, 0, 1);

        }
        if(GUILayout.RepeatButton("RotateAround"))
        {
            this.transform.RotateAround(Vector3.zero, Vector3.up, 1);
        }
        //获得组件的child组件
        if (GUILayout.Button("Getchild1"))
        {
            Transform TF = this.transform.Find("子物体名称");  //根据姓名查找
        }
        if (GUILayout.Button("Getchild2"))
        {
            int count = this.transform.childCount;
            for (int i = 0; i < count; i++)
            {
                Transform CHILD=this.transform.GetChild(i);  //根据索引求子物体
            }
        }        
    }


    
}
