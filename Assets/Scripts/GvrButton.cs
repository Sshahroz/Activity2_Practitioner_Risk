using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GvrButton : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;



    public int MenuNo;

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer > totalTime)
        {
            //GVRClick.Invoke();
            FindObjectOfType<MenuManager>().Menu(MenuNo);
            Debug.Log("OK");
            //Debug.Log(MenuNo);
            Debug.Log(MenuNo);


        }
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }
    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }




    // Start is called before the first frame update
    void Start()
    {
        
        // Update is called once per frame
    }
    }
