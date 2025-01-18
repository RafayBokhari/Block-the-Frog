using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] GameObject clouds;
    [SerializeField] float cloudSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawningClouds());

    }

    // Update is called once per frame
    void Update()
    {
    }

    void CloudsSpawn()
    {
        Instantiate(clouds,transform.position,Quaternion.identity);
    }

    IEnumerator SpawningClouds()
    {
        while (true)
        {

            yield return new WaitForSeconds(cloudSpawnTime);
            CloudsSpawn();
        }
    } 
}
