using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUpdated : MonoBehaviour
{
    public GameObject otherpref;
    public GameObject fuelcan;
    public GameObject fuelcan2;
    public GameObject lazer;
    public GameObject lazer2;

    //This script moves prefabs defined when the player hits trigger.(collides with it).
    void OnTriggerEnter2D(Collider2D col)
    {
        // If the player collided with a fuel can
        Debug.Log("in OnTriggerEnter2D");
        Debug.Log("col.gameObject.tag is: " + col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("in OnTriggerEnter2D with TriggerTag");
            int spawncan = Random.Range(0, 4);
            if (spawncan == 0)
            {
                fuelcan.SetActive(false);
                fuelcan2.SetActive(true);
                lazer.SetActive(true);
                lazer2.SetActive(true);
            }

            if (spawncan == 1)
            {
                fuelcan.SetActive(true);
                fuelcan2.SetActive(false);
                lazer.SetActive(false);
                lazer2.SetActive(true);
            }

            if (spawncan == 2)
            {
                fuelcan.SetActive(true);
                fuelcan2.SetActive(true);
                lazer.SetActive(true);
                lazer2.SetActive(true);
            }

            if (spawncan == 3)
            {
                fuelcan.SetActive(true);
                fuelcan2.SetActive(true);
                lazer.SetActive(true);
                lazer2.SetActive(false);
            }

            Vector3 position = new Vector3(otherpref.transform.position.x + (72), 0);
            otherpref.transform.position = position;
        }
    }
}
