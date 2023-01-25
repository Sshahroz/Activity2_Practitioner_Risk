using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

using UnityEngine.Events;

public class MenuManager : MonoBehaviour
{

    [Header("player&SpawnPositions")]
    [SerializeField] Transform Player, mainCamera;
    [SerializeField] Transform[] playerPos;
    [SerializeField] GameObject Click;

    [SerializeField] TMPro.TextMeshProUGUI SEnarioText;

    [SerializeField] GameObject ProcessInfo;
    [SerializeField] GameObject[] Hilits;



    [SerializeField] GameObject Drone;
    [SerializeField] Transform DroneTargetPos;
    [SerializeField] bool CallDrone;
    [SerializeField] Vector3 DroneStartPos;




    [SerializeField] PlayableDirector DilogTime;

    //Add Coment
    [Header("Menu")]
    [SerializeField] GameObject MenuActivities;
    [SerializeField] GameObject Menuinstuction;
    [SerializeField] GameObject Menulaptop;
    [SerializeField] GameObject MenuSettings;
    [SerializeField] GameObject MenuExit;

    [Header("Pannel")]
    [SerializeField] GameObject FirstPanel;
    [SerializeField] GameObject TopicPanel;
    [SerializeField] GameObject AgendaPanel;
    [SerializeField] GameObject MenuPanel;

    [SerializeField] GameObject Panel1;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;
    [SerializeField] GameObject Panel4;
    [SerializeField] GameObject Panel5;
    [SerializeField] GameObject Panel6;
    [SerializeField] GameObject Panel7;
    [SerializeField] GameObject Panel8;
    [SerializeField] GameObject Panel9;
    [SerializeField] GameObject Panel10;
    [SerializeField] GameObject Panel11;
    [SerializeField] GameObject Panel12;
    [SerializeField] GameObject Panel13;
    [SerializeField] GameObject Panel14;



    [Header("StartAc")]
    [SerializeField] GameObject StartActivity1_0;
    [SerializeField] GameObject StartActivity1_1;
    [SerializeField] GameObject StartActivity1_2;

    [SerializeField] GameObject StartActivity1_3;
    [SerializeField] GameObject StartActivity1_4;
    [SerializeField] GameObject StartActivity1_5;
    [SerializeField] GameObject StartActivity1_6;
    [SerializeField] GameObject StartActivity1_7;
    [SerializeField] GameObject StartActivity4_0;


    [SerializeField] GameObject Startpi;




    [Header("StartActivityBoard")]
    [SerializeField] GameObject ActivityBoard1_0;
    [SerializeField] GameObject ActivityBoard1_1;
    [SerializeField] GameObject ActivityBoard1_2;
    [SerializeField] GameObject ActivityBoardSummary;
    [SerializeField] GameObject ActivityBoard1_3;




    [Header("CompleteActivity")]
    [SerializeField] GameObject CompleteActivity1_0;
    [SerializeField] GameObject CompleteActivity1_1;
    [SerializeField] GameObject CompleteActivity1_2;
    [SerializeField] GameObject CompleteActivity1_3;
    [SerializeField] GameObject CompleteActivity1_4;
    [SerializeField] GameObject CompleteActivity1_5;
    [SerializeField] GameObject CompleteActivity1_6;
    [SerializeField] GameObject CompleteActivity1_7;
    [SerializeField] GameObject CompleteActivity1_8;
    [SerializeField] GameObject CompleteActivity4_0;

    [Header("CompleteActivityAfter")]
    [SerializeField] GameObject CompleteActivity1_3After;
    [SerializeField] GameObject CompleteActivity1_4After;
    [SerializeField] GameObject CompleteActivity1_5After;
    [SerializeField] GameObject CompleteActivity1_6After;
    [SerializeField] GameObject CompleteActivity1_7After;




    [Header("StartActivityAfter")]

    [SerializeField] GameObject StartActivity1_3After;
    [SerializeField] GameObject StartActivity1_4After;
    [SerializeField] GameObject StartActivity1_5After;
    [SerializeField] GameObject StartActivity1_6After;
    [SerializeField] GameObject StartActivity1_7After;


    [SerializeField] bool FirstTime;



    [SerializeField] int PuzzelIndex;
    [SerializeField] int MaxPuzzelNo;
    [SerializeField] int CompleteMenuNo;




    [SerializeField] GameObject Activity1Questions;
    [SerializeField] GameObject Activity1AnsStatus;
    [SerializeField] string Activity1SelectedAns;
    [SerializeField] bool AnswerTrue;
    [SerializeField] int ActivityStepNo;



    [Header("BeforeRiskResposeBoards")]

    [SerializeField] GameObject BeforeRiskRespos_1;
    [SerializeField] GameObject BeforeRiskRespos_2;
    [SerializeField] GameObject BeforeRiskRespos_3;
    [SerializeField] GameObject BeforeRiskRespos_4;
    [SerializeField] GameObject BeforeRiskRespos_5;


    [Header("AfrerRiskResposeBoards")]

    [SerializeField] GameObject AfterRiskRespos_1;
    [SerializeField] GameObject AfterRiskRespos_2;
    [SerializeField] GameObject AfterRiskRespos_3;
    [SerializeField] GameObject AfterRiskRespos_4;
    [SerializeField] GameObject AfterRiskRespos_5;



    [Header("AfrerPi")]
    [SerializeField] GameObject Pi1;
    [SerializeField] GameObject Pi2;
    [SerializeField] GameObject Pi3;
    [SerializeField] GameObject Pi4;
    [SerializeField] GameObject Pi5;

    [SerializeField] GameObject ComPi;


    [Header("NPC_Audio")]



    [SerializeField] AudioSource NpcAudio;

    [SerializeField] AudioClip[] Clips;

    [SerializeField] Animation Talk;

    private float[] audioSample = new float[AUDIO_SAMPLE_LENGTH];
    private const int AUDIO_SAMPLE_LENGTH = 4096;
    private const int AMPLITUDE_MULTIPLIER = 10;



    [SerializeField] GameObject Activity2_1;
    [SerializeField] GameObject Activity2_2;


    [Header("Questions")]
    [SerializeField] int Question_NO;
    int SelectedANO;

    [SerializeField] TMPro.TextMeshProUGUI Question, Question1;

    [SerializeField] TMPro.TextMeshProUGUI[] Options;
    [SerializeField] TMPro.TextMeshProUGUI AnswerStatus;
    [SerializeField] TMPro.TextMeshProUGUI[] AllAnswers;
    [SerializeField] TMPro.TextMeshProUGUI ButtionText;
    bool ISAnsTrue;

    [SerializeField] GameObject Ac_4Questions;
    [SerializeField] GameObject Ac_4Answers;
    [SerializeField] GameObject Ac4Status;


    [SerializeField] Sprite SelectedAns;
    [SerializeField] Sprite NonSelect;

 


    private void Start()
    {
        DroneStartPos = Drone.transform.position;
        ActivityStepNo = 1;
        FirstTime = true;
        Question_NO = 1;

    }
    public void Menu(int no)
    {
        if (no == 42)
        {
            Click.SetActive(true);
        }
        else
        {
            Click.SetActive(false);
        }




        switch (no)
        {
            case 1:
                FirstPanel.SetActive(false);
                TopicPanel.SetActive(true);
                break;

            case 2:
                TopicPanel.SetActive(false);
                AgendaPanel.SetActive(true);
                FirstPanel.SetActive(false);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;

            case 3:
                AgendaPanel.SetActive(false);
                Panel1.SetActive(true);
                break;

            case 4:
                Panel1.SetActive(false);
                Panel2.SetActive(true);
                break;

            case 5: // Start 1.0
                
                
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[0].transform.position;
                Player.transform.rotation = playerPos[0].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_0.SetActive(true);


                //Place Puzz No

                break;

            case 6: // Active Board 1.0
                StartActivity1_0.SetActive(false);
                ActivityBoard1_0.SetActive(true);



                PuzzelIndex = 0;
                MaxPuzzelNo = 5;
                CompleteMenuNo = 7;

                break;


            case 7: // Complete 1.0
                CompleteActivity1_0.SetActive(true);

                break;

            case 8: // Back To Center Competed 1.0

                CompleteActivity1_0.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(true);

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;


            case 9: // Start 1.1


                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[1].transform.position;
                Player.transform.rotation = playerPos[1].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_1.SetActive(true);



                break;


            case 10: // Active Board 1.1
                StartActivity1_1.SetActive(false);
                ActivityBoard1_1.SetActive(true);


                PuzzelIndex = 0;
                MaxPuzzelNo = 7;
                CompleteMenuNo = 11;



                break;

            case 11: // Complete Activity 1.1
                CompleteActivity1_1.SetActive(true);
                break;

            case 12: // Back To Center Competed 1.1

                CompleteActivity1_1.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(true);
                ProcessInfo.SetActive(true);

                Hilits[0].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;

                FindObjectOfType<Laptop>().Menu(20);

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;


            case 13: // Next calling

                Panel4.SetActive(false);
                Panel5.SetActive(true);

                Hilits[0].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                Hilits[7].transform.GetComponent<TMPro.TextMeshProUGUI>().fontStyle = TMPro.FontStyles.Strikethrough;
                Hilits[2].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;

                break;


            case 14: // Start 1.1


                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[3].transform.position;
                Player.transform.rotation = playerPos[3].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_2.SetActive(true);

               



                break;


            case 15: // Active Board 1.2
                StartActivity1_2.SetActive(false);
                ActivityBoard1_2.SetActive(true);

                PuzzelIndex = 0;
                MaxPuzzelNo = 5;
                CompleteMenuNo = 16;



                break;


            case 16: // Complete Activity 1.2
                CompleteActivity1_2.SetActive(true);
                break;

            case 17: // Back To Center Competed 1.1

                CompleteActivity1_2.SetActive(false);
                Panel5.SetActive(false);

                SenarioText(ActivityStepNo);
                FindObjectOfType<Laptop>().Menu(23);

                Hilits[2].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                Hilits[9].transform.GetComponent<TMPro.TextMeshProUGUI>().fontStyle = TMPro.FontStyles.Strikethrough;
                Hilits[1].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;



                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;


            case 18:
               
                    Panel6.SetActive(true);
                    
               
               
              
                
                break;

            case 19:
                Panel6.SetActive(false);
                Panel7.SetActive(true);
                break;

            case 20: // Start Question
                Panel6.SetActive(false);
                Activity1Questions.SetActive(true);
                Activity1_Questions(ActivityStepNo);


                break;


            case 21: // Options D
                Activity1SelectedAns = "D";
                Activity1_Answer(ActivityStepNo);

                break;

            case 22: // Options A
                Activity1SelectedAns = "A";
                Activity1_Answer(ActivityStepNo);
                break;

            case 23: // Options B
                Activity1SelectedAns = "B";
                Activity1_Answer(ActivityStepNo);
                break;

            case 24: // Options C
                Activity1SelectedAns = "C";
                Activity1_Answer(ActivityStepNo);
                break;

            case 25: // WrongAnswers
                Activity1AnsStatus.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Please try another answer";
                Activity1AnsStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
                AnswerTrue = false;
                Activity1Questions.SetActive(false);
                Activity1AnsStatus.SetActive(true);


                break;

            case 26:
                if (AnswerTrue)
                {
                    Panel8.SetActive(true);
                    Panel8.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "We have planned the risk response. \nPlease update the risk register for scenario "+(ActivityStepNo-1)+".";
                    Panel8.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2."+(ActivityStepNo - 1)+ " Scenario "+ (ActivityStepNo - 1)+ " updating the risk register.";

                    Activity1AnsStatus.SetActive(false);


                    Hilits[1].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                    
                    Hilits[6].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;

                }
                else
                {
                    Activity1Questions.SetActive(true);
                    Activity1AnsStatus.SetActive(false);
                }

                break;

            case 27: // Start Senario Befoure Risk Respose

                BefoureRiskRespose(ActivityStepNo - 1,0,0,0);

                break;


            case 28: // Activate Senario Befoure Risk Respose

                BefoureRiskRespose(0, ActivityStepNo - 1,0,0);

                break;


            case 29: //  Competed 1.1


                BefoureRiskRespose(0,0, ActivityStepNo - 1, 0);


                break;

            case 30: //Back To Center
                BefoureRiskRespose(0, 0, 0, ActivityStepNo - 1);
                Panel8.SetActive(false);
                Panel9.SetActive(true);

                Hilits[6].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                Hilits[3].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;


                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                break;

            case 31: // After Pi


                AfterPi(ActivityStepNo - 1, 0);

                Startpi.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[3].transform.position;
                Player.transform.rotation = playerPos[3].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                break;


            case 32:
                Startpi.SetActive(false);
                AfterPi(0, ActivityStepNo - 1);
                break;

            case 33:
                Panel9.SetActive(false);

                AfterSenario1(ActivityStepNo - 1);


                ComPi.SetActive(false);

                Panel10.SetActive(true);

                Hilits[3].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                Hilits[5].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;



                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                break;


            case 34:    

                Panel10.SetActive(false);
                AfterSenario2(ActivityStepNo - 1);

                Panel11.SetActive(true);


                break;

            case 35:

                Panel11.SetActive(false);
                AfterSenario3(ActivityStepNo - 1);

                Panel12.SetActive(true);

                Hilits[5].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                Hilits[4].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;


                break;


            case 36:

                AfterRiskRespose(ActivityStepNo - 1, 0, 0, 0);

                


              

                break;


            case 37:

                AfterRiskRespose(0, 0, ActivityStepNo - 1, 0);

                break;


            case 38:
                
                AfterRiskRespose(0, ActivityStepNo - 1, 0, 0);

                break;


            case 39:

                ComPi.SetActive(true);
                break;


            case 40:

                AfterRiskRespose(0, 0, ActivityStepNo - 1, 0);

                break;


            case 41: // Back To Center


                if (ActivityStepNo == 6)
                {
                    Panel12.SetActive(false);
                    Panel13.SetActive(true);

                    mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                    Player.transform.position = playerPos[2].transform.position;
                    Player.transform.rotation = playerPos[2].transform.rotation;
                    mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;


                    Hilits[4].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                    Hilits[11].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;


                }
                else
                {
                    AfterRiskRespose(0, 0, 0, ActivityStepNo - 1);

                    mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                    Player.transform.position = playerPos[2].transform.position;
                    Player.transform.rotation = playerPos[2].transform.rotation;
                    mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                    Panel12.SetActive(false);

                    SenarioText(ActivityStepNo);
                    FindObjectOfType<Laptop>().Menu(23);


                    Hilits[4].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
                    Hilits[1].transform.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;



                }


              
                break;

            case 42: // Activity 3

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[10].transform.position;
                Player.transform.rotation = playerPos[10].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                StartActivity4_0.SetActive(true);

                break;


            case 43:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[9].transform.position;
               
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                ActivityBoardSummary.SetActive(true);
                CompleteActivity1_8.SetActive(true);

                break;


            case 44:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                Panel13.SetActive(false);
                Panel14.SetActive(true);
                FindObjectOfType<Laptop>().Menu(4);


                break;




            case 45:// Saying
               
                //Saying.SetActive(true);
                Ac4Status.SetActive(false);
                

                if (ISAnsTrue)
                {
                    Ac_4Answers.SetActive(true);
                    ISAnsTrue = false;
                }
                else
                {
                    Ac_4Answers.SetActive(false);
                    Ac_4Questions.SetActive(true);
                    AllQ(Question_NO, 0);

                }


                if (Question_NO == 3)
                {
                    Question_NO = 1;
                    Ac_4Answers.SetActive(false);
                    Ac_4Questions.SetActive(true);
                    AllQ(Question_NO, 0);
                }

                break;





            case 46: //OptionA
                StartCoroutine(TakingAdvice(1));

                Ac_4Questions.SetActive(false);
                break;
            case 47: //OptionB
                StartCoroutine(TakingAdvice(2));

                Ac_4Questions.SetActive(false);
                break;
            case 48: //OptionC
                StartCoroutine(TakingAdvice(3));

                Ac_4Questions.SetActive(false);
                break;
            case 49: //OptionD
                StartCoroutine(TakingAdvice(4));

                Ac_4Questions.SetActive(false);
                break;


            case 50:
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[11].transform.position;
                Player.transform.rotation = playerPos[11].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;

            case 51:
                StartActivity4_0.SetActive(false);
                PuzzelIndex = 0;
                MaxPuzzelNo = 5;
                CompleteMenuNo = 52;

                break;


            case 52:
                CompleteActivity4_0.SetActive(true);
                break;





            case 77:
                CallDrone = true;
                Drone.GetComponent<Animation>().Play();

                break;

            case 78:
                CallDrone = false;
                Drone.GetComponent<Animation>().Play();

                break;


            case 71: // Select Activity
                MenuActivities.SetActive(true);
                Menulaptop.SetActive(false);
                Menuinstuction.SetActive(false);
                MenuSettings.SetActive(false);
                MenuExit.SetActive(false);
                break;

            case 72:  // Select Laptop
                MenuActivities.SetActive(false);
                Menulaptop.SetActive(true);
                Menuinstuction.SetActive(false);
                MenuSettings.SetActive(false);
                MenuExit.SetActive(false);
                break;

            case 73:  // Select instructions
                MenuActivities.SetActive(false);
                Menulaptop.SetActive(false);
                Menuinstuction.SetActive(true);
                MenuSettings.SetActive(false);
                MenuExit.SetActive(false);
                break;

            case 74: // Select Settings
                MenuActivities.SetActive(false);
                Menulaptop.SetActive(false);
                Menuinstuction.SetActive(false);
                MenuSettings.SetActive(true);
                MenuExit.SetActive(false);
                break;

            case 75: // Select Exit
                MenuActivities.SetActive(false);
                Menulaptop.SetActive(false);
                Menuinstuction.SetActive(false);
                MenuSettings.SetActive(false);
                MenuExit.SetActive(true);
                break;

            case 76:
                    #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
                Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
                    #endif
                    #if (UNITY_EDITOR)
                UnityEditor.EditorApplication.isPlaying = false;
                    #elif (UNITY_STANDALONE)
                    Application.Quit();
                    #elif (UNITY_WEBGL)
                Application.OpenURL("about:blank");
                    #endif
                break;








        }
        Debug.Log("Call");

    }
    IEnumerator TakingAdvice(int No)
    {

        yield return new WaitForSeconds(2);
        Ac4Status.SetActive(true);
        AllQ(Question_NO, No);

    }

    void SenarioText(int No)
    {
        switch (No)
        {
            case 1:
                SEnarioText.text = "For scenario 1 let's start planning a risk response. The response to the risk in this scenario is to ensure the contract stipulates the agency is financially penalised if there are any time delays. Question, what type of risk response does this represent?";

                NpcAudio.clip = Clips[1];

              
                


                break;

            case 2:
                SEnarioText.text = "For scenario 2 let's start planning a risk response. There is a growing concern that the long term recruitment agency to FloorIT may not be able to recruit the team of trainers in time. There is a discussion that the project may be cancelled. Question, what type of risk response does this represent? ";

                NpcAudio.clip = Clips[2];
              


                break;

            case 3:
                SEnarioText.text = "For scenario 3 let's start planning a risk response. It may be advisable to widen the selection process and contacting more recruitment agencies. Question, what type of risk response does this represent? ";

                NpcAudio.clip = Clips[3];
                ;

                break;

            case 4:
                SEnarioText.text = "For scenario 4 let's start planning a risk response. It has been suggested that if the recruitment agency is unable to source enough suitable candidates within a short time frame they should be switched to another agency. Question, what type of risk response does this represent? ";

                NpcAudio.clip = Clips[4];
                

                break;

            case 5:
                SEnarioText.text = "For scenario 5 let's start planning a risk response. It has been suggested that training staff should be selected from FloorIT to ensure there if a full delivery team. Question, what type of risk response does this represent? ";

                NpcAudio.clip = Clips[5];
               

                break;

               


        }
        NpcAudio.Play();
    }




    void BefoureRiskRespose(int No, int Board , int Comp , int AfterCom)
    {
        switch (No)
        {
            case 1:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[4].transform.position;
                Player.transform.rotation = playerPos[4].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_3.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Scenario " + (ActivityStepNo - 1) + " Updating the risk register Fill Colum Before risk Response";
                StartActivity1_3.SetActive(true);

                break;

            case 2:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[5].transform.position;
                Player.transform.rotation = playerPos[5].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_4.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Scenario " + (ActivityStepNo - 1) + " Updating the risk register Fill Colum Before risk Response";
                StartActivity1_4.SetActive(true);




                break;

            case 3:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[6].transform.position;
                Player.transform.rotation = playerPos[6].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_5.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Scenario " + (ActivityStepNo - 1) + " Updating the risk register Fill Colum Before risk Response";
                StartActivity1_5.SetActive(true);


                break;

            case 4:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[7].transform.position;
                Player.transform.rotation = playerPos[7].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_6.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Scenario " + (ActivityStepNo - 1) + " Updating the risk register Fill Colum Before risk Response";
                StartActivity1_6.SetActive(true);

                break;

            case 5:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[8].transform.position;
                Player.transform.rotation = playerPos[8].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                StartActivity1_7.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Scenario " + (ActivityStepNo - 1) + " Updating the risk register Fill Colum Before risk Response";
                StartActivity1_7.SetActive(true);


                break;
        }

        switch (Board)
        {
            case 1:

                BeforeRiskRespos_1.SetActive(true);
                StartActivity1_3.SetActive(false);

                PuzzelIndex = 0;
                MaxPuzzelNo = 7;
                CompleteMenuNo = 29;        

                break;
            case 2:

                BeforeRiskRespos_2.SetActive(true);
                StartActivity1_4.SetActive(false);

                PuzzelIndex = 0;
                MaxPuzzelNo = 2;
                CompleteMenuNo = 29;

                break;
            case 3:

                BeforeRiskRespos_3.SetActive(true);
                StartActivity1_5.SetActive(false);

                PuzzelIndex = 0;
                MaxPuzzelNo = 2;
                CompleteMenuNo = 29;

                break;
            case 4:

                BeforeRiskRespos_4.SetActive(true);
                StartActivity1_6.SetActive(false);

                PuzzelIndex = 0;
                MaxPuzzelNo = 2;
                CompleteMenuNo = 29;

                break;
            case 5:

                BeforeRiskRespos_5.SetActive(true);
                StartActivity1_7.SetActive(false);

                PuzzelIndex = 0;
                MaxPuzzelNo = 2;
                CompleteMenuNo = 29;

                break;
        }

        switch (Comp)
        {
            case 1:
                CompleteActivity1_3.SetActive(true);
                break;

            case 2:
                CompleteActivity1_4.SetActive(true);
                break;

            case 3:
                CompleteActivity1_5.SetActive(true);
                break;

            case 4:
                CompleteActivity1_6.SetActive(true);
                break;

            case 5:
                CompleteActivity1_7.SetActive(true);
                break;
        }

        switch (AfterCom)
        {
            case 1:
                Panel9.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Thank you for updating the risk register. \n\nOk, we have implemented the risk response. \n\nLet’s see what has happened to it? After the plan was implemented the risk reduces to the probability low, and impact high \n\nPlease update the Risk profile summary board.";
                Panel9.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response";

                CompleteActivity1_3.SetActive(false);

                break;
            case 2:
                Panel9.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Thank you for updating the risk register. \n\nOk, we have implemented the risk response. \n\nLet’s see what has happened to it? After the plan is implemented the risk is removed. \n\nPlease update the Risk profile summary board.";
                Panel9.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response";

                CompleteActivity1_4.SetActive(false);

                break;
            case 3:
                Panel9.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Thank you for updating the risk register. \n\nOk, we have implemented the risk response. \n\nLet’s see what has happened to it? After the plan is implemented the risk reduces to: probability as low and impact as medium. \n\nPlease update the Risk profile summary board.";
                Panel9.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response";

                CompleteActivity1_5.SetActive(false);

                break;
            case 4:
                Panel9.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Thank you for updating the risk register. \n\nOk, we have implemented the risk response. \n\nLet’s see what has happened to it? After the plan is implemented the risk reduces to: probability as high and impact as very high. \n\nPlease update the Risk profile summary board.";
                Panel9.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response";

                CompleteActivity1_6.SetActive(false);

                break;
            case 5:
                Panel9.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Thank you for updating the risk register. \n\nOk, we have implemented the risk response. \n\nLet’s see what has happened to it? After the plan is implemented the risk is removed.  \n\nPlease update the Risk profile summary board.";
                Panel9.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response";

                CompleteActivity1_7.SetActive(false);

                break;
        }








    }


    void AfterRiskRespose(int No, int Board, int Comp, int AfterCom)
    {
        switch (No)
        {
            case 1:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[4].transform.position;
                Player.transform.rotation = playerPos[4].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                StartActivity1_3After.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Update the slots with changes only.";
                StartActivity1_3After.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2.1";

                StartActivity1_3After.SetActive(true);


                break;
            case 2:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[5].transform.position;
                Player.transform.rotation = playerPos[5].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                StartActivity1_4After.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Update the slots with changes only.";
                StartActivity1_4After.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2.1";

                StartActivity1_4After.SetActive(true);


                break;
            case 3:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[6].transform.position;
                Player.transform.rotation = playerPos[6].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                StartActivity1_5After.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Update the slots with changes only.";
                StartActivity1_5After.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2.1";

                StartActivity1_5After.SetActive(true);


                break;
            case 4:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[7].transform.position;
                Player.transform.rotation = playerPos[7].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                StartActivity1_6After.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Update the slots with changes only.";
                StartActivity1_6After.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2.1";

                StartActivity1_6After.SetActive(true);


                break;
            case 5:

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[8].transform.position;
                Player.transform.rotation = playerPos[8].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                StartActivity1_7After.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Update the slots with changes only.";
                StartActivity1_7After.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2.1";

                StartActivity1_7After.SetActive(true);


                break;

        }


        switch (Board)
        {
            case 1:
                
                AfterRiskRespos_1.SetActive(true);
                StartActivity1_3After.SetActive(false);


                PuzzelIndex = 0;
                MaxPuzzelNo = 3;
                CompleteMenuNo = 40 ;

                break;

            case 2:

                AfterRiskRespos_2.SetActive(true);
                StartActivity1_4After.SetActive(false);


                PuzzelIndex = 0;
                MaxPuzzelNo = 3;
                CompleteMenuNo = 40;

                break;
            case 3:

                AfterRiskRespos_3.SetActive(true);
                StartActivity1_5After.SetActive(false);


                PuzzelIndex = 0;
                MaxPuzzelNo = 3;
                CompleteMenuNo = 40;

                break;
            case 4:

                AfterRiskRespos_4.SetActive(true);
                StartActivity1_6After.SetActive(false);


                PuzzelIndex = 0;
                MaxPuzzelNo = 3;
                CompleteMenuNo = 40;

                break;

            case 5:

                AfterRiskRespos_5.SetActive(true);
                StartActivity1_7After.SetActive(false);


                PuzzelIndex = 0;
                MaxPuzzelNo = 3;
                CompleteMenuNo = 40;

                break;



        }

        switch (Comp)
        {
            case 1:
                CompleteActivity1_3After.SetActive(true);
                break;
            case 2:
                CompleteActivity1_4After.SetActive(true);
                break;
            case 3:
                CompleteActivity1_5After.SetActive(true);
                break;
            case 4:
                CompleteActivity1_6After.SetActive(true);
                break;
            case 5:
                CompleteActivity1_7After.SetActive(true);
                break;
        }


        switch (AfterCom)
        {
            case 1:
                CompleteActivity1_3After.SetActive(false);
                break;
            case 2:
                CompleteActivity1_4After.SetActive(false);
                break;
            case 3:
                CompleteActivity1_5After.SetActive(false);
                break;
            case 4:
                CompleteActivity1_6After.SetActive(false);

                break;
            case 5:
                CompleteActivity1_7After.SetActive(false);
                break;
        }



    }






    void AfterPi(int No, int Act)
    {
        switch (No)
        {
            case 1:
                Startpi.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Place the second number " + (ActivityStepNo - 1) + " in the new position";
                Startpi.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + ".";

                ActivityBoard1_2.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Hint: \nAfter the plan is implemented the risk reduces to the probability as low and impact high";
                break;

            case 2:
                Startpi.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Place the second number " + (ActivityStepNo - 1) + " in the new position";
                Startpi.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + ".";

                ActivityBoard1_2.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Hint: \nAfter the plan is implemented the risk is removed.";
                break;
            case 3:
                Startpi.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Place the second number " + (ActivityStepNo - 1) + " in the new position";
                Startpi.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + ".";

                ActivityBoard1_2.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Hint: \nAfter the plan is implemented the risk reduces to: probability as low and impact as medium";

                break;
            case 4:
                Startpi.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Place the second number " + (ActivityStepNo - 1) + " in the new position";
                Startpi.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + ".";

                ActivityBoard1_2.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Hint: \nAfter the plan is implemented the risk reduces to: probability as medium and impact as very high";

                break;
            case 5:
                Startpi.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Place the second number " + (ActivityStepNo - 1) + " in the new position";
                Startpi.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + ".";

                ActivityBoard1_2.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Hint: \nAfter the plan is implemented the risk redcues: probability as low and impact as low";

                break;
        }


        switch (Act)
        {
            case 1:
                Pi1.SetActive(true);

                PuzzelIndex = 0;
                MaxPuzzelNo = 1;
                CompleteMenuNo = 39;

                
              
                break;

            case 2:
                Pi2.SetActive(true);

                PuzzelIndex = 0;
                MaxPuzzelNo = 1;
                CompleteMenuNo = 39;

                


                break;

            case 3:
                Pi3.SetActive(true);

                PuzzelIndex = 0;
                MaxPuzzelNo = 1;
                CompleteMenuNo = 39;

              

                break;

            case 4:
                Pi4.SetActive(true);

                PuzzelIndex = 0;
                MaxPuzzelNo = 1;
                CompleteMenuNo = 39;

               

                break;

            case 5:
                Pi5.SetActive(true);

                PuzzelIndex = 0;
                MaxPuzzelNo = 1;
                CompleteMenuNo = 39;

               

                break;
        }


       
    }


    void AfterSenario1(int No)
    {
        

                Panel10.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Question 1) Is this risk still a serious threat? \n\nQuestion 2) Does this risk need to be monitored?";
                Panel10.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response.";

    }

    void AfterSenario2(int No)
    {
        switch (No)
        {

            case 1:

                Panel11.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Question 1) Is this risk still a serious threat? \n\nSolution 1) This risk is below the tolerance line and is not considered to be a serious threat. \n\nQuestion 2) Is this risk active and does it still need to be monitored? \n\nSolution 2) Yes.The risk is active and should be monitored.";
                Panel11.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response.";

                break;
            case 2:

                Panel11.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Question 1) Is this risk still a serious threat? \n\nSolution 1) This risk has been eliminated and therefore is closed. \n\nQuestion 2) Is this risk active and does it still need to be monitored? \n\nSolution 2) No. The risk is no longer active.";
                Panel11.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response.";

                break;
            case 3:

                Panel11.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Question 1) Is this risk still a serious threat? \n\nSolution 1) This risk is below the tolerance line and is not considered to be a serious threat. \n\nQuestion 2) Is this risk active and does it still need to be monitored? \n\nSolution 2) Yes. The risk is active and should be monitored.";
                Panel11.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response.";

                break;
            case 4:

                Panel11.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Question 1) Is this risk still a serious threat? \n\nSolution 1) This risk is still above the tolerance line and whilst the probability has slightly it is still considered to be a serious threat. \n\nQuestion 2) Is this risk active and does it still need to be monitored? \n\nSolution 2) Yes. The risk is active and should be regularly monitored and another risk response should be planned imminently.";
                Panel11.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response.";

                break;
            case 5:

                Panel11.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Question 1) Is this risk still a serious threat? \n\nSolution 1) This risk is below the tolerance line and is not considered to be a serious threat. \n\nQuestion 2) Is this risk active and does it still need to be monitored? \n\nSolution 2) Yes. The risk is active and should be monitored.";
                Panel11.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response.";

                break;
        }
        Panel11.SetActive(true);
    }

    void AfterSenario3(int No)
    {
    
                Panel12.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Ok, so you have updated the Risk summary profile. \nPlease now update the risk register for scenario " + (ActivityStepNo - 1) + ". \nOnly update the changes.";
                Panel12.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Activity 2." + (ActivityStepNo - 1) + " Scenario " + (ActivityStepNo - 1) + " after implementing the response.";

       
    }









    void Activity1_Questions(int No)
    {
        

         

        switch (No)
        {
            case 1:
                Activity1Questions.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "For scenario 1 let's start planning a risk response. The response to the risk in this scenario is to ensure the contract stipulates the agency are financially penalised if there are any time delays. Question, what type of risk response does this represent?";
                break;

            case 2:
                Activity1Questions.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "For scenario 2 let's start planning a risk response. There is a growing concern that the long-term recruitment agency to FloorIT may not be able to recruit the team of trainers in time. There is a discussion that the project may be canceled. Question, what type of risk response does this represent? ";
                break;
            case 3:
                Activity1Questions.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "For scenario 3 let's start planning a risk response. It may be advisable to widen the selection process and contact more recruitment agencies. Question, what type of risk response does this represent? ";
                break;

            case 4:
                Activity1Questions.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "For scenario 4 let's start planning a risk response. It has been suggested that if the recruitment agency is unable to source enough suitable candidates within a short time frame they should be switched to another agency. Question, what type of risk response does this represent? ";
                break;

            case 5:
                Activity1Questions.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "For scenario 5 let's start planning a risk response. It has been suggested that training staff should be selected from FloorIT to ensure there if a full delivery team. Question, what type of risk response does this represent? ";  
                break;
        }
    }


    void Activity1_Answer(int No)
    {
      

        Activity1AnsStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
        Activity1AnsStatus.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Please try another answer";
        AnswerTrue = false;
        switch (No)
        {

            case 1:
                if (Activity1SelectedAns == "D")
                {
                    Activity1AnsStatus.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Answer D). Transfer. \nWith the addition of the stipulation in the contract with the recruitment agency, the project is transferring some of the financial risk to the outsourced agency.";
                    Activity1AnsStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    ActivityStepNo++;
                    AnswerTrue = true;
                }
                break;

            case 2:
                if (Activity1SelectedAns == "A")
                {
                    Activity1AnsStatus.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Answer A). Avoid. \nSometimes doing nothing and cancelling the project is the preferred choice. In doing so the risk is eliminated and therefore avoided.";
                    Activity1AnsStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    ActivityStepNo++;
                    AnswerTrue = true;
                }
                break;

            case 3:
                if (Activity1SelectedAns == "B")
                {
                    Activity1AnsStatus.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Answer B). Reduce. \nIn spreading the contract for the recruitment of trainers to many agencies the likelihood of not hiring enough quality trainers will reduce the impact and probability of the risk.";
                    Activity1AnsStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    ActivityStepNo++;
                    AnswerTrue = true;
                }
                break;

            case 4:
                if (Activity1SelectedAns == "C")
                {
                    Activity1AnsStatus.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Answer C). Prepare contingent plans. \nThis option involves preparing now, but not taking action now. It is a reactive response and one where a contingent plan is prepared if the agency fails to deliver.";
                    Activity1AnsStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    ActivityStepNo++;
                    AnswerTrue = true;
                }
                break;

            case 5:
                if (Activity1SelectedAns == "B")
                {
                    Activity1AnsStatus.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "Answer B). Reduce.\nIn this option, the delivery approach is to source from in-house thereby removing the risk of not having a delivery team in place on time.";
                    Activity1AnsStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    ActivityStepNo++;
                    AnswerTrue = true;
                }
                break;


                


        }
        Activity1Questions.SetActive(false);
        Activity1AnsStatus.SetActive(true);

    }





    public void PuzzelNo()
    {
        PuzzelIndex++;
        if (PuzzelIndex == MaxPuzzelNo)
        {
            Menu(CompleteMenuNo);
            PuzzelIndex = 0;
        }



    }



    public void Signal(int No)
    {
        switch (No)
        {
            case 0:
                DilogTime.Pause();
                break;
        }
    }


    #region Call Drone 

    private void Update()
    {
        if (CallDrone)
        {
            Drone.transform.position = Vector3.Lerp(Drone.transform.position, DroneTargetPos.transform.position, 1f*Time.deltaTime);

        }
        else
        {
            Drone.transform.position = Vector3.Lerp(Drone.transform.position, DroneStartPos, 1f * Time.deltaTime);
        }
        return;

    }



    #endregion
    void AllQ(int QNO, int ANO)
    {
        string QuestionText;
        ISAnsTrue = false;


        AllAnswers[0].color = Color.white;
        AllAnswers[1].color = Color.white;
        AllAnswers[2].color = Color.white;
        AllAnswers[3].color = Color.white;


        AllAnswers[0].transform.parent.gameObject.GetComponent<Image>().sprite = NonSelect;
        AllAnswers[1].transform.parent.gameObject.GetComponent<Image>().sprite = NonSelect;
        AllAnswers[2].transform.parent.gameObject.GetComponent<Image>().sprite = NonSelect;
        AllAnswers[3].transform.parent.gameObject.GetComponent<Image>().sprite = NonSelect;




        switch (QNO)
        {
            case 1:
                QuestionText = "1:</font><indent=1em> FloorIT despite experiencing a fall in revenue are still one of the market leaders. The CEO has reservations about the project moving forward as a failure of trained staff with a new diary system may further dent revenue and lead to reputational damage. The CEO has asked the project manager to investigate this risk. The project manager has recommended closing the project. Is this appropriate, and why or why not?";
                Question.text = QuestionText;
                Question1.text = QuestionText;




              



                Options[0].text = "No because this is not one of the risk responses proscribed within PRINCE2.";
                Options[1].text = "Because the closure of the project is not a valid planned risk response.";
                Options[2].text = "Yes, because the closure of a project is a possibility and therefore a valid planned risk response.";
                Options[3].text = "Yes, because the closure of projects should always occur if there is a serious risk.";

                AllAnswers[0].text = "Incorrect. Closure of a project can be a proportionate response to a valid risk.";
                AllAnswers[1].text = "Incorrect. Closure of a project can be a proportionate response to a valid risk.";
                AllAnswers[2].text = "Correct. Closure of a project is a valid risk response when it is proportionate.";
                AllAnswers[3].text = "Incorrect. Closure of a project may be appropriate, but will not always have to occur when there is a serious risk.";

                AllAnswers[0].color = Color.white;
                AllAnswers[1].color = Color.white;
                AllAnswers[2].color = new Color32(2, 156, 0, 255);
                AllAnswers[2].transform.parent.gameObject.GetComponent<Image>().sprite = SelectedAns;
                AllAnswers[3].color = Color.white;





                switch (ANO)
                {
                    case 1:
                        AnswerStatus.text = "As you advised, we didn’t respond to the risk with a planned closure. It is important that the response to the risk is proportional to the potential impact that the risk might have. The lessons learnt are that In this example, closing the project should have been deemed as a proportionate response to a further major loss in revenue and reputational damage.";

                        //NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q1-OP1");
                        //NpcAudio.Play();


                        ButtionText.text = "Try Again";

                        break;
                    case 2:
                        AnswerStatus.text = "As you advised, we didn’t respond to the risk with a planned closure. It is important that the response to the risk is proportional to the potential impact that the risk might have. The lessons learnt are that In this example, closing the project should have been deemed as a proportionate response to a further major loss in revenue and reputational damage.";

                        //NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q1-OP1");
                        //NpcAudio.Play();

                        ButtionText.text = "Try Again";

                        break;
                    case 3:
                        AnswerStatus.text = "Thankyou for your advice. That’s what Quality assurance has told us also. It’s good that we are all in agreement. Let’s review the reason why.";

                        //NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q1-OP3");
                        //NpcAudio.Play();

                        ButtionText.text = "Solution";

                        Question_NO++;
                        ISAnsTrue = true;
                        break;
                    case 4:
                        AnswerStatus.text = "Thankyou for your advice. Whilst closure is a possibility it is not mandatory for it to always be the planned response to a serious risk. Let’s review the reason why.";

                        //NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q1-OP4");
                        //NpcAudio.Play();

                        ButtionText.text = "Try Again";

                       

                        break;
                }
                break;




            case 2:
                QuestionText = "2:</font><indent=1em> The project manager having assessed the risk of not being able to attract sufficient quality trainers, will have to ensure that the job specification is enhanced for trainers leading to an increase in the daily rate of payment to trainers. This is required in order to attract high quality trainers to ensure the success of the project. The Executive has provided approval of the over spend to be funded from the change budget. Is this appropriate, and why or why not? ";
                Question.text = QuestionText;
                Question1.text = QuestionText;

              


                Options[0].text = "Yes, because this is a change and therefore funding from the change budget is appropriate.";
                Options[1].text = "Yes, because this change is an off-specification and a change and therefore funding from the change budget is appropriate.";
                Options[2].text = "No, because risk should be funded from the project tolerance budget.";
                Options[3].text = "No, because risks should be funded from a risk budget. A risk is a threat that has not occurred and this is different to a change request.";

                AllAnswers[0].text = "Incorrect. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[1].text = "Incorrect. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[2].text = "Incorrect. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[3].text = "Correct. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[0].color = new Color32(2, 156, 0, 255);
                AllAnswers[0].transform.parent.gameObject.GetComponent<Image>().sprite = SelectedAns;
                AllAnswers[1].color = Color.white;
                AllAnswers[2].color = Color.white;
                AllAnswers[3].color = Color.white;



                switch (ANO)
                {
                    case 1:
                        AnswerStatus.text = "Thankyou for the advice. Having consulted quality assurance we have concluded that this is in fact a risk and not a change and therefore it is not appropriate. The lessons learnt are that risks should be funded from the risk budget.";
                      

                      
                        ButtionText.text = "Try Again";

                        break;
                    case 2:
                        AnswerStatus.text = "Thankyou for the advice. Having consulted quality assurance we have concluded that this is in fact a risk and not a change and therefore it is not appropriate. The lessons learnt are that risks should be funded from the risk budget.";

                       

                      

                        ButtionText.text = "Try Again";

                        break;
                    case 3:
                        AnswerStatus.text = "Thankyou for the advice. Having consulted quality assurance we have concluded that this is in fact a risk and not an overspend and therefore it is not appropriate to fund this from the tolerance budget. The lessons learnt are that risks should be funded from the risk budget.";

                       

                        ButtionText.text = "Try Again";

                        break;
                    case 4:
                        AnswerStatus.text = "Thankyou for your advice. That’s what Quality assurance has told us also. It’s good that we are all in agreement. Let’s review the reason why.";

                      

                        Question_NO++;
                        ISAnsTrue = true;

                        ButtionText.text = "Solution";

                        break;
                }
                break;
        }
       

    }





}
