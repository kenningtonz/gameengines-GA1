using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnselectAll : Command
{
    private GameObject m_Object;
    private string originaltag;

    public UnselectAll(GameObject Object)
    {
        m_Object = Object;
        originaltag = Object.transform.tag;

    }
    public  void Execute()
    {
        m_Object.transform.tag = "UnSelected";
        m_Object.GetComponent<ParticleSystem>().Stop();
    }



    public  void Undo()
    {
        if (originaltag == "Selected")
        {
            m_Object.GetComponent<ParticleSystem>().Play();
        }
    }
}
