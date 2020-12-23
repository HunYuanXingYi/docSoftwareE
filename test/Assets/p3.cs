using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Threading;
using System;

public class p3 : MonoBehaviour
{
    int location = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // player
        if (Global.typeNum == 2)
        {
            if (location != Global.p.location)
            {
                float[] result = Global.move(Global.p.location);
                float newX = result[0];
                float newZ = result[1];
                float turnY = result[2];
                this.gameObject.transform.position = new Vector3(newX, gameObject.transform.localPosition.y, newZ);
                this.gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.eulerAngles.x, turnY, gameObject.transform.eulerAngles.z);

                location = Global.p.location;
                // ms
                int pauseTime = 2000;
                // pause for some time
                System.Threading.Thread.Sleep(pauseTime);
            }
        }
        // robot 2
        else if (Global.typeNum == 3)
        {
            if (location != Global.robot[2].location)
            {
                EditorUtility.DisplayDialog("第 " + Global.roundNum + " 回合",
                    "亲爱的 " + Global.robot[1].name
                    + "同学 完成了自己的回合！", "了解了");
                float[] result = Global.move(Global.robot[2].location);
                float newX = result[0];
                float newZ = result[1];
                float turnY = result[2];
                this.gameObject.transform.position = new Vector3(newX, gameObject.transform.localPosition.y, newZ);
                this.gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.eulerAngles.x, turnY, gameObject.transform.eulerAngles.z);

                location = Global.robot[2].location;
                // ms
                int pauseTime = 2000;
                // pause for some time
                System.Threading.Thread.Sleep(pauseTime);

            }
        }
        // robot 1
        else
        {
            if (location != Global.robot[1].location)
            {
                EditorUtility.DisplayDialog("第 " + Global.roundNum + " 回合",
                    "亲爱的 " + Global.robot[0].name
                    + "同学 完成了自己的回合！", "了解了");
                float[] result = Global.move(Global.robot[1].location);
                float newX = result[0];
                float newZ = result[1];
                float turnY = result[2];
                this.gameObject.transform.position = new Vector3(newX, gameObject.transform.localPosition.y, newZ);
                this.gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.eulerAngles.x, turnY, gameObject.transform.eulerAngles.z);

                location = Global.robot[1].location;
                // ms
                int pauseTime = 2000;
                // pause for some time
                System.Threading.Thread.Sleep(pauseTime);

            }
        }
    }

}
