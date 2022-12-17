using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PachinkoBall : MonoBehaviour
{
    private int score;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5)
        { transform.position = new Vector3(Random.Range(-7f, 7f), 6, 0); }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pin")
        {
            score++;
            Debug.Log("Score: " + score);
        }
    }

}
