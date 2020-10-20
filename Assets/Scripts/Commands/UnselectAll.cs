using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnselectAll : Command
{
    //private GameObject m_Object;
    private string originaltag;

    //public UnselectAll(GameObject Object)
    //{
    //    m_Object = Object;
    //    originaltag = Object.transform.tag;

    // }
    public override void Execute()
    {
        originaltag = this.transform.tag;
        this.transform.tag = "UnSelected";
        this.GetComponent<ParticleSystem>().Stop();
    }



    public override void Undo()
    {
        if (originaltag == "Selected")
        {
            this.GetComponent<ParticleSystem>().Play();
        }
    }
}
