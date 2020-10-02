using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] myObjects;


    private void Start()
    {
        
    }

   public void spawnGrass()
        {
        Instantiate(myObjects[0], new Vector3 (0,0,0), Quaternion.identity);
        Debug.Log("grass");
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
