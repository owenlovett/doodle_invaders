using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(this.gameObject);
        if (coll.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Hit Ground");
        }
    }
}
