using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualLaptop : MonoBehaviour
{
    [SerializeField] GameObject OPenVirtualLaptop;
    [SerializeField] Vector3 StartPos;
    [SerializeField] Vector3 StartRot;

    [SerializeField] Vector3 MyStartPos;


    private void Start()
    {
        StartPos = OPenVirtualLaptop.transform.position;
        MyStartPos = transform.position;



     

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Drone" && transform.position != MyStartPos)
        {
            Debug.Log("DroneIn");
            OPenVirtualLaptop.transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            OPenVirtualLaptop.transform.rotation = transform.rotation;
            OPenVirtualLaptop.transform.localScale = new Vector3(2, 2, 2);
            other.transform.GetChild(0).GetChild(5).GetChild(1).gameObject.SetActive(true);

            FindObjectOfType<Laptop>().Menu(18);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Drone")
        {
            Debug.Log("Droneout");
            OPenVirtualLaptop.transform.position = StartPos;
            OPenVirtualLaptop.transform.rotation = OPenVirtualLaptop.transform.parent.GetChild(0).transform.rotation;
            OPenVirtualLaptop.transform.localScale = new Vector3(1, 1, 1);
            other.transform.GetChild(0).GetChild(5).GetChild(1).gameObject.SetActive(false);
            FindObjectOfType<Laptop>().Menu(19);
        }
    }

    
}
