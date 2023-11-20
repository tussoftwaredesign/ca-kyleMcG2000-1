using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketValidater : MonoBehaviour
{
    public GameObject SocketAttach;
    // Start is called before the first frame update
    void Start()
    {
        SocketAttach.SetActive(false);
    }




    public void OnTriggerEnter(Collider obj)
    {

        if (obj.gameObject.name == "coffinRed" && gameObject.name == "coffinAttachRed1" || obj.gameObject.name == "coffinPink" && gameObject.name == "coffinAttachPink2"
           || obj.gameObject.name == "coffinBlue" && gameObject.name == "coffinAttachBlue3" || obj.gameObject.name == "coffinGreen" && gameObject.name == "coffinAttachGreen4"
           || obj.gameObject.name == "coffinYellow" && gameObject.name == "coffinAttachYellow5" || obj.gameObject.name == "coffinOrange" && gameObject.name == "coffinAttachOrange6")
        {
            SocketAttach.SetActive(true);

            Debug.Log("correct");

        }
        else
        {
            Debug.Log("Wrong Obj");

        }
    }

    public void OnTriggerExit(Collider obj)
    {
        SocketAttach.SetActive(false);
    }
}
