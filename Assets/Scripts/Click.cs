using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Keyyy")
        {
            transform.parent.GetComponent<DragObj>().Press();



        }

    }

    private void OnTriggerExit(Collider other)
    {
       
        if (other.name == "Keyyy")
        {
            transform.parent.GetComponent<DragObj>().Relese();



        }


    }


}
