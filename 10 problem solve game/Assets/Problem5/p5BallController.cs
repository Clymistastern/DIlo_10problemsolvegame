using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p5BallController : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;
    public float speed = 5f;
    private Vector3 target;
 
     void Start () {
        rigidBody2D = GetComponent<Rigidbody2D>();
        target = transform.position;
    }
     
     void Update () {
        if (Input.GetMouseButtonDown(0)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }    
}
