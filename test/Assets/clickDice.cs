using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class clickDice : MonoBehaviour
{
    // send the length it should move
    public void Click()
    {
        int stall = 1;
        if (Global.step == 0 && Global.p.state == 1 && stall == 1)
        {
            System.Random r1 = new System.Random();
            Global.step = r1.Next(100) % 6 + 1;
            stall = 0;                                      //roll for once
        }
        else if (Global.step == -1 && Global.p.state == 1)
        {
            EditorUtility.DisplayDialog("点错啦！",
                         "亲爱滴 " + Global.p.name + " 同志，您本回合移动过了", "了解了");
        }
        else if (Global.p.state == 0)
        {
            EditorUtility.DisplayDialog("点错啦！",
                        "未到您的回合，请稍后再试", "了解了");
        }
        if (Global.p.state == 0)
            stall = 1;                                      //restore dice
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

