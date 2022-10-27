using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        // NPC1 : 1000, NPC2 : 2000
        // station1 : 100

        talkData.Add(1000, new string[] { "안녕하세요." });
        talkData.Add(2000, new string[] { "좋은 하루입니다."});
        talkData.Add(3000, new string[] { "강의 열심히 들으세요!"});
        talkData.Add(4000, new string[] { "Ai 공학관은 너무 멀어.."});
        talkData.Add(5000, new string[] { "시험을 망쳤어ㅠㅠ"});
        talkData.Add(6000, new string[] { "이번에 좋은 성적을 받았당~"});
        talkData.Add(7000, new string[] { "좋은 하루 되세요~"});
        talkData.Add(8000, new string[] { "날씨 너무 좋다."});
        talkData.Add(9000, new string[] { "좋은 대학생활 보내고 싶다."});

        talkData.Add(1500, new string[] { "여기는 비전타워 입니다." });
        talkData.Add(2500, new string[] { "여기는 IT대학 입니다." });
        talkData.Add(3500, new string[] { "여기는 가천관 입니다." });
        talkData.Add(4500, new string[] { "여기는 글로벌센터 입니다." });
        talkData.Add(5500, new string[] { "여기는 중앙도서관 입니다." });
        talkData.Add(6500, new string[] { "여기는 한의대학 입니다." });

        // Quest Talk
        
        talkData.Add(10 + 1000, new string[]
        {
            "안녕하세요. ", "비전타워로 가주세요", "네, 알겠습니다."
        });

        talkData.Add(11 + 1500, new string[]
        {
            "비전타워 도착했습니다."
        });

        talkData.Add(20 + 2000, new string[]
        {
            "안녕하세요. ", "가천관으로 가주세요", "네, 알겠습니다."
        });
        talkData.Add(21 + 3500, new string[]
        {
            "가천관 도착했습니다."
        });

        talkData.Add(30 + 3000, new string[]
        {
            "안녕하세요. ", "글로벌센터로 가주세요", "네, 알겠습니다."
        });
        talkData.Add(31 + 4500, new string[]
        {
            "글로벌센터 도착했습니다."
        });

        talkData.Add(40 + 4000, new string[]
        {
            "안녕하세요. ", "중앙도서관으로 가주세요", "네, 알겠습니다."
        });
        talkData.Add(41 + 5500, new string[]
        {
            "중앙도서관 도착했습니다."
        });

        talkData.Add(50 + 5000, new string[]
       {
            "안녕하세요. ", "한의대학건물로 가주세요", "네, 알겠습니다."
       });
        talkData.Add(51 + 6500, new string[]
        {
            "한의대학 도착했습니다."
        });

        talkData.Add(60 + 6000, new string[]
       {
            "안녕하세요. ", "IT대학건물로 가주세요", "네, 알겠습니다."
       });
        talkData.Add(61 + 2500, new string[]
        {
            "IT대학 도착했습니다."
        });

        talkData.Add(70 + 7000, new string[]
       {
            "안녕하세요. ", "글로벌센터로 가주세요", "네, 알겠습니다."
       });
        talkData.Add(71 + 4500, new string[]
        {
            "IT대학 도착했습니다."
        });

        talkData.Add(80 + 8000, new string[]
       {
            "안녕하세요. ", "가천관으로 가주세요", "네, 알겠습니다."
       });
        talkData.Add(81 + 3500, new string[]
        {
            "가천관 도착했습니다."
        });

        talkData.Add(90 + 9000, new string[]
{
            "안녕하세요. ", "비전타워로 가주세요", "네, 알겠습니다."
});
        talkData.Add(91 + 1500, new string[]
        {
            "비전타워 도착했습니다."
        });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if(!talkData.ContainsKey(id))
        {
            if(!talkData.ContainsKey(id-id%10))
            {
                return GetTalk(id - id % 100, talkIndex);
            }
            else
            {
                return GetTalk(id - id % 10, talkIndex);
            }
        }
        if(talkIndex==talkData[id].Length)
        {
            return null;
        }
        else
        {
            return talkData[id][talkIndex];
        }    
    }
}
