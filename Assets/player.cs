using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed;
    public float lookspeed;

    public Camera camera;

   
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("slected");
                hit.transform.tag = "Selected";
                // the object identified by hit.transform was clicked
                // do whatever you want
            }

        }
            //move right
            if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        //move left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        //move backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0, -speed * Time.deltaTime));
        }
        //move forwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        //move up
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        //move down
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }

        //look left
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -lookspeed * Time.deltaTime, 0));
        }

        //look right
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, lookspeed * Time.deltaTime, 0));
        }


    }
}
