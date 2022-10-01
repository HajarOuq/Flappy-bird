using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclespawner : MonoBehaviour
{
    public float minY;
    public float maxY;
    public float distance;

   

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Obstacle")
        {
            //col.tag == col.gameObject.tag ???
            float obstacleY = Random.Range(minY, maxY);

            Vector3 spawnposition = new Vector3(transform.position.x + distance, obstacleY, 0);

            col.gameObject.transform.position = spawnposition;
        }
    }
}
