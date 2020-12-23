using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Threading;
using System;


public class p1 : MonoBehaviour
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
        if(Global.typeNum==0)
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
        // robot 0
        else
        {
            if (location != Global.robot[0].location)
            {
                float[] result = Global.move(Global.robot[0].location);
                float newX = result[0];
                float newZ = result[1];
                float turnY = result[2];
                this.gameObject.transform.position = new Vector3(newX, gameObject.transform.localPosition.y, newZ);
                this.gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.eulerAngles.x, turnY, gameObject.transform.eulerAngles.z);

                location = Global.robot[0].location;
                // ms
                int pauseTime = 2000;
                // pause for some time
                System.Threading.Thread.Sleep(pauseTime);
            }
        }
    }
}


