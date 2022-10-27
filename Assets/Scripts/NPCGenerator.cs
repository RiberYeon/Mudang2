using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    public GameObject NPC1Prefab;
    public GameObject NPC2Prefab;
    public GameObject NPC3Prefab;
    public GameObject NPC4Prefab;
    public GameObject NPC5Prefab;
    public GameObject NPC6Prefab;
    public GameObject NPC7Prefab;
    public GameObject NPC8Prefab;
    public GameObject NPC9Prefab;


    float span1 = 180.0f;
    float span2 = 180.0f;
    float span3 = 180.0f;
    float span4 = 180.0f;
    float span5 = 180.0f;
    float span6 = 180.0f;
    float span7 = 180.0f;
    float span8 = 180.0f;
    float span9 = 180.0f;

    float delta1 = 180.0f;
    float delta2 = 175.0f;
    float delta3 = 160.0f;
    float delta4 = 145.0f;
    float delta5 = 135.0f;
    float delta6 = 120.0f;
    float delta7 = 100.0f;
    float delta8 = 85.0f;
    float delta9 = 70.0f;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta1 += Time.deltaTime;
        if(this.delta1>this.span1)
        {
            this.delta1 = 0;
            GameObject npc = Instantiate(NPC1Prefab);
            int px1 = Random.Range(-10, -3);
            npc.transform.position = new Vector3(px1, -3.08f, 0);
        }

        this.delta2 += Time.deltaTime;
        if (this.delta2 > this.span2)
        {
            this.delta2 = 0;
            GameObject npc = Instantiate(NPC2Prefab);
            int px2 = Random.Range(3, 12);
            npc.transform.position = new Vector3(px2, -1.1f, 0);
        }

        this.delta3 += Time.deltaTime;
        if (this.delta3 > this.span3)
        {
            this.delta3 = 0;
            GameObject npc = Instantiate(NPC3Prefab);
            int py3 = Random.Range(5, 9);
            npc.transform.position = new Vector3(26.3f, py3, 0);
        }

        this.delta4 += Time.deltaTime;
        if (this.delta4 > this.span4)
        {
            this.delta4 = 0;
            GameObject npc = Instantiate(NPC4Prefab);
            int px4 = Random.Range(-26, -17);
            npc.transform.position = new Vector3(px4, 19.9f, 0);
        }

        this.delta5 += Time.deltaTime;
        if (this.delta5 > this.span5)
        {
            this.delta5 = 0;
            GameObject npc = Instantiate(NPC5Prefab);
            int py5 = Random.Range(8, 22);
            npc.transform.position = new Vector3(-40.3f, py5, 0);
        }

        this.delta6 += Time.deltaTime;
        if (this.delta6 > this.span6)
        {
            this.delta6 = 0;
            GameObject npc = Instantiate(NPC6Prefab);
            int py6 = Random.Range(17, 24);
            npc.transform.position = new Vector3(23.7f, py6, 0);
        }

        this.delta7 += Time.deltaTime;
        if (this.delta7 > this.span7)
        {
            this.delta7 = 0;
            GameObject npc = Instantiate(NPC7Prefab);
            int px7 = Random.Range(2, 13);
            npc.transform.position = new Vector3(px7, 13.7f, 0);
        }

        this.delta8 += Time.deltaTime;
        if (this.delta8 > this.span8)
        {
            this.delta8 = 0;
            GameObject npc = Instantiate(NPC8Prefab);
            int px8 = Random.Range(-39, -33);
            npc.transform.position = new Vector3(px8, 36.7f, 0);
        }

        this.delta9 += Time.deltaTime;
        if (this.delta9 > this.span9)
        {
            this.delta9 = 0;
            GameObject npc = Instantiate(NPC9Prefab);
            int px9 = Random.Range(-7, 9);
            npc.transform.position = new Vector3(px9, 27.9f, 0);
        }
    }
}
