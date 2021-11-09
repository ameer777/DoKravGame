using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-13.10f,13.2f),
        Mathf.Clamp(transform.position.y,-4f,4f) , transform.position.z);
    }
}
