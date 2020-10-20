using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ObjectManager 
{

    public static ObjectManager Instance()
    {
        if (ObjectManager.instance == null)
        {
            instance = new ObjectManager();
        }
        return instance;
    }
    
    private ObjectManager()
    {

    }

    private static ObjectManager instance;


 

}
