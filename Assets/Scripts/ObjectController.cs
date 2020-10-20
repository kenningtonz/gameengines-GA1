using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    private Command move, resetrotate, delete, unselect, rotate, gravity;
    public GameObject gameManager;
   // public Button 

    public float speed = 10.0f;

    void Start()
    {

        resetrotate = gameObject.AddComponent<ResetRotation>();
        move = gameObject.AddComponent<MoveObject>();
        delete = gameObject.AddComponent<DeleteObject>();
        unselect = gameObject.AddComponent<UnselectAll>();
        rotate = gameObject.AddComponent<RotateObject>();
        gravity = gameObject.AddComponent<ToggleGravity>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (gameManager.GetComponent<spawnButton>().gravity == true)
        //{
        //    Debug.Log("gravitytreu");
        //    gravity.Execute();

        //}
        //if (gameManager.GetComponent<spawnButton>().gravity == false)
        //{
        //    Debug.Log("gravityfalse");
        //    gravity.Execute();

        //}

        if (Input.GetKey(KeyCode.K))
        {
            // Debug.Log("unselect");
            unselect.Execute();
            CommandManager.Instance().addcommand(unselect);
        }

        if (this.tag == "Selected")
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                delete.Execute();
                CommandManager.Instance().addcommand(delete);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                resetrotate.Execute();
                CommandManager.Instance().addcommand(resetrotate);
            }


            //move right
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                // Command move = new MoveObject(gameObject, new Vector3(speed * Time.deltaTime, 0, 0));
                move.GetComponent<MoveObject>().m_direction = new Vector3(1, 0, 0);
                move.Execute();
                CommandManager.Instance().addcommand(move);

            }


            //move left
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                //  Command move = new MoveObject(gameObject, new Vector3(-speed * Time.deltaTime, 0, 0));
                move.GetComponent<MoveObject>().m_direction = new Vector3(-1, 0, 0);
              move.Execute();
                CommandManager.Instance().addcommand(move);

            }
            //move backwards
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                //  Command move = new MoveObject(gameObject, new Vector3(0, 0, -speed * Time.deltaTime));
                move.GetComponent<MoveObject>().m_direction = new Vector3(0, 0, -1);
              move.Execute();
                CommandManager.Instance().addcommand(move);

            }
            //move forwards
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                // Command move = new MoveObject(gameObject, new Vector3(0, 0, speed * Time.deltaTime));
                move.GetComponent<MoveObject>().m_direction = new Vector3(0, 0, 1);
              move.Execute();
                CommandManager.Instance().addcommand(move);

            }

            //move up
            if (Input.GetKeyDown(KeyCode.PageUp))
            {
                //Command move = new MoveObject(gameObject, new Vector3(0, speed * Time.deltaTime, 0));
                move.GetComponent<MoveObject>().m_direction = new Vector3(0, 1, 0);
              move.Execute();
                CommandManager.Instance().addcommand(move);

            }
            //move down
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                // Command move = new MoveObject();
                move.GetComponent<MoveObject>().m_direction = new Vector3(0, -1, 0);
              move.Execute();
                CommandManager.Instance().addcommand(move);
            }

            ////rotate
            //rotate left
            if (Input.GetKeyDown(KeyCode.C))
            {
                rotate.GetComponent<RotateObject>().m_direction = new Vector3(0, -45, 0);
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);

            }

            //rotate right
            if (Input.GetKeyDown(KeyCode.V))
            {
                rotate.GetComponent<RotateObject>().m_direction = new Vector3(0, 45, 0);
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);
            
            }

            //rotate up
            if (Input.GetKeyDown(KeyCode.B))
            {
                rotate.GetComponent<RotateObject>().m_direction = new Vector3(-45, 0, 0);
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);
              
            }

            //rotate down
            if (Input.GetKeyDown(KeyCode.N))
            {
                rotate.GetComponent<RotateObject>().m_direction = new Vector3(45, 0, 0);
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);
            
            }
        }

    
    }
}
