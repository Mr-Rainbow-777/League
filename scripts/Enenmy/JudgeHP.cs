using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///找到血量最低的敌人
/// </summary>
public class JudgeHP : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("find"))
        {
            GameobjHP[] Enemy = Object.FindObjectsOfType<GameobjHP>();
            GameobjHP Min = JudgeMinbyHP(Enemy);
            Min.GetComponent<MeshRenderer>().material.color = Color.red;
            print(Min.name);
        }
        if (GUILayout.Button("findchild"))
        {
            var child=findchild.Findchild(this.transform, "Cylinder");
            child.transform.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }

    private GameobjHP JudgeMinbyHP(GameobjHP[] AllEnemy)
    {
        GameobjHP min =AllEnemy[0];
        for (int i = 1; i < AllEnemy.Length; i++)
        {
            if (min.HP > AllEnemy[i].HP)
            {
                min = AllEnemy[i];
            }
        }
        return min;
    }
}
