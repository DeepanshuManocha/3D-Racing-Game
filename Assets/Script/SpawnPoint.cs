using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Vehicles.Car;

public class SpawnPoint : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
           
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<CarUserControl>().spawnPointPos=gameObject.transform.position;
        }
    }

    
}
