using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity2_Orginization_Tutriol : MonoBehaviour
{
    [SerializeField] bool Recquid;
    [SerializeField] bool iterviewcall;




    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PickupTheCv")
        {
            transform.parent.GetChild(2).transform.gameObject.SetActive(false);
            transform.parent.GetChild(3).transform.gameObject.SetActive(true);
            transform.parent.GetChild(4).transform.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
        }

        if (other.name == "RequitCandidate")
        {
            if (iterviewcall == true && Recquid == true)
            {
                //tutriol Completed
                transform.parent.GetChild(14).transform.gameObject.SetActive(true);
                other.gameObject.SetActive(false);
            }

            else if (Recquid == true)
            {
                Debug.Log("YAAAAAAA");
                transform.parent.GetChild(6).transform.gameObject.SetActive(false);
                transform.parent.GetChild(4).transform.gameObject.SetActive(true);
                other.gameObject.SetActive(false);
            }
            else if (iterviewcall == true)
            {
                Debug.Log("gggggggg");

                transform.parent.GetChild(13).transform.gameObject.SetActive(false);
                transform.parent.GetChild(3).transform.gameObject.SetActive(true);

                other.gameObject.SetActive(false);
                }
           
        }

        if (other.name == "InterViewCall")
        {

            if (iterviewcall == true && Recquid == true)
            {
                transform.parent.GetChild(14).transform.gameObject.SetActive(true);
                other.gameObject.SetActive(false);
            }

           else if (Recquid == true)
            {
                Debug.Log("YAAAAAAA");
                transform.parent.GetChild(6).transform.gameObject.SetActive(false);
                transform.parent.GetChild(4).transform.gameObject.SetActive(true);

                other.gameObject.SetActive(false);
            }
            else if (iterviewcall == true)
            {
                Debug.Log("gggggggg");

                transform.parent.GetChild(13).transform.gameObject.SetActive(false);
                transform.parent.GetChild(3).transform.gameObject.SetActive(true);

                other.gameObject.SetActive(false);
            }
           
        }







    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "RequitCandidate")
        {
            transform.parent.GetChild(5).transform.gameObject.SetActive(true);
            transform.parent.GetChild(3).transform.gameObject.SetActive(false);
            transform.parent.GetChild(4).transform.gameObject.SetActive(false);



            
        }

        if (other.name == "InterViewCall" && iterviewcall == false )
        {
            transform.parent.GetChild(12).transform.gameObject.SetActive(true);
            transform.parent.GetChild(3).transform.gameObject.SetActive(false);
            transform.parent.GetChild(4).transform.gameObject.SetActive(false);

            transform.GetComponent<BoxCollider>().enabled = false;
            transform.GetComponent<Rigidbody>().isKinematic = true;
        }

    }




    IEnumerator ExampleCoroutine()
    {
        transform.parent.GetChild(10).transform.gameObject.SetActive(false);

        yield return new WaitForSeconds(4);
        iterviewcall = true;


        transform.GetComponent<BoxCollider>().enabled = true;
        transform.GetComponent<Rigidbody>().isKinematic = false;

        transform.parent.GetChild(13).transform.gameObject.SetActive(true);
        
        
        
        
    }


    public void ReqiticCompleted()
    {
        Recquid = true;
    }
    public void InterviewCallCompleted()
    {

        StartCoroutine(ExampleCoroutine());
    }



}
