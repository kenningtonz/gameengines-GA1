using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnButton : MonoBehaviour
{
  
  
    public void spawnbuttonnn(int value)
    {
    
         ObjectFactory.Instance().createobject((ObjectType)value);

    }

    public void undofunction()
    {
       CommandManager.Instance().undocommand();

    }
    public void redofunction()
    {
        CommandManager.Instance().redocommand();
    }


}
