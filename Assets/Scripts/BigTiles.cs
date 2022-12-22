using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigTiles : MonoBehaviour
{
    public bool Drop;
    [SerializeField] string RightNo;
    [SerializeField] string Lock;

    [SerializeField] Sprite Wrong, Right;
    [SerializeField] Image Status;


    [SerializeField] string ObjName;
    [SerializeField] bool Chk;


    private void Start()
    {
        Status = transform.GetChild(0).GetChild(1).gameObject.GetComponent<Image>();


        Wrong = Resources.Load<Sprite>("images/wrong");
        Right = Resources.Load<Sprite>("images/right");
        Status.enabled = false;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == RightNo && Chk)
        {
            Debug.Log("Hello");
            Status.sprite = Right;
            Status.enabled = true;
        }
        else if (other.tag == "Block" && Chk)
        {
            Status.sprite = Wrong;
            Status.enabled = true;
        }

        if (other.tag == "Block" && Chk)
        {
            ObjName = other.name;
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Chk = false;

        }

    }



    private void OnTriggerExit(Collider other)
    {
       
        if (other.tag == "Block" && ObjName == other.name)
        {
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Chk = true;
            transform.GetComponent<BoxCollider>().enabled = false;
            transform.GetComponent<BoxCollider>().enabled = true;
            
        }


    }
}
