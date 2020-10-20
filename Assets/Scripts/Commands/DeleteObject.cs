using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : Command
{
    //private GameObject m_Object;
    //private Vector3 m_position;
    //private Quaternion m_rotation;
    private bool gravity;

    //public DeleteObject(GameObject Object, Vector3 position, Quaternion rotation)
    //{
    //    m_Object = Object;
    //    m_position = position;
    //    m_rotation = rotation;
    //}

    public override void Execute()
    {
        gravity = GetComponent<Rigidbody>().useGravity;

        this.GetComponent<Renderer>().enabled = false;
        this.GetComponent<Collider>().enabled = false;
        this.GetComponent<Rigidbody>().useGravity = false;
        this.GetComponent<ParticleSystem>().Stop();
    }

    public override void Undo()
    {
        this.GetComponent<Renderer>().enabled = true;
        this.GetComponent<Collider>().enabled = true;
        this.GetComponent<ParticleSystem>().Play();
        this.GetComponent<Rigidbody>().useGravity = gravity;

    }



}
