using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover2 : MonoBehaviour
{
    float stepsize = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.position+= new Vector3(0,stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.position+= new Vector3(0,-stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.A)){
            transform.position+= new Vector3(-stepsize * Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.position+= new Vector3(stepsize * Time.deltaTime,0,0);
        }
    }
}
