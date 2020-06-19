using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawnerscript : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    float PositionY;
    public float timeLeft = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        int obstacle = Random.Range(1, 4);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 1;
            if (obstacle == 1)
            {
                PositionY = Random.Range(4, -4f);
                this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                Instantiate(obstacle1, transform.position, transform.rotation);
            }
            else if (obstacle == 2)
            {
                PositionY = Random.Range(4, -4f);
                this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                Instantiate(obstacle2, transform.position, transform.rotation);
            }
            else if (obstacle == 3)
            {
                PositionY = Random.Range(4, -4f);
                this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                Instantiate(obstacle3, transform.position, transform.rotation);
            }

        }
        
    }
    

}
