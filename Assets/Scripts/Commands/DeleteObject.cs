using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : Command
{
    private GameObject m_Object;


    public DeleteObject(GameObject Object)
    {
        m_Object = Object;

    }

    public void Execute()
    {
      
            m_Object.SetActive(false);
   
    }

    public  void Undo()
    {
      
            m_Object.SetActive(true);
            m_Object.GetComponent<ParticleSystem>().Play();

    }



}
