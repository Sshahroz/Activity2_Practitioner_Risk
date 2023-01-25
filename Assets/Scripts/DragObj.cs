using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DragObj : MonoBehaviour
{
    [SerializeField] GameObject Pointer;
    public bool IsMoveObj;
    [SerializeField] GameObject MovingObj;

    float SmoothSpeed = 0.125f;

    
   



    private void Awake()
    {
       
        
     
    }


    public void Press()
    {
        IsMoveObj = true;
    }

    public void Relese()
    {
        IsMoveObj = false;
    }



    private void Update()
    {

        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);


        if (Physics.Raycast(ray, out hit))
        {
          
           
            Pointer.transform.position = hit.point;

            //LayerBoaed
            if (hit.transform.gameObject.CompareTag("Move"))
            {
                MovingObj = hit.transform.gameObject;

                Pointer.GetComponent<MeshRenderer>().material.color = Color.green;

                if (IsMoveObj && MovingObj != null)
                {
                  
                    MovingObj.transform.localPosition = new Vector3(2.469f, Pointer.transform.position.y, Pointer.transform.position.z);
                }
                else
                {
                   
                    MovingObj = null;   
                }      
            }
            else
            {
                Pointer.GetComponent<MeshRenderer>().material.color = Color.red;
            }

            


          





        }

    }
}
