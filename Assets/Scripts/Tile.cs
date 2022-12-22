using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
  
    public string RightNo;

    int WrongNo;
    int ISNO;

    [SerializeField] Vector3 transformval;
    [SerializeField] Vector3 Rotation;

    [SerializeField] Image Status;

    [SerializeField] Sprite Wrong, Right;

    [SerializeField] GameObject UnHideObj;
    [SerializeField] GameObject HideObj;


    [SerializeField] bool Hide;



    private void Start()
    {
        transformval = transform.position;


        Status = transform.GetChild(0).gameObject.GetComponent<Image>();
        Status.enabled = false;


        Wrong = Resources.Load<Sprite>("images/wrong");
        Right = Resources.Load<Sprite>("images/right");




    }
    private void OnTriggerEnter(Collider other)
    {

        //If Word
        if (other.name == RightNo)
        {
            transform.GetComponent<BoxCollider>().enabled = false;
            transform.GetComponent<Rigidbody>().Equals(false);
            transform.GetComponent<Rigidbody>().useGravity = false;
            transform.GetComponent<Rigidbody>().isKinematic = true;


          



            //transform.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = false;
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
            other.transform.GetComponent<MeshRenderer>().enabled = false;
            other.transform.GetComponent<BoxCollider>().enabled = false;
            FindObjectOfType<MenuManager>().PuzzelNo();
            Status.enabled = true;
            Status.sprite = Right;

            if (Hide)
            {

                StartCoroutine(ExampleCoroutine());

            }


        }
        else if (other.tag == "Block")
        {
            transform.GetComponent<BoxCollider>().enabled = false;
            transform.GetComponent<Rigidbody>().Equals(false);
            transform.GetComponent<Rigidbody>().useGravity = false;
            transform.GetComponent<Rigidbody>().isKinematic = true;
            //transform.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = false;
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
            Status.enabled = true;
            Status.sprite = Wrong;
            ResetPos();
        }
        if (other.name == "Out")
        {
            transform.position = transformval;
        }

        //IF Deffination     
    }
    public void ResetPos()
    {
        StartCoroutine(Reset());
    }
    IEnumerator Reset()
    {



        yield return new WaitForSeconds(1);
        transform.position = transformval;
        Status.enabled = false;
        transform.GetComponent<BoxCollider>().enabled = true;
        transform.GetComponent<Rigidbody>().Equals(true);
        transform.GetComponent<Rigidbody>().useGravity = true;
        transform.GetComponent<Rigidbody>().isKinematic = false;
        //transform.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = true;


    }

  

    IEnumerator ExampleCoroutine()
    {
       
        yield return new WaitForSeconds(2);
        UnHideObj.SetActive(true);
        transform.gameObject.SetActive(false);
        if (HideObj != null)
        {
            HideObj.SetActive(false);
        }


    }


}
