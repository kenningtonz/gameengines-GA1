using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // Start is called before the first frame update

  //  GameObject gameObject;
    public float speed = 10.0f;

    void Start()
    {
     
     }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Debug.Log("kinimatic");
            this.transform.GetComponent<Rigidbody>().isKinematic = !this.transform.GetComponent<Rigidbody>().isKinematic;
        }


        if (this.tag == "Selected")
        {
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
