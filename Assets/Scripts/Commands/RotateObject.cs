using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : Command
{
    private GameObject m_Object;
    private Vector3 m_direction;


    public RotateObject(GameObject Object, Vector3 Direction)
    {
        m_Object = Object;
        m_direction = Direction;
    }

    public  void Execute()
    {
        m_Object.transform.rotation = Quaternion.Euler(m_direction);
    }

    public  void Undo()
    {
        m_Object.transform.rotation = Quaternion.Euler(-m_direction);
    }


}
