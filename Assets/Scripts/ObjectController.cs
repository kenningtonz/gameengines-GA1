using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    
    public GameObject gravitytoggle, unselectbutton, deletebutton, resetrotationbutton;

    private Toggle m_gravitytoggle;
    private Button m_unselectbutton, m_deletebutton, m_resetrotationbutton;


    void Start()
    {
        unselectbutton = GameObject.Find("UnselectAll");
        deletebutton = GameObject.Find("Delete");
        resetrotationbutton = GameObject.Find("ResetRotation");
        gravitytoggle = GameObject.Find("Gravity");


        m_gravitytoggle = gravitytoggle.GetComponent<Toggle>();
        m_gravitytoggle.onValueChanged.AddListener(delegate
        {
            GravityToggleChanged();
        });

        m_deletebutton = deletebutton.GetComponent<Button>();
        m_deletebutton.onClick.AddListener(DeleteOnClick);

        m_unselectbutton = unselectbutton.GetComponent<Button>();
        m_unselectbutton.onClick.AddListener(UnselectOnClick);

        m_resetrotationbutton = resetrotationbutton.GetComponent<Button>();
        m_resetrotationbutton.onClick.AddListener(ResetOnClick);

    }


    void DeleteOnClick()
    {
        if (gameObject.tag == "Selected")
        {
            Command delete = new DeleteObject(gameObject);
            delete.Execute();
            CommandManager.Instance().addcommand(delete);
        }
    }

    void UnselectOnClick()
    {
        Command unselect = new UnselectAll(gameObject);

        unselect.Execute();
        CommandManager.Instance().addcommand(unselect);
    }

    void ResetOnClick()
    {
         if (gameObject.tag == "Selected")
        {
            Command resetrotate = new ResetRotation(gameObject);
            resetrotate.Execute();
            CommandManager.Instance().addcommand(resetrotate);
        }
    }

    void GravityToggleChanged()
    {
        Command gravity = new ToggleGravity(gameObject);
        gravity.Execute();
        CommandManager.Instance().addcommand(gravity);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Selected")
        {

            //move right
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Command move = new MoveObject(gameObject, new Vector3(1, 0, 0));
         
                move.Execute();
                CommandManager.Instance().addcommand(move);

            }


            //move left
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Command move = new MoveObject(gameObject, new Vector3(-1, 0, 0));

                move.Execute();
                CommandManager.Instance().addcommand(move);

            }
            //move backwards
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Command move = new MoveObject(gameObject, new Vector3(0, 0, -1));
                move.Execute();
                CommandManager.Instance().addcommand(move);

            }
            //move forwards
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
               Command move = new MoveObject(gameObject, new Vector3(0, 0, 1));
                move.Execute();
                CommandManager.Instance().addcommand(move);

            }

            //move up
            if (Input.GetKeyDown(KeyCode.PageUp))
            {
                Command move = new MoveObject(gameObject, new Vector3(0, 1, 0));
                move.Execute();
                CommandManager.Instance().addcommand(move);

            }
            //move down
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                 Command move = new MoveObject(gameObject, new Vector3(0, -1, 0));
       
                move.Execute();
                CommandManager.Instance().addcommand(move);
            }

            ////rotate
            //rotate left
            if (Input.GetKeyDown(KeyCode.C))
            {
                Command rotate = new RotateObject(gameObject, new Vector3(0, -90, 0));
             
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);

            }

            //rotate right
            if (Input.GetKeyDown(KeyCode.V))
            {
                Command rotate = new RotateObject(gameObject, new Vector3(0, 90, 0));
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);

            }

            //rotate up
            if (Input.GetKeyDown(KeyCode.B))
            {
                Command rotate = new RotateObject(gameObject, new Vector3(-90, 0, 0));
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);

            }

            //rotate down
            if (Input.GetKeyDown(KeyCode.N))
            {
                Command rotate = new RotateObject(gameObject, new Vector3(90, 0, 0));
                rotate.Execute();
                CommandManager.Instance().addcommand(rotate);

            }
        }

    }
}

