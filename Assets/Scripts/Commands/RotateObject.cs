using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : Command
{

    public Vector3 m_direction;

    public override void Execute()
    {
        this.transform.rotation = Quaternion.Euler(m_direction);
    }

    public override void Undo()
    {
       this.transform.rotation = Quaternion.Euler(-m_direction);
    }


}
