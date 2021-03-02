using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// gameobject 类提供    功能
/// </summary>
public class gameobjectdemo : MonoBehaviour
{
    public bool Object1;
    public bool Object2;
    private void Awake()
    {
        Object1 = this.gameObject.activeInHierarchy; //物体在界面上的激活状态
        Object2 = this.gameObject.activeSelf; //物体自身的激活状态

        {
            //this.gameObject.SetActive(true); 设置物体禁用/启用
        }
    }
    private void OnGUI()
    {
        if (GUILayout.Button("light"))
        {
            GameObject gameobj = new GameObject(); 
            Light light = gameobj.gameObject.AddComponent<Light>();
            light.type = LightType.Point;
            light.color = Color.blue;
        }
        {
            // GameObject[] ALLEnemy=GameObject.FindGameObjectsWithTag("enemy");//根据标签查找物体
            //Object.FindObjectsOfType<MeshRenderer>();   查找一个类型的对象
            //Object.Destroy();       销毁对象
        }
    }
    



}
