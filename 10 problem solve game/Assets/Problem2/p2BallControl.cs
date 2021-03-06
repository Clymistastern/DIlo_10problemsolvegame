using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2BallControl : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;
 
    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float xInitialForce;
    public float yInitialForce;

    float directionIndex;

     void ResetBall()
    {
        // Reset posisi menjadi (0,0)
        transform.position = Vector2.zero;
 
        // Reset kecepatan menjadi (0,0)
        rigidBody2D.velocity = Vector2.zero;
    }

    void PushBall()
    {
        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);

        // Jika nilainya di bawah 1, bola bergerak ke kiri. 
        // Jika tidak, bola bergerak ke kanan.
        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            rigidBody2D.AddForce(new Vector2(-xInitialForce, -yInitialForce));
            directionIndex = 1f;
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(xInitialForce, -yInitialForce));
            directionIndex = -1f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        // Kembalikan bola ke posisi semula
        ResetBall();
 
        // Setelah 2 detik, berikan gaya ke bola
        Invoke("PushBall", 2);
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
