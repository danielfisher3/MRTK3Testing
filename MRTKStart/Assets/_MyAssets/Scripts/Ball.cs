using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool moveForward = false;
   
    // Start is called before the first frame update
    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (moveForward)
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }

        
    }
   
}
