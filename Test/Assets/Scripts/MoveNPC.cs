using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    public Transform player;
    public Transform npc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We want the NPC to look at the playerS
        transform.LookAt(player.transform);
    }
}
