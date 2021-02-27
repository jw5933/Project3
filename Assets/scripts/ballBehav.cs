using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehav : MonoBehaviour
{
    //public SpriteRenderer myRenderer;
    public Color myColour;

    //camera
    /*public GameObject cam;
    public camFollow camScript;
    public Transform nextBall;*/

    Rigidbody2D body;
    public float power;
    
    // Start is called before the first frame update
    void Start()
    {
        //myRenderer = gameObject.GetComponent<SpriteRenderer>();
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnCollisionEnter2D(Collision2D other) {
        //myRenderer.color= myColour;
        if(other.gameObject.name == "piston"){
            //Debug.Log("hit by block");
            body.AddForce(new Vector3(1,0,0)*power);
        }
        if(other.gameObject.tag == "domino"){
            body.velocity = new Vector2(0f,0f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        //if(other.gameObject.name == "Gate"){
           // myRenderer.color= myColour;
        //}
    }
}
