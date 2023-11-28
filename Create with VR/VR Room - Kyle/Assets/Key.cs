using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;






public class Key : MonoBehaviour
{

    public GameObject key;

    public GameObject Window;
    


    void Start()
    {
        Window.SetActive(true);
        key.SetActive(true);
    }

    // Update is called once per frame
   public void OnTriggerEnter(Collider obj)
   {
    if(obj.gameObject.tag == "Window")
    {
        Window.SetActive(false);
        key.SetActive(false);
    }
   }
}
