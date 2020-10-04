using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{

    public GameObject gameObjectcontroller;

    //  GameObject gameObject;
    public float speed = 10.0f;
    private Quaternion resetrotate;
    void Start()
    {

         resetrotate = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
     }

    // Update is called once per frame
    void Update()
    {

        if (gameObjectcontroller.GetComponent<UI>().gravity == true)
        {
           // Debug.Log("gravitytreu");
            this.transform.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (gameObjectcontroller.GetComponent<UI>().gravity == false)
        {
            //Debug.Log("gravityfalse");
            this.transform.GetComponent<Rigidbody>().isKinematic = false;

        }


        if (this.tag == "Selected")
        {
            if (Input.GetKey(KeyCode.Backspace))
            {
                Debug.Log("delete");
                Destroy(this.gameObject);
            }
            if (Input.GetKey(KeyCode.L))
            {
                Debug.Log("reset");
             this.transform.rotation = resetrotate;
            }

            //move right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
            //move left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
            //move backwards
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0 ));
            }
            //move forwards
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(new Vector3(0, speed * Time.deltaTime,0));
            }


        }
        
    }

}
