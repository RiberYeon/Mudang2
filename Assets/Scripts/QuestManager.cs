using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;

    public GameObject[] questObject;

    Dictionary<int, QuestData> questList;

    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    void GenerateData()
    {
        questList.Add(10, new QuestData("NPC1 铰按 怕快扁", new int[] { 1000, 1500 }));
        questList.Add(20, new QuestData("NPC2 铰按 怕快扁", new int[] { 2000, 3500 }));
        questList.Add(30, new QuestData("NPC3 铰按 怕快扁", new int[] { 3000, 4500 }));
        questList.Add(40, new QuestData("NPC4 铰按 怕快扁", new int[] { 4000, 5500 }));
        questList.Add(50, new QuestData("NPC5 铰按 怕快扁", new int[] { 5000, 6500 }));
        questList.Add(60, new QuestData("NPC6 铰按 怕快扁", new int[] { 6000, 2500 }));
        questList.Add(70, new QuestData("NPC7 铰按 怕快扁", new int[] { 7000, 4500 }));
        questList.Add(80, new QuestData("NPC8 铰按 怕快扁", new int[] { 8000, 3500 }));
        questList.Add(90, new QuestData("NPC9 铰按 怕快扁", new int[] { 9000, 1500 }));
        questList.Add(100, new QuestData("涅胶飘 努府绢!", new int[] { 0 }));
    }

    public int GetQuestTalkIndex(int id)
    {
        return questId + questActionIndex;
    }

    public string CheckQuest(int id)
    {
        if (id == questList[questId].npcId[questActionIndex])
        {
            questActionIndex++;
        }

        if (questActionIndex == questList[questId].npcId.Length)
        {
            NextQuest();
        }

        return questList[questId].questName;
    }
    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
        
    }
}
