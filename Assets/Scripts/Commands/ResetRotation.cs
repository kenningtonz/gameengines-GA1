using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : Command
{
    private GameObject m_Object;
  private Quaternion oldrotation;

    public ResetRotation(GameObject Object)
    {
        m_Object = Object;
        oldrotation = m_Object.transform.rotation;
    }

    public  void Execute()
    {

        m_Object.transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    public  void Undo()
    {
        m_Object.transform.rotation = oldrotation;
    }


}
