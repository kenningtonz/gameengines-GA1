using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] myObjects;
  // public GameObject camera; // gonna make the object spawn in front of the camera
    public bool gravity;


    private void Start()
    {
        
    }
    public void isGravity()
    {
     gravity = !gravity;
       // Debug.Log("gravity toggled"); 
    }



    public void spawnGrass()
        {
        Instantiate(myObjects[0], new Vector3 (0,0,0), Quaternion.identity);
        //Debug.Log("grass");
        }

    public void spawnTreeSpruce()
    {
        Instantiate(myObjects[1], new Vector3(0, 0, 0), Quaternion.identity);
    //    Debug.Log("grass");
    }

    public void spawnTreeOak()
    {
        Instantiate(myObjects[2], new Vector3(0, 0, 0), Quaternion.identity);
      //  Debug.Log("grass");
    }

    public void spawnSqurePole()
    {
        Instantiate(myObjects[3], new Vector3(0, 0, 0), Quaternion.identity);
        
    }

    public void spawnSpike()
    {
        Instantiate(myObjects[4], new Vector3(0, 0, 0), Quaternion.identity);
        
    }

    public void spawnPipe()
    {
        Instantiate(myObjects[5], new Vector3(0, 0, 0), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
