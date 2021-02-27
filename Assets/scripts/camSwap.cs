using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwap : MonoBehaviour
{
    //camera
    public GameObject cam;
    camFollow camScript;
    public Transform nextObj;
    bool alreadyFollowed;

    // Start is called before the first frame update
    void Start()
    {
        alreadyFollowed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ball"){
            //cam = GameObject.Find("mainCam");
            if(!alreadyFollowed){
            camScript = (camFollow)cam.GetComponent(typeof(camFollow));
            camScript.followTransform = nextObj;
            alreadyFollowed = true;
            }
        }
    }

}
