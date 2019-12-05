using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code taken from: https://answers.unity.com/questions/789096/how-to-make-the-npc-face-the-player.html

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
        Debug.Log(player.transform.position);
        Debug.Log(npc.transform.position);
        Debug.Log("");

        //Vector3 playerPos = player.transform.position;
        //Vector3 npcPos = npc.transform.position;
        //Vector3 delta = new Vector3(playerPos.x - npcPos.x, 0.0f, playerPos.z - npcPos.z);
        //Quaternion rotation = Quaternion.LookRotation(delta);
        //npc.transform.rotation = rotation;

        transform.LookAt(player.transform);
    }
}
