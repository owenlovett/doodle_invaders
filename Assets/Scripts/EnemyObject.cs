using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground") || coll.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
