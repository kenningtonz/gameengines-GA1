using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGravity : Command
{
    private GameObject m_Object;

    public ToggleGravity(GameObject Object)
    {
        m_Object = Object;
    }


    public  void Execute()
    {
        m_Object.transform.GetComponent<Rigidbody>().isKinematic = !m_Object.transform.GetComponent<Rigidbody>().isKinematic;
    }

    public  void Undo()
    {
        m_Object.transform.GetComponent<Rigidbody>().isKinematic = !m_Object.transform.GetComponent<Rigidbody>().isKinematic;
    }
}

