using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnButton : MonoBehaviour
{
   // public ObjectType objectspawntype;
    // Start is called before the first frame update
    public bool gravity;
  
    public void spawnbuttonnn(int value)
    {
        Debug.Log("buttonspawn");

            ObjectFactory.Instance().createobject((ObjectType)value);
      
    }



    public void isGravity()
    {
        gravity = !gravity;
        // Debug.Log("gravity toggled"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
