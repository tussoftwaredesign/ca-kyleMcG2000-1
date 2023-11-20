using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateDestroy : MonoBehaviour
{
    public GameObject Gate;

    public GameObject coffinAttach1;

    public GameObject coffinAttach2;

    public GameObject coffinAttach3;

    public GameObject coffinAttach4;

    public GameObject coffinAttach5;

    public GameObject coffinAttach6;
    // Start is called before the first frame update
    void Start()
    {
        Gate.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (coffinAttach1.activeSelf && coffinAttach2.activeSelf && coffinAttach3.activeSelf && coffinAttach4.activeSelf && coffinAttach5.activeSelf && coffinAttach6.activeSelf)
        {
            StartCoroutine(mainGateCoolDown(1f));
            Debug.Log("Attach active ");
        }
        else
        {
            Gate.SetActive(true);
        }
    }

    IEnumerator mainGateCoolDown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Gate.SetActive(false);
    }
}
