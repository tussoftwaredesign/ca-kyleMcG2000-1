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

        if (obj.gameObject.tag == "Pumpkins")
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




//&& gameObject.name == "coffinAttachRed1" || obj.gameObject.name == "JackPink" && gameObject.name == "coffinAttachPink2"
 //          || obj.gameObject.name == "jackBlue" && gameObject.name == "coffinAttachBlue3" || obj.gameObject.name == "JackGreen" && gameObject.name == "coffinAttachGreen4"
  //         || obj.gameObject.name == "JackYellow" && gameObject.name == "coffinAttachYellow5" || obj.gameObject.name == "JackOrange" && gameObject.name == "coffinAttachOrange6"