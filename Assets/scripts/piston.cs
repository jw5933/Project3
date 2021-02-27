using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piston : MonoBehaviour
{

    //variables
    private Rigidbody2D body;
    public float power;
    public float startX;
    //public float timeBack;
    
    private Vector2 veloRe;
    private Vector2 veloEx;

    bool retract;
    bool extend;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        veloRe = new Vector2(-1,0); //retraction
        veloEx = new Vector2(1,0); //extention
        retract = false;
        extend = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            extend = true;
        }

    if (extend){
            body.MovePosition(body.position + veloEx*power *Time.deltaTime);
    }

    if (retract){
        if (body.position.x >= startX){
            body.MovePosition(body.position + veloRe*power *Time.deltaTime);
        }
        else{
            retract = false;
        }
    }
    
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        extend = false;
        retract = true;
    }


}
