using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2 : MonoBehaviour
{
    //public SpriteRenderer myRenderer;
    public Color myColour;

    Rigidbody2D body;
    public float power;
    bool slowStop;
    
    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        //myRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(slowStop){
            body.velocity = new Vector2(body.velocity.x*0.9f,body.velocity.y);
        }
    }
    
    void OnCollisionEnter2D(Collision2D other) {
        //myRenderer.color= myColour;
        
        if(other.gameObject.name == "rotate"){
            body.AddForce(new Vector3(1,1,0)*power);
        }
        if(other.gameObject.name == "rotate4" || other.gameObject.name == "pl"){
            body.AddForce(new Vector3(-1,0,0)*power);
        }
        if (other.gameObject.name == "wagon" || other.gameObject.name == "pr2" || 
        other.gameObject.name == "pr1" || other.gameObject.name == "seesaw"){
            //Debug.Log("Hit wagon");
            //body.velocity = new Vector2(0.05f, 0);
            slowStop = true;
            //body.velocity = new Vector2(0f,body.velocity.y);
            //body.angularVelocity = 0f;
        }
       /* if(other.gameObject.name == "pl"){
            body.AddForce(new Vector3(-1,1,0)*power);
        }*/

    }

     void OnTriggerEnter2D(Collider2D other)
    {
        
        //if(other.gameObject.name == "Gate"){
        //    myRenderer.color= myColour;
        //}
    }
}
