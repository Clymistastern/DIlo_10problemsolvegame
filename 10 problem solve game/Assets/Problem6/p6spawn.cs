using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p6spawn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject ball;
    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Random.Range(9, 10); i++)
        {
			float[] horizontalPos = new float[2];
			horizontalPos[0] = Random.Range(ball.transform.position.x + y, ball.transform.position.x + x);
			horizontalPos[1] = Random.Range(ball.transform.position.x - x, ball.transform.position.x - y);
			
			float[] verticalPos = new float[2];
			verticalPos[0] = Random.Range(ball.transform.position.y + y, ball.transform.position.y + x);
			verticalPos[1] = Random.Range(ball.transform.position.y - x, ball.transform.position.y - y);
			
			Vector2 position = new Vector2(
				horizontalPos[Random.Range(0, 2)], 
				verticalPos[Random.Range(0, 2)]
			);
			
			Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
