using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    }

    private static ObjectFactory instance;
    public GameObject[] myObjects;
    private Command creategrass;


     void Start()
    {
        // objectManager = ObjectManager.Instance();
        myObjects[0] = (GameObject)Resources.Load("grass", typeof(GameObject));
        // myObjects[1] = treespruce;
        // myObjects[2] = treeoak;
        //  myObjects[3] = squarepole;
        //   myObjects[4] = spike;
        //   myObjects[5] = pipe;
        creategrass = myObjects[0].AddComponent<CreateObject>();
    }

    public  void createobject(ObjectType type)
    {
        Debug.Log("objectcreate function");
        switch (type)
        {
            case ObjectType.Grass:
                Debug.Log("grass");

                MonoBehaviour.Instantiate(myObjects[0]);
                //Command creategrass = new CreateObject(myObjects[0], new Vector3(0, 0, 0), Quaternion.identity);
                // creategrass.Execute();
                //tempobject = MonoBehaviour.Instantiate(myObjects[0]);
                // CommandManager.Instance().addcommand(creategrass);
                break;

        }


    }

    public void spawnGrass()
    {
       // Instantiate(myObjects[0], new Vector3(0, 0, 0), Quaternion.identity);
        //Debug.Log("grass");
    }

}
