using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GameManager : NetworkBehaviour
{
    public Vector3 spawnPointPos;
    [SerializeField] GameObject spawnPoint;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
        
        spawnPointPos = spawnPoint.transform.position;
            Debug.Log(player);
       
    }

    


    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                //player = GameObject.FindGameObjectWithTag("Player");
                CmdRespawnVehicle();
            }
       
    }

    
    void CmdRespawnVehicle()
    {
        player.transform.position = new Vector3(spawnPointPos.x, spawnPointPos.y, spawnPointPos.z);
       
    }
}
