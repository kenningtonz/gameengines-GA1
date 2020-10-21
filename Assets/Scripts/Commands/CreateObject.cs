using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : Command
{
    private GameObject m_Object;
    private Vector3 m_position;

    public CreateObject(GameObject Object, Vector3 Position)
    {
        m_Object = Object;
            m_position = Position;
   
    }

    public  void Execute()
    {
        if (m_Object.activeSelf == false)
        {

            m_Object.SetActive(true);
        }
        else
        {
          //  Debug.Log("created");
          m_Object =   MonoBehaviour.Instantiate(m_Object, m_position, Quaternion.Euler(0,0,0));
        }
    }


    public void Undo()
    {
        m_Object.SetActive(false);


    }


}
