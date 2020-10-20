using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : Command
{
  private Quaternion oldrotation;


    public override void Execute()
    {
        oldrotation = this.transform.rotation;
        this.transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    public override void Undo()
    {
        this.transform.rotation = oldrotation;
    }


}
