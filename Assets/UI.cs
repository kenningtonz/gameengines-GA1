using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] myObjects;
    public GameObject camera; // gonna make the object spawn in front of the camera

    private void Start()
    {
        
    }

   public void spawnGrass()
        {
        Instantiate(myObjects[0], new Vector3 (0,0,0), Quaternion.identity);
        Debug.Log("grass");
        }

    public void spawnTreeSpruce()
    {
        Instantiate(myObjects[1], new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("grass");
    }

    public void spawnTreeOak()
    {
        Instantiate(myObjects[2], new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("grass");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
