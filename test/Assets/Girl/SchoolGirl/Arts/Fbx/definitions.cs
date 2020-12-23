using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Threading;
using System;

public class Global
{
    public static int roundNum;

    // the appearence you choose
    // 0 sailor boy
    // 1 sweater girl
    // 2 sailor girl
    // 3 sweater boy
    public static int typeNum;

    public class player
    {
        public string name;
        public int gender;      //1 male 2 female
        public int type;        //0 科研 1 体育 2 社工 3 志服
        public string department;
        public int energy;
        public int[] point;
        public int location;    //0-39, 40 boxes
        public int love;        //-1 single 0-3 the number of player you love
        public int state;       //0 not your turn; 1 your turn
        public int[] honor;
        public int[] setPoint()
        {
            int[] result = new int[5] { 80, 80, 80, 80, 80 };
            return result;
        }
        public int[] setHonor()
        {
            int[] honor = new int[5] { 0,0,0,0,0 };
            return honor;
        }
        public string setDepartment(int i)
        {
            string[] list = new string[4] { "EE", "SEM", "SVM", "SSS" };
            return list[i];
        }
        public player()
        {
            name = "Anthony";
            gender = 1;
            type = 0;
            department = "EE";
            point = setPoint();
            honor = setHonor();
            location = 0;
            love = 0;
            state = 0;
            energy = 100;
        }
        public player(string n, int g, int t, int d)
        {
            name = n;
            gender = g;
            type = t;
            department = setDepartment(d);
            point = setPoint();
            honor = setHonor();
            location = 0;
            love = 0;
            state = 0;
            energy = 100;
        }
        public void setInfo(string n, int g, int t, int d)
        {
            name = n;
            gender = g;
            type = t;
            department = setDepartment(d);
            point = setPoint();
            honor = setHonor();
        }

    }

    public class activity
    {
        private int type;       //1 class 2 sport 3 innovate 4 volunteer 5 social 0 start 6 dorm 7 hospital 8 test 9 challenge 10 chance
        private int diffCoef;
        public string name;
        public int level;       //the level, initial 0
        public double point;    //the point you would get
        public int owner;    //owner of this activity: -1 unoccupied 0 me 1-3 robot
        public int location;
        public activity()
        {
            type = 1;
            diffCoef = 1;
            name = setType(type);
            level = 1;
            point = 1;
            location = 0;
            owner = 1;
        }
        public void setInfo(int t = 1, int d = 1, int l = 0, int p = 1, int loc = 0)
        {
            type = t;
            diffCoef = d;
            name = setType(type);
            level = l;
            point = p;
            location = loc;
        }
        public activity(int t, int d, string n, int l, int p, int loc)
        {
            type = t;
            diffCoef = d;
            name = n;
            level = l;
            point = p;
            location = loc;
            owner = 1;
        }
        private string setType(int t)
        {
            if (t == 1)
                return "class";
            else if (t == 2)
                return "sports activity";
            else if (t == 3)
                return "science research";
            else if (t == 4)
                return "voluntary work";
            else if (t == 5)
                return "social work";
            else if (t == 0)
                return "start";
            else if (t == 6)
                return "dorm";
            else if (t == 7)
                return "hospital";
            else if (t == 8)
                return "test";
            else if (t == 9)
                return "challenge";
            else if (t == 10)
                return "chance";

            return "Not Defined";           //in case it does not work
        }
        public int cost(int[] AP)
        {
            return 1;
        }
        public int cost()       // used for test
        {
            return 1;
        }
        public void upgrade()
        {
            level++;
            point += 0.1;
        }
    }

    public static activity[] map = new activity[40];

    public static player p = new player();

    public static player[] robot = new player[3];

    public static int step;             // 0 for ready to move; -1 for not ready to move; 1-6 for move

    //loc: original location; step: steps to move
    public static float[] move(int loc, int step)
    {
        double x, z;
        x = 0;
        z = 0;
        double turnOrNot = 0;
        int newLoc = (loc + step) % 40;
        if (newLoc == 0)
        {
            x = -27.5;
            z = 27.5;
        }
        else if (newLoc == 10)
        {
            x = 27.5;
            z = 27.5;
        }
        else if (newLoc == 20)
        {
            x = 27.5;
            z = -27.5;
        }
        else if (newLoc == 30)
        {
            x = -27.5;
            z = -27.5;
        }
        else if (newLoc == 20)
        {
            x = 27.5;
            z = -27.5;
        }

        if (newLoc > 0 && newLoc < 10)
        {
            z = 30;
            x = 5 * newLoc - 25;
        }
        else if (newLoc > 10 && newLoc < 20)
        {
            x = 30;
            z = -5 * newLoc + 75;
        }
        else if (newLoc > 20 && newLoc < 30)
        {
            z = -30;
            x = -5 * newLoc + 125;
        }
        else if (newLoc > 30 && newLoc < 40)
        {
            x = -30;
            z = 5 * newLoc - 175;
        }

        if (newLoc / 10 != loc / 10)
        {
            turnOrNot = 1;
        }
        else
        {
            turnOrNot = 0;
        }

        // result = [new x, new z, turnOrNot]
        float[] result = new float[3];
        result[0] = Convert.ToSingle(x);
        result[1] = Convert.ToSingle(z);
        result[2] = Convert.ToSingle(turnOrNot);
        return result;
    }

    public static float[] move(int newLoc)
    {
        double x, z;
        x = 0;
        z = 0;
        double turnY = 0;
        if (newLoc == 0)
        {
            x = -27.5;
            z = 27.5;
        }
        else if (newLoc == 10)
        {
            x = 27.5;
            z = 27.5;
        }
        else if (newLoc == 20)
        {
            x = 27.5;
            z = -27.5;
        }
        else if (newLoc == 30)
        {
            x = -27.5;
            z = -27.5;
        }
        else if (newLoc == 20)
        {
            x = 27.5;
            z = -27.5;
        }

        if (newLoc > 0 && newLoc < 10)
        {
            z = 30;
            x = 5 * newLoc - 25;
        }
        else if (newLoc > 10 && newLoc < 20)
        {
            x = 30;
            z = -5 * newLoc + 75;
        }
        else if (newLoc > 20 && newLoc < 30)
        {
            z = -30;
            x = -5 * newLoc + 125;
        }
        else if (newLoc > 30 && newLoc < 40)
        {
            x = -30;
            z = 5 * newLoc - 175;
        }

        if (newLoc >= 0 && newLoc < 10)
        {
            turnY = 90;
        }
        else if (newLoc >= 10 && newLoc < 20)
        {
            turnY = 180;
        }
        else if (newLoc >= 20 && newLoc < 30)
        {
            turnY = 270;
        }
        else if (newLoc >= 30 && newLoc < 40)
        {
            turnY = 0;
        }

        // result = [new x, new z, turnOrNot]
        float[] result = new float[3];
        result[0] = Convert.ToSingle(x);
        result[1] = Convert.ToSingle(z);
        result[2] = Convert.ToSingle(turnY);
        return result;
    }

}


public class definitions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("It works!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
