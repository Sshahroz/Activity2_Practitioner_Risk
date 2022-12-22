using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebXR;



public class go : MonoBehaviour
{
    private WebXRController Controller;
    [SerializeField] GameObject ZoomIn;

    private void Awake()
    {
        Controller = gameObject.GetComponent<WebXRController>();
        ZoomIn.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        if (Controller.GetButtonUp(WebXRController.ButtonTypes.ButtonB))
         {
            Debug.Log("A");
            ZoomIn.SetActive(false);
        }
        if (Controller.GetButtonDown(WebXRController.ButtonTypes.ButtonB))
        {
            Debug.Log("B");
            ZoomIn.SetActive(true);
        }

    }
}
