using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptop : MonoBehaviour
{
    [SerializeField] GameObject Desktop;
    [SerializeField] GameObject EmailNotiFication;
    [SerializeField] GameObject EmailPanel;
    [SerializeField] GameObject VideoCallPanel;
    [SerializeField] GameObject FilePanel;
    [SerializeField] GameObject BoardsCamPanel;
    [SerializeField] GameObject PopupImage;



    [SerializeField] GameObject Notification;
    [SerializeField] GameObject[] Email;

    [SerializeField] GameObject EmailOk1;
    [SerializeField] GameObject EmailOk2;
    [SerializeField] GameObject EmailOk3;
    [SerializeField] GameObject EmailOk4;

   
    [SerializeField] GameObject[] cams;



    [SerializeField] GameObject emailZoomIn;
    [SerializeField] GameObject emailZoomOut;
     

    [SerializeField] Sprite ZoominIcon, ZoomOutIcon;
    [SerializeField] GameObject Ziimicon;
    [SerializeField] bool Zoomed = true;


    public void Menu(int No)
    {
        switch (No)
        {
            case 0: // OpenEmail
                Desktop.SetActive(false);
                EmailPanel.SetActive(true);
                break;
            case 1: // CloseEmail
                Desktop.SetActive(true);
                EmailPanel.SetActive(false);
                break;
            case 2: //OPenCam
                Desktop.SetActive(false);
                BoardsCamPanel.SetActive(true);
                break;
            case 3: //CloseCam
                Desktop.SetActive(true);
                BoardsCamPanel.SetActive(false);
                break;
            case 4: //Notification
                Notification.SetActive(true);
                Email[0].SetActive(false);
                Email[1].SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(3).gameObject.SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                break;
            case 5: //Notification
                Notification.SetActive(true);
                Email[0].SetActive(false);
                Email[1].SetActive(true);
                break;
            case 6: //PopUpimage
                PopupImage.SetActive(true);
                Desktop.SetActive(false);
                break;
            case 7: //Close_PopUpimage
                PopupImage.SetActive(false);
                Desktop.SetActive(true);
                break;
            case 8: //EmailRepley
               
                FindObjectOfType<MenuManager>().Menu(6);
                
                Notification.SetActive(false);
                EmailOk1.SetActive(false);
                break;
            case 9:
                if (Zoomed)
                {
                    emailZoomOut.transform.localScale = new Vector3(2, 2, 2);
                    Zoomed = false;
                    Ziimicon.GetComponent<Image>().sprite = ZoomOutIcon;
                }
                else
                {
                    emailZoomOut.transform.localScale = new Vector3(1, 1, 1);
                    Zoomed = true;
                    Ziimicon.GetComponent<Image>().sprite = ZoominIcon;
                }
                
                break;
            case 10:
                emailZoomIn.SetActive(false);
                emailZoomOut.SetActive(true);
                break;

            case 11:
                EmailPanel.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                EmailPanel.transform.GetChild(0).GetChild(2).gameObject.SetActive(false);

                break;
            case 12:
                Notification.SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(4).gameObject.SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);

                break;

            case 13:
                EmailPanel.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                EmailPanel.transform.GetChild(0).GetChild(2).gameObject.SetActive(false);
                break;


            case 14:
                
                FindObjectOfType<MenuManager>().Menu(79);
                
                Notification.SetActive(false);
                EmailOk2.SetActive(false);
                break;


            case 15:
                Notification.SetActive(true);
                
               
                 
                EmailPanel.transform.GetChild(0).GetChild(5).gameObject.SetActive(true);
                EmailPanel.transform.GetChild(0).GetChild(2).gameObject.SetActive(true);

                EmailPanel.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                EmailPanel.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                break;


            case 16:
                EmailPanel.transform.GetChild(0).GetChild(2).gameObject.SetActive(true);

                EmailPanel.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                EmailPanel.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                break;

            case 17:
               
                FindObjectOfType<MenuManager>().Menu(81);
                
                Notification.SetActive(false);
                EmailOk3.SetActive(false);
                break;

            case 18: // Vertual Drone On
                emailZoomOut.transform.localScale = new Vector3(1, 1, 1);
                Zoomed = true;
                Ziimicon.GetComponent<Image>().sprite = ZoominIcon;
                Ziimicon.SetActive(false);


                break;
            case 19: // Vertual Drone Off
                Ziimicon.SetActive(true);
                break;



            case 20: // Dial Video Call
                Desktop.SetActive(false);
                VideoCallPanel.SetActive(true);
                break;


            case 21: // Diling call
                VideoCallPanel.transform.GetChild(1).gameObject.SetActive(false);
                VideoCallPanel.transform.GetChild(0).gameObject.SetActive(true);
                break;


            case 22:

                VideoCallPanel.transform.GetChild(0).GetChild(1).GetChild(4).gameObject.SetActive(false);
                FindObjectOfType<MenuManager>().Menu(13);

                break;



            case 23: // Senario1
                VideoCallPanel.transform.GetChild(1).gameObject.SetActive(false);
                VideoCallPanel.transform.GetChild(0).gameObject.SetActive(true);

                VideoCallPanel.transform.GetChild(0).GetChild(1).GetChild(5).gameObject.SetActive(true);
                VideoCallPanel.transform.GetChild(0).GetChild(1).GetChild(4).gameObject.SetActive(false);

                VideoCallPanel.transform.GetChild(0).GetChild(1).GetChild(7).gameObject.SetActive(false);
                VideoCallPanel.transform.GetChild(0).GetChild(1).GetChild(3).gameObject.SetActive(true);



                //VideoCallPanel.transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<TMPro.TextMeshProUGUI>().text = "For scenario 1 let's start planning a risk response. The response to the risk in this scenario is to ensure the contract stipulates the agency are financially penalised if there are any time delays. Question, what type of risk response does this represent?";

                break;


            case 24:
                VideoCallPanel.transform.GetChild(0).GetChild(1).GetChild(5).gameObject.SetActive(false);
                FindObjectOfType<MenuManager>().Menu(18);

                break;









            case 30:

                 for (int i = 0; i < cams.Length-1; i++)
                {
                    cams[i].SetActive(false);
                }
                cams[0].SetActive(true);

                break;

            case 31:

                for (int i = 0; i < cams.Length - 1; i++)
                {
                    cams[i].SetActive(false);
                }
                cams[1].SetActive(true);

                break;

            case 32:

                for (int i = 0; i < cams.Length - 1; i++)
                {
                    cams[i].SetActive(false);
                }
                cams[2].SetActive(true);

                break;

            case 33:

                for (int i = 0; i < cams.Length - 1; i++)
                {
                    cams[i].SetActive(false);
                }
                cams[3].SetActive(true);

                break;
            case 34:

                for (int i = 0; i < cams.Length - 1; i++)
                {
                    cams[i].SetActive(false);
                }
                cams[4].SetActive(true);

                break;
          







        }
    }
    




}
