using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControll : MonoBehaviour
{
    [SerializeField] int No;




    private void Start()
    {
        transform.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Touch")
        {
            FindObjectOfType<Laptop>().Menu(No);
        }
    }
}
