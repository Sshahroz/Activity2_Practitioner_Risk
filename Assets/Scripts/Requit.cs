using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Requit : MonoBehaviour
{
    [SerializeField] Transform ActiveObj;
    [SerializeField] bool ChkCV ;
    [SerializeField] Image FeedBackImg;


    int Npcindex;
    int NpcNextNo;


    [SerializeField] TMPro.TextMeshProUGUI CanditaeName;
    [SerializeField] TMPro.TextMeshProUGUI StatusText;

    [SerializeField] Sprite Right, Wrong;



    public candidates[] candidatesInfo;
    [System.Serializable]
    public struct candidates
    {
        public int CadidateNo;
        public string designation;
    }

    private void Start()
    {
        Wrong = Resources.Load<Sprite>("images/wrong");
        Right = Resources.Load<Sprite>("images/right");

        FeedBackImg.enabled = false;
        NpcNextNo = 0;

        CanditaeName.text = candidatesInfo[0].designation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ChkCV && ActiveObj == null )
        {
           
            

                //other.transform.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = false;
                other.GetComponent<BoxCollider>().enabled = true;
                other.transform.GetComponent<Rigidbody>().isKinematic = false;

                other.transform.position = transform.position;
                other.transform.rotation = transform.rotation;

                StartCoroutine(ExampleCoroutine());

                if (other.transform.position == transform.position)
                {

                    ActiveObj = other.transform;
                    ChkCV = false;
                    int.TryParse(ActiveObj.name, out Npcindex);
                    transform.parent.GetComponent<Animation>().Play();

                }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        

            if (ActiveObj == null )
            { return; }
            if (other.name == ActiveObj.name )
            {

                ActiveObj = null;
                ChkCV = true;

            StatusText.text = "";

            FeedBackImg.enabled = false;

        }
        
    

    }




    void RequitChk()
    {

        if (candidatesInfo[NpcNextNo].CadidateNo == Npcindex)
        {
            StartCoroutine(WaitRight());

            //ActiveObj.transform.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = false;
            ActiveObj.GetComponent<BoxCollider>().enabled = true;
            ActiveObj.transform.GetComponent<Rigidbody>().isKinematic = false;
        }
        else
        {
            StartCoroutine(WaitWrong());
        }
        
  
    }


    IEnumerator  WaitRight()
    {
        yield return new WaitForSeconds(1);
        FeedBackImg.enabled = true;
        FeedBackImg.sprite = Right;
        StatusText.text = "This is the correct candidate";

        ChkCV = true;

        yield return new WaitForSeconds(1);
        Destroy(ActiveObj.gameObject);
        ActiveObj = null;
        StatusText.text = "";
        CanditaeName.text = null;
        FeedBackImg.enabled = false;

        yield return new WaitForSeconds(1);

      
     
            NpcNextNo++;
        if (NpcNextNo == candidatesInfo.Length)
        {
            CanditaeName.text = "you Find All Canditae";
        }
        else
        {
            CanditaeName.text = candidatesInfo[NpcNextNo].designation;
        }
      
        Debug.Log(NpcNextNo);

    }

  



        IEnumerator WaitWrong()
        {
        yield return new WaitForSeconds(1);

        FeedBackImg.enabled = true;
        FeedBackImg.sprite = Wrong;
        StatusText.text = "Incorrect candidate. Try again.";

        //ActiveObj.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = true;
        ActiveObj.GetComponent<BoxCollider>().enabled = true;
        ActiveObj.transform.GetComponent<Rigidbody>().isKinematic = false;



        yield return new WaitForSeconds(1);
       
        

        }







    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
       
        RequitChk();
    }





}
