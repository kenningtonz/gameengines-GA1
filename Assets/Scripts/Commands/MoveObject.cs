using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : Command
{

   public Vector3 m_direction;


    public override void Execute()
    {
        this.transform.position += m_direction;
    }

    public override void Undo()
    {
        this.transform.position -= m_direction;
    }

}

  
