using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;
    
    public void Action(GameObject scanObj)
    {
        int ran = Random.Range(0, 100);
        if (isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            scanObject = scanObj;
            if(ran % 3 == 0)
            {
                talkText.text = "��õ������ ���ּ���";
            }
            else if (ran % 3 == 1)
            {
                talkText.text = "Ai������ ���ּ���";
            }
            else if (ran % 3 == 2)
            {
                talkText.text = "���а����� ���ּ���";
            }
        }
        talkPanel.SetActive(isAction);
    }
}
