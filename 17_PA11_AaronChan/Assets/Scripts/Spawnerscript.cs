using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnRed;
    public GameObject SpawnBrown;
    public GameObject SpawnGreen;

    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        int random = Random.Range(1, 4);

        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        if(random == 1)
        {
            Instantiate(SpawnRed, transform.position, transform.rotation);
        }
        else if (random == 2)
        {
            Instantiate(SpawnBrown, transform.position, transform.rotation);
        }
        else if (random == 3)
        {
            Instantiate(SpawnGreen, transform.position, transform.rotation);
        }       
    }
}
