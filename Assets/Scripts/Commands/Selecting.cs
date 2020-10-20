using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecting : Command
{


    public override void Execute()
    {
        //select objects
        if (this.transform.CompareTag("UnSelected"))
        {
            this.transform.tag = "Selected";
            this.transform.GetComponent<ParticleSystem>().Play();
        }
        else if (this.transform.CompareTag("Selected"))
        {
            this.transform.tag = "UnSelected";
            this.transform.GetComponent<ParticleSystem>().Stop();
        }
    }

    public override void Undo()
    {
        if (this.transform.CompareTag("UnSelected"))
        {
            this.transform.tag = "Selected";
            this.transform.GetComponent<ParticleSystem>().Play();
        }
        else if (this.transform.CompareTag("Selected"))
        {
            this.transform.tag = "UnSelected";
            this.transform.GetComponent<ParticleSystem>().Stop();
        }
    }
}
