using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallController : MonoBehaviour
{
    float wait = 0.1f;
    public GameObject enemyObject;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fall", wait, wait);
    }

    void Fall()
    {
        Instantiate(enemyObject, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
    }
}
