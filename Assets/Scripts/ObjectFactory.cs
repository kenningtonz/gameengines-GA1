using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectFactory 
{
    public static ObjectFactory Instance()
    {
        if (ObjectFactory.instance == null)
        {
            instance = new ObjectFactory();
        }
        return instance;
    }

    private ObjectFactory()
    {
        Start();
        Initialize();
    }

    private static ObjectFactory instance;
    private GameObject grass, treespruce, treeoak, square_pole, spike, pipe, camera;
    

   // private Command creategrass;

    private void Initialize()
    {
        camera = GameObject.Find("Main Camera");
        grass = Resources.Load("grass") as GameObject;
        treespruce = Resources.Load("treespruce") as GameObject;
        treeoak = Resources.Load("treeoak") as GameObject;
        square_pole = Resources.Load("square_pole") as GameObject;
        spike = Resources.Load("spike") as GameObject;
        pipe = Resources.Load("pipe") as GameObject;

    }
    void Start()
    {
        
    }

    public void createobject(ObjectType type)
    {
       
      // GameObject clonegrass = grass;
        Debug.Log("objectcreate function");
   
        switch (type)
        {
            case ObjectType.Grass:
              //  Debug.Log("grass");
                 Command creategrass = new CreateObject(grass, camera.transform.position);
                creategrass.Execute();
                CommandManager.Instance().addcommand(creategrass);
                break;
            case ObjectType.TreeSpruce:
             
                Command createspurce = new CreateObject(treespruce, camera.transform.position);
                createspurce.Execute();
                CommandManager.Instance().addcommand(createspurce);
                break;
            case ObjectType.TreeOak:
              
                Command createoak = new CreateObject(treeoak, camera.transform.position);
                createoak.Execute();
                CommandManager.Instance().addcommand(createoak);
                break;
            case ObjectType.Spike:
            
                Command createspkie = new CreateObject(spike, camera.transform.position);
                createspkie.Execute();
                CommandManager.Instance().addcommand(createspkie);
                break;
            case ObjectType.Pipe:
            
                Command createpipe = new CreateObject(pipe, camera.transform.position);
                createpipe.Execute();
                CommandManager.Instance().addcommand(createpipe);
                break;
            case ObjectType.SquarePole:
       
                Command createpole = new CreateObject(square_pole, camera.transform.position);
                createpole.Execute();
                CommandManager.Instance().addcommand(createpole);
                break;

        }

    }

}
