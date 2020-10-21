using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecting : Command
{
    private GameObject m_Object;
    public Selecting(GameObject Object)
    {
        m_Object = Object;
    }

    public  void Execute()
    {
        //select objects
        if (m_Object.transform.CompareTag("UnSelected"))
        {
            m_Object.transform.tag = "Selected";
            m_Object.transform.GetComponent<ParticleSystem>().Play();
        }
        else if (m_Object.transform.CompareTag("Selected"))
        {
            m_Object.transform.tag = "UnSelected";
            m_Object.transform.GetComponent<ParticleSystem>().Stop();
        }
    }

    public  void Undo()
    {
        if (m_Object.transform.CompareTag("UnSelected"))
        {
            m_Object.transform.tag = "Selected";
            m_Object.transform.GetComponent<ParticleSystem>().Play();
        }
        else if (m_Object.transform.CompareTag("Selected"))
        {
            m_Object.transform.tag = "UnSelected";
            m_Object.transform.GetComponent<ParticleSystem>().Stop();
        }
    }
}
