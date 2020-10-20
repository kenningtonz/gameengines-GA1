using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : Command
{
    //private GameObject m_Object;
    //private Vector3 m_position;
    //private Quaternion m_rotation;

    //public CreateObject(GameObject Object, Vector3 position, Quaternion rotation)
    //{
    //    m_Object = Object;
    //    m_position = position;
    //    m_rotation = rotation;
    //}

    public override void Execute()
    {
        Debug.Log("created");
        Instantiate(this);
    }


    public override void Undo()
    {
        Destroy(this);
    }


}
