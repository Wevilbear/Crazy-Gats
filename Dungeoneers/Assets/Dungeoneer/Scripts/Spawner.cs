using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    float timer = 0;
    public float spawnRate;
    public int HP;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnRate)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            timer = 0;
        }
        if(HP <= 0)
        {
            //////
            gameObject.SetActive(false);

        }
    }
}
