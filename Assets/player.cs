using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed;
    public float lookspeed;

    public Camera maincamera;

   
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "UnSelected")
               {
                    hit.transform.tag = "Selected";
                    Debug.Log("slected");

                }
                else if (hit.transform.tag == "Selected")
                {
                    hit.transform.tag = "UnSelected";
                    Debug.Log("unslected");
                }
               
               
            }

        }
        /////////
        //movement

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

        /////////////
        //Looking

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

        //look up
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(new Vector3(-lookspeed * Time.deltaTime, 0, 0));
        }

        //look down
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(new Vector3(lookspeed * Time.deltaTime, 0, 0));
        }



    }
}
