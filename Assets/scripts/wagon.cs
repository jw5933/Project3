using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wagon : MonoBehaviour
{
    Rigidbody2D body;
    public float power;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "ball4"){
            body.AddForce(Vector3.right*power);
        }
    }
}
