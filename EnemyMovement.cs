using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction towards the target
        Vector3 direction = target.position - transform.position;

        // Move the enemy towards the target
        transform.position += direction.normalized * speed * Time.deltaTime;
    }
}
