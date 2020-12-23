using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Threading;
using System;

public class main : MonoBehaviour
{
    float newX, newZ;
    float turnOrNot;
    float[] result = new float[3];
    // to check if I have operated
    int ope = 1;
    // remind of the ending of last player ( robot 3 )
    int remind = 0;




    // Start is called before the first frame update
    void Start()
    {
        Global.map[0] = new Global.activity();
        Global.map[1] = new Global.activity();
        Global.map[2] = new Global.activity();
        Global.map[3] = new Global.activity();
        Global.map[4] = new Global.activity();
        Global.map[5] = new Global.activity();
        Global.map[6] = new Global.activity();
        Global.map[7] = new Global.activity();
        Global.map[8] = new Global.activity();
        Global.map[9] = new Global.activity();
        Global.map[10] = new Global.activity();
        Global.map[11] = new Global.activity();
        Global.map[12] = new Global.activity();
        Global.map[13] = new Global.activity();
        Global.map[14] = new Global.activity();
        Global.map[15] = new Global.activity();
        Global.map[16] = new Global.activity();
        Global.map[17] = new Global.activity();
        Global.map[18] = new Global.activity();
        Global.map[19] = new Global.activity();
        Global.map[20] = new Global.activity();
        Global.map[21] = new Global.activity();
        Global.map[22] = new Global.activity();
        Global.map[23] = new Global.activity();
        Global.map[24] = new Global.activity();
        Global.map[25] = new Global.activity();
        Global.map[26] = new Global.activity();
        Global.map[27] = new Global.activity();
        Global.map[28] = new Global.activity();
        Global.map[29] = new Global.activity();
        Global.map[30] = new Global.activity();
        Global.map[31] = new Global.activity();
        Global.map[32] = new Global.activity();
        Global.map[33] = new Global.activity();
        Global.map[34] = new Global.activity();
        Global.map[35] = new Global.activity();
        Global.map[36] = new Global.activity();
        Global.map[37] = new Global.activity();
        Global.map[38] = new Global.activity();
        Global.map[39] = new Global.activity();

        Global.map[0].setInfo(0, 1, 0, 1, 0);
        Global.map[1].setInfo(1, 1, 0, 1, 1);
        Global.map[2].setInfo(1, 1, 0, 1, 2);
        Global.map[3].setInfo(1, 1, 0, 1, 3);
        Global.map[4].setInfo(2, 1, 0, 1, 4);
        Global.map[5].setInfo(9, 1, 0, 1, 5);
        Global.map[6].setInfo(5, 1, 0, 1, 6);
        Global.map[7].setInfo(1, 1, 0, 1, 7);
        Global.map[8].setInfo(1, 1, 0, 1, 8);
        Global.map[9].setInfo(1, 1, 0, 1, 9);
        Global.map[10].setInfo(6, 1, 0, 1, 10);
        Global.map[11].setInfo(1, 1, 0, 1, 11);
        Global.map[12].setInfo(1, 1, 0, 1, 12);
        Global.map[13].setInfo(1, 1, 0, 1, 13);
        Global.map[14].setInfo(3, 1, 0, 1, 14);
        Global.map[15].setInfo(10, 1, 0, 1, 15);
        Global.map[16].setInfo(4, 1, 0, 1, 16);
        Global.map[17].setInfo(1, 1, 0, 1, 17);
        Global.map[18].setInfo(1, 1, 0, 1, 18);
        Global.map[19].setInfo(1, 1, 0, 1, 19);
        Global.map[20].setInfo(7, 1, 0, 1, 20);
        Global.map[21].setInfo(1, 1, 0, 1, 21);
        Global.map[22].setInfo(1, 1, 0, 1, 22);
        Global.map[23].setInfo(1, 1, 0, 1, 23);
        Global.map[24].setInfo(2, 1, 0, 1, 24);
        Global.map[25].setInfo(9, 1, 0, 1, 25);
        Global.map[26].setInfo(5, 1, 0, 1, 26);
        Global.map[27].setInfo(1, 1, 0, 1, 27);
        Global.map[28].setInfo(1, 1, 0, 1, 28);
        Global.map[29].setInfo(1, 1, 0, 1, 29);
        Global.map[30].setInfo(8, 1, 0, 1, 30);
        Global.map[31].setInfo(1, 1, 0, 1, 31);
        Global.map[32].setInfo(1, 1, 0, 1, 32);
        Global.map[33].setInfo(1, 1, 0, 1, 33);
        Global.map[34].setInfo(3, 1, 0, 1, 34);
        Global.map[35].setInfo(10, 1, 0, 1, 35);
        Global.map[36].setInfo(4, 1, 0, 1, 36);
        Global.map[37].setInfo(1, 1, 0, 1, 37);
        Global.map[38].setInfo(1, 1, 0, 1, 38);
        Global.map[39].setInfo(1, 1, 0, 1, 39);

        Global.robot[0] = new Global.player();
        Global.robot[1] = new Global.player();
        Global.robot[2] = new Global.player();

        // this should be chosen during enter menu !!!!!!!!!!!!!!!!!!!!!!

        Global.typeNum = 0;
        Global.p.setInfo("Anthony", 1, 1, 0);

        /////////////////////////////////////////////////////////////////
        /// Default
        //Global.robot[0].setInfo("Kevin", 1, 0, 0);
        //Global.robot[1].setInfo("Grace", 2, 1, 1);
        //Global.robot[2].setInfo("Jessica", 2, 2, 2);
        //Global.robot[3].setInfo("William", 1, 3, 3);
        ///
        /////////////////////////////////////////////////////////////////
        if (Global.typeNum == 0)
        {
            Global.robot[0].setInfo("Grace", 2, 1, 1);
            Global.robot[1].setInfo("Jessica", 2, 2, 2);
            Global.robot[2].setInfo("William", 1, 3, 3);
        }
        else if (Global.typeNum == 1)
        {
            Global.robot[0].setInfo("Kevin", 1, 0, 0);
            Global.robot[1].setInfo("Jessica", 2, 2, 2);
            Global.robot[2].setInfo("William", 1, 3, 3);
        }
        else if (Global.typeNum == 2)
        {
            Global.robot[0].setInfo("Kevin", 1, 0, 0);
            Global.robot[1].setInfo("Grace", 2, 1, 1);
            Global.robot[2].setInfo("William", 1, 3, 3);
        }
        else if (Global.typeNum == 3)
        {
            Global.robot[0].setInfo("Kevin", 1, 0, 0);
            Global.robot[1].setInfo("Grace", 2, 1, 1);
            Global.robot[2].setInfo("Jessica", 2, 2, 2);
        }


        Global.step = 0;                    //ready to move

        Global.p.state = 1;               //game starts

        Global.roundNum = 1;

    }

    // Update is called once per frame
    void Update()
    {
        // enter my own turn
        // player move
        if (Global.step > 0 && Global.p.state == 1)
        {
            //////////PLAYER//////////
            // start moving
            result = Global.move(Global.p.location, Global.step);
            newX = result[0];
            newZ = result[1];
            turnOrNot = result[2];
            this.gameObject.transform.position = new Vector3(newX, gameObject.transform.localPosition.y, newZ);

            if (turnOrNot == 1)
            {
                this.gameObject.transform.localEulerAngles =
                    new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 90, gameObject.transform.eulerAngles.z);
            }

            Global.p.location = (Global.p.location + Global.step) % 40;     //update location
            // end moving
            Global.step = -1;
            remind = 0;

            // start operate
            ope = 1;
            //////////PLAYER//////////
        }
        // player operate
        else if (Global.p.state == 1 && ope == 1)
        {
            // start operating
            // eliminate forbidden locations
            if (Global.p.location != 0 && Global.p.location != 10 && Global.p.location != 20 && Global.p.location != 30
                && Global.p.location != 5 && Global.p.location != 15 && Global.p.location != 25 && Global.p.location != 35)
            {
                // current position
                Global.activity curLocation = Global.map[Global.p.location];
                // if not occupied
                if (curLocation.level == 0)
                {
                    if (EditorUtility.DisplayDialog("该行动啦！",
                        "你想参加 " + curLocation.name
                        + " 并消耗 " + curLocation.cost() + " 点能量嘛?", "冲！", "不冲"))
                    {
                        Global.p.energy -= curLocation.cost();
                        Global.map[Global.p.location].level++;
                        Global.map[Global.p.location].owner = 0;
                    }
                }
                // upgrade or not
                else if (curLocation.owner == 0)
                {
                    if (EditorUtility.DisplayDialog("该行动啦！",
                        "你想升级 \"" + curLocation.name
                        + "\" 并消耗 " + curLocation.cost() + " 点体力嘛？", "冲！", "不冲"))
                    {
                        Global.p.energy -= curLocation.cost();
                        Global.map[Global.p.location].level++;
                    }
                }
                // already occupied by robots
                else if (curLocation.owner != 0)
                {
                    if (EditorUtility.DisplayDialog("该行动啦！",
                        "你得参加 \"" + curLocation.name
                        + "\" 并消耗 " + curLocation.cost() + " 点能力。", "惨兮兮"))
                    {
                        Global.p.energy -= curLocation.cost();
                        Global.robot[Global.map[Global.p.location].owner - 1].energy += curLocation.cost();
                    }
                }
            }
            // special locations
            else
            {
                ;
            }
            // end operating
            ope = 0;
        }
        // to report if robot 3 has finished
        else if (Global.p.state == 1 && Global.step == 0 && remind == 0)
        {
            if (Global.roundNum != 1)
            {

                EditorUtility.DisplayDialog("第 " + Global.roundNum + " 回合",
                    "亲爱的 " + Global.robot[2].name
                    + "同学 完成了自己的回合！", "了解了");
            }


            EditorUtility.DisplayDialog("第 " + Global.roundNum + " 回合", "冲冲冲！", "了解了");

            remind = 1;
        }
        // robot move and operate
        else if (Global.p.state == 0)
        {
            //////////ROBOT//////////
            // start robot moving
            int num = -1;
            if (Global.robot[0].state == 1)
            {
                num = 0;
            }
            else if (Global.robot[1].state == 1)
            {
                num = 1;
            }
            else if (Global.robot[2].state == 1)
            {
                num = 2;
            }
            // start process
            System.Random r = new System.Random();
            int step = r.Next(100) % 6 + 1;
            Global.robot[num].location = (Global.robot[num].location + step) % 40;
            // enable animation
            // Global.robot[num].state = 1;

            // start operating
            // eliminate forbidden locations
            if (Global.robot[num].location != 0 && Global.robot[num].location != 10
                && Global.robot[num].location != 20 && Global.robot[num].location != 30
                && Global.robot[num].location != 5 && Global.robot[num].location != 15
                && Global.robot[num].location != 25 && Global.robot[num].location != 35)
            {
                // current position
                Global.activity curLocation = Global.map[Global.robot[num].location];
                // if not occupied
                if (curLocation.level == 0)
                {
                    Global.robot[num].energy -= curLocation.cost();
                    Global.map[Global.robot[num].location].level++;
                }
                // upgrade or not
                else if (curLocation.owner == num + 1)
                {
                    Global.robot[num].energy -= curLocation.cost();
                    Global.map[Global.robot[num].location].level++;
                }
                // already occupied by player
                else if (curLocation.owner == 0)
                {
                    Global.robot[num].energy -= curLocation.cost();
                    Global.p.energy += curLocation.cost();
                }
                // already occupied by a robot
                else if (curLocation.owner != num + 1)
                {
                    Global.robot[num].energy -= curLocation.cost();
                    Global.robot[Global.map[Global.robot[num].location].owner - 1].energy
                        += curLocation.cost();
                }
            }
            // special occasions
            else
            {
                ;
            }
            // end operating

            // end process
            Global.robot[num].state = 0;
            if (num == 0)
            {
                Global.robot[1].state = 1;
            }
            else if (num == 1)
            {
                Global.robot[2].state = 1;
            }
            else if (num == 2)
            {
                Global.p.state = 1;
            }


            //////////ROBOT//////////
            if (num == 2)
            {
                // next round
                // Global.p.state = 1;
                Global.step = 0;
                Global.roundNum++;

            }
        }


    }
}
