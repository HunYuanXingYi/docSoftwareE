using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class clickEnd : MonoBehaviour
{
    // activate the next player
    public void Click()
    {
        if (Global.p.state == 1 && Global.step == -1)
        {
            Global.p.state = 0;
            Global.robot[0].state = 1;
            EditorUtility.DisplayDialog("结束回合",
                        "您已结束回合", "了解了");
        }
        else if (Global.p.state == 0)
        {
            EditorUtility.DisplayDialog("点错啦！",
                        "不是您的回合", "了解了");
        }
        else if (Global.step == 0 && Global.p.state == 1)
        {
            EditorUtility.DisplayDialog("点错啦",
                        "您倒是摇色子啊！", "好叭");
            //Debug.Log("You have not rolled your dice");
        }
        Global.step = 0;
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
