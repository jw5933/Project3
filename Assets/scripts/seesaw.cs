using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seesaw : MonoBehaviour
{
    public GameObject throwObj;
    Rigidbody2D body;
    public float power;
    bool ballHit;
    bool addedForce;

    // Start is called before the first frame update
    void Start()
    {
        ballHit = false;
        addedForce = false;
        body = (Rigidbody2D)throwObj.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ball"){
            ballHit = true;
        }
        if (other.gameObject.name == "sq"){
            body.velocity = new Vector2(0f,0f);
        }
        if (other.gameObject.name == "s8" && ballHit && !addedForce){
            body.AddForce(new Vector3(0.6f,1,0)*power);
            addedForce = true;
        }
    }
}
