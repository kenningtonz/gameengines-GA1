using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGravity : Command
{
    public override void Execute()
    {
        this.transform.GetComponent<Rigidbody>().isKinematic = !this.transform.GetComponent<Rigidbody>().isKinematic;
    }

    public override void Undo()
    {
        this.transform.GetComponent<Rigidbody>().isKinematic = !this.transform.GetComponent<Rigidbody>().isKinematic;
    }
}

