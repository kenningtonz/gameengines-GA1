using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : Command
{
    private GameObject m_Object;
    private Vector3 m_direction;

    public MoveObject(GameObject Object, Vector3 Direction)
    {
        m_Object = Object;
        m_direction = Direction;
    }

    public  void Execute()
    {
        m_Object.transform.position += m_direction;
    }

    public  void Undo()
    {
        m_Object.transform.position -= m_direction;
    }

}

  
