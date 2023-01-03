using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Events;

public class MenuManager : MonoBehaviour
{

    [Header("player&SpawnPositions")]
    [SerializeField] Transform Player, mainCamera;
    [SerializeField] GameObject DragTile;
    [SerializeField] Transform[] playerPos;



    //Add Coment

    [Header("Activity 2 Atributes")]

    [SerializeField] GameObject SelectCoure;
    [SerializeField] GameObject Arrow;
    [SerializeField] GameObject First;


    [Header("Activity 2 Menu Atributes")]

    bool AreadyAsked;
    [SerializeField] GameObject Highlite;







    [Header("Activity 1 Atributes")]

    [SerializeField] GameObject Screen1Panel;
    [SerializeField] GameObject Screen2Panel;
    [SerializeField] GameObject Screen3Panel;
    [SerializeField] GameObject Screen4Panel;
    [SerializeField] GameObject Screen5Panel;
    [SerializeField] GameObject Screen6panel;
    [SerializeField] GameObject Screen7panel;
    [SerializeField] GameObject Screen8panel;
    [SerializeField] GameObject Screen9panel;
    [SerializeField] GameObject Screen10panel;




    [SerializeField] GameObject Rist2Start;

    [SerializeField] GameObject CallArrow;
    [SerializeField] GameObject StartCalling;
    [SerializeField] GameObject DailCall;
    [SerializeField] GameObject Arrwo2;
    [SerializeField] GameObject EndRegis;
    [SerializeField] TMPro.TextMeshProUGUI VideoCallText;
    [SerializeField] GameObject Screensaver;



    [Header("Questions")]
    [SerializeField] GameObject QuestionPanel;
    [SerializeField] TMPro.TextMeshProUGUI QuestionText;
    [SerializeField] GameObject QuestionStatus;
    [SerializeField] string SelectedAns;
    [SerializeField] TMPro.TextMeshProUGUI StatusText;
    [SerializeField] int QuestionNo;
    [SerializeField] bool CheckAns;

    [SerializeField] GameObject CompleteDes;
    [SerializeField] GameObject CompletePi1;
    [SerializeField] GameObject CompletePi2;
    [SerializeField] GameObject Risk1;
    [SerializeField] GameObject Risk2;
    [SerializeField] Transform[] RiskB1pos;


    [Header("Boards")]
    [SerializeField] GameObject[] Pi1boards;
    [SerializeField] GameObject[] Pi2boards;
    [SerializeField] GameObject[] Reqister1boards;
    [SerializeField] GameObject[] Reqister2boards;
     

    [Header("PuzzelNo")]
    int PuzzelMaxNo;
    [SerializeField] int PuzzelIndex;
    int MenuNo;



    int Question_NO;
    int SelectedANO;
    [SerializeField] GameObject QuestionsIstructionPanel;
    [SerializeField] GameObject Questions;
    [SerializeField] GameObject RightAnswer;
    [SerializeField] GameObject Answers;

    [SerializeField] TMPro.TextMeshProUGUI Question, Question1;

    [SerializeField] TMPro.TextMeshProUGUI[] Options;
    [SerializeField] TMPro.TextMeshProUGUI AnswerStatus;
    [SerializeField] TMPro.TextMeshProUGUI[] AllAnswers;
    [SerializeField] TMPro.TextMeshProUGUI ButtionText;
    bool ISAnsTrue;


    [SerializeField] Sprite SpriteSelectedAns;
    [SerializeField] Sprite NonSelect;

    

    bool AskQuestion;



    [Header("NPC_Audio")]
 


    [SerializeField] AudioSource NpcAudio;

    [SerializeField] AudioClip[] Clips;

    [SerializeField] Animation Talk;

    private float[] audioSample = new float[AUDIO_SAMPLE_LENGTH];
    private const int AUDIO_SAMPLE_LENGTH = 4096;
    private const int AMPLITUDE_MULTIPLIER = 10;

    






    private void Start()
    {
        QuestionNo = 1;
        Question_NO =1;
    }
    public void Menu(int no)
    {
        if (no == 17)
        {
            DragTile.SetActive(true);
        }
        else
        {
            DragTile.SetActive(false);  
        }


        switch (no)
        {
            #region First Panel

            case 16: //First
                First.SetActive(false);
                SelectCoure.SetActive(true);

                break;

            #endregion

            #region Menu Selection

            case 2:// Select Activity 1         
                

               
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
               
                break;

            case 17: // Select Activity 2

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[5].transform.position;
                Player.transform.rotation = playerPos[5].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;

            #endregion
            case 3:
                Screen1Panel.SetActive(false);
                Screen2Panel.SetActive(true);
                break;

            case 4:
                Screen1Panel.SetActive(false);
                Screen2Panel.SetActive(false);
                Screen3Panel.SetActive(true);
                break;

            case 5:
                Screen1Panel.SetActive(false);
                Screen2Panel.SetActive(false);
                Screen3Panel.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[1].transform.position;
                Player.transform.rotation = playerPos[1].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                Reqister1boards[0].SetActive(true);

                MenuNo = 22;
                PuzzelMaxNo = 7;

                break;

            case 6: // You completed Description
                Arrow.SetActive(true);
                Screen3Panel.SetActive(false);
                Screen4Panel.SetActive(true);
                CompleteDes.SetActive(false);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                DailCall.SetActive(true);

                Highlite.transform.GetChild(0).GetComponent<Animation>().Stop();
                Highlite.transform.GetChild(0).GetComponent<Image>().color = Color.white;
                Highlite.transform.GetChild(1).GetComponent<Animation>().Play();
                



                break;

            case 7: // pick A call
                DailCall.SetActive(false);
                StartCalling.SetActive(true);



                break;

            case 8: // pick A call
                DailCall.SetActive(false);
                StartCalling.SetActive(true);
                break;
            case 9: // pick A call
                Arrow.SetActive(false);
                Arrwo2.SetActive(true);
                Screen5Panel.SetActive(true);
                
                Screen10panel.SetActive(false);
                break;

            case 10: // To PI boaed1


                Highlite.transform.GetChild(1).GetComponent<Animation>().Stop();
                Highlite.transform.GetChild(1).GetComponent<Image>().color = Color.white;
                Highlite.transform.GetChild(3).GetComponent<Animation>().Play();

                Screensaver.SetActive(false);


              


                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[0].transform.position;
                Player.transform.rotation = playerPos[0].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                Boardpi1(QuestionNo);
                PuzzelMaxNo = 1;
                MenuNo = 24;

                break;

            case 11: //back to center Table

                Highlite.transform.GetChild(3).GetComponent<Animation>().Stop();
                Highlite.transform.GetChild(3).GetComponent<Image>().color = Color.white;
                Highlite.transform.GetChild(2).GetComponent<Animation>().Play();

                Screen6panel.SetActive(true);

                Screen4Panel.SetActive(false);
                Screen5Panel.SetActive(false);
               
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                CompletePi1.SetActive(false);
                Screen6panel.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "We are now going to plan the risk response.\n\nColumn " + QuestionNo+" in the following table lists five responses to this risk. For each of these responses, choose the corresponding risk response type (A–F). Each risk response type can be used once, more than once, or not at all.";
                break;

            case 12:
                Screen6panel.SetActive(false);
                Screen7panel.SetActive(true);
                break;

            case 13:
                Screen6panel.SetActive(false);
                Screen7panel.SetActive(false);
                QuestionSel(QuestionNo);
                QuestionPanel.SetActive(true);

                break;
            case 14:



              




                

                
                PuzzelMaxNo = 7;
                MenuNo = 25;
                Register1(QuestionNo);

                break;

            case 15: // FinishColoum 






                Screen8panel.SetActive(false);
                Screen9panel.SetActive(true);
                Risk1.SetActive(false); 

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;



                Highlite.transform.GetChild(2).GetComponent<Animation>().Stop();
                Highlite.transform.GetChild(2).GetComponent<Image>().color = Color.white;
                Highlite.transform.GetChild(0).GetComponent<Animation>().Play();




                break;

            case 18: // See What Changes in RiskBoard 
                Screen8panel.SetActive(false);
                Screen9panel.SetActive(false);
                Rist2Start.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[3].transform.position;
                Player.transform.rotation = playerPos[3].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;


                PuzzelMaxNo = 2;
                MenuNo = 26;

                Register2(QuestionNo);
                


                break;
            case 19: // See What Changes in Pi 
                Screen8panel.SetActive(false);
                Screen9panel.SetActive(false);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[4].transform.position;
                Player.transform.rotation = playerPos[4].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                Risk2.SetActive(false);


                Boardpi2(QuestionNo);
                PuzzelMaxNo = 1;
                MenuNo = 27;

                break;

            case 20: // See What Changes in Pi 

                Highlite.transform.GetChild(0).GetComponent<Animation>().Stop();
                Highlite.transform.GetChild(0).GetComponent<Image>().color = Color.white;
                Highlite.transform.GetChild(1).GetComponent<Animation>().Play();


                

                CompletePi2.SetActive(false);
                    

                Screen8panel.SetActive(false);
                Screen9panel.SetActive(false);
                Screen10panel.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[2].transform.position;
                Player.transform.rotation = playerPos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;




                break;

            case 21: // StartSecond
                CallQuestions(QuestionNo);
                Screensaver.SetActive(true);
                break;

            case 22: // End RedistryDes1
                CompleteDes.SetActive(true);
                break;

            case 23: // End Pi1
                CompletePi1.SetActive(true);
                break;
            case 24: // End Pi1

                CompletePi1.SetActive(true);
                break;
            case 25: // End Pi1
                Risk1.SetActive(true);
                break;
            case 26: // End Pi1
                Risk2.SetActive(true);
                break;
            case 27: // End Pi2
                CompletePi2.SetActive(true);
                break;



            case 28: // Select Activity 2

                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = playerPos[6].transform.position;
                Player.transform.rotation = playerPos[6].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;

























            case 40: // Select D

                SelectedAns = "D";
                AnsSelect(QuestionNo);
                break;
            case 41: // Select A

                SelectedAns = "A";
                AnsSelect(QuestionNo);
                break;
            case 42: // Select B

                SelectedAns = "B";
                AnsSelect(QuestionNo);
                break;
            case 43: // Select C

                SelectedAns = "C";
                AnsSelect(QuestionNo);
                break;
            case 44: // Select B

                SelectedAns = "B";
                AnsSelect(QuestionNo);
                break;
            case 45: // WrongAns
                AnsSelect(QuestionNo);

                break;

            case 46: //QuestionSatus
                if (CheckAns)
                {
                    Menu(14);
                    Screen9panel.SetActive(true);
                    QuestionStatus.SetActive(false);
                    
                    Menu(14);
                }
                else
                {
                    QuestionStatus.SetActive(false);
                    QuestionPanel.SetActive(true);
                }


                break;

            case 47: //OptionA
                StartCoroutine(TakingAdvice(1));

                Questions.SetActive(false);
                break;
            case 48: //OptionB
                StartCoroutine(TakingAdvice(2));

                Questions.SetActive(false);
                break;
            case 49: //OptionC
                StartCoroutine(TakingAdvice(3));

                Questions.SetActive(false);
                break;
            case 50: //OptionD
                StartCoroutine(TakingAdvice(4));

                Questions.SetActive(false);
                break;


            case 51:
                AllQ(Question_NO, 0);
                QuestionsIstructionPanel.SetActive(false);
                Questions.SetActive(true);
                
                break;

            case 52:// Saying
                
                //Saying.SetActive(true);
                RightAnswer.SetActive(false);
                AskQuestion = true;

                if (ISAnsTrue)
                {
                    Answers.SetActive(true);
                    ISAnsTrue = false;
                }
                else
                {
                    Answers.SetActive(false);
                    Questions.SetActive(true);
                    AllQ(Question_NO, 0);

                }


                if (Question_NO == 3)
                {
                    Question_NO = 1;
                    Answers.SetActive(false);
                    Questions.SetActive(true);
                    AllQ(Question_NO, 0);
                }



                break;

            case 53:
                Rist2Start.SetActive(false);    
                break;


           



        }
        Debug.Log("Call");

    }

    public void PuzzelNo()
    {
        PuzzelIndex++;
        if (PuzzelIndex == PuzzelMaxNo)
        {
            Menu(MenuNo);
            PuzzelIndex = 0;
        }


    }


    #region Lip cinking 

    private void Update()
    {
        GetAmplitude();
    }

    private float GetAmplitude() 
    {
        if (NpcAudio != null && NpcAudio.clip != null && NpcAudio.isPlaying)
        {
            Talk.Play();
        }
        else
        {
            Talk.Stop();
        }
        return 0;
    }
    #endregion

    


    void QuestionSel(int No)
    {
        switch (No)
        {
            case 1:
                QuestionText.text = "Question 1: There is a growing concern that the long term recruitment agency to FloorIT may not be able to recruit the team of trainers in time. Ensure the contract stipulates the agency are financially penalised if there are any time delays.";
               
                break;
            case 2:
                QuestionText.text = "Question 2: FloorIT decides to cancel the new Diary system and the training required and continue with the existing approach because the risk of losing customers with untrained staff is too high.";
                break;
            case 3:
                QuestionText.text = "Question 3: It may be advisable to widen the selection process and contact more recruitment agencies.";
                break;
            case 4:
                QuestionText.text = "Question 4: It has been suggested that if the recruitment agency is unable to source enough suitable candidates within a short time frame they should be switched to another agency.";
                break;
            case 5:
                QuestionText.text = "Question 5: It has been suggested that training staff should be selected from FloorIT to ensure there if a full delivery team.";
                break;
        }
        
    }
    void AnsSelect(int No)
    {
        StatusText.text = "Please try another answer";
        QuestionStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
        CheckAns = false;

        switch (No)
        {
            case 1:
                if (SelectedAns == "D")
                {
                    StatusText.text = "Solution \nTransfer. With the addition of the stipulation in the contract with the recruitment agency, the project is transferring some of the financial risk to the outsourced agency.\n\n" +
                        "Ok thank you, that is the correct risk response. Please go to the register and fill it out. \nAll the tiles have to be put in the correct space for the description and then question " + (QuestionNo) + ".column " + (QuestionNo) + " only.";
                    QuestionStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    CheckAns = true;
                    QuestionNo++;
                }
                break;
            case 2:
                if (SelectedAns == "A")
                {
                    StatusText.text = "Solution \nSometimes doing nothing and cancelling the project is the preferred choice. In doing so the risk is eliminated and therefore avoided.\n\n" +
                        "Ok thank you, that is the correct risk response. Please go to the register and fill it out. \nAll the tiles have to be put in the correct space for the description and then question " + (QuestionNo) + ".column " + (QuestionNo) + " only."; ;
                    QuestionStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    CheckAns = true;
                    QuestionNo++;
                }
                break;
            case 3:
                if (SelectedAns == "B")
                {
                    StatusText.text = "Solution \nIn spreading the contract for the recruitment of trainers to many agencies the likelihood of not hiring enough quality trainers will reduce the impact and probability of the risk.\n\n" +
                        "Ok thank you, that is the correct risk response. Please go to the register and fill it out. \nAll the tiles have to be put in the correct space for the description and then question " + (QuestionNo) + ".column " + (QuestionNo) + " only."; ;
                    QuestionStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    CheckAns = true;
                    QuestionNo++;
                }
                break;
            case 4:
                if (SelectedAns == "C")
                {
                    StatusText.text = "Solution \nThis option involves preparing now, but not taking action now. It is a reactive response and one where a contingent plan is prepared if the agency fails to deliver.\n\n" +
                        "Ok thank you, that is the correct risk response. Please go to the register and fill it out. \nAll the tiles have to be put in the correct space for the description and then question " + (QuestionNo) + ".column " + (QuestionNo ) + " only."; ;
                    QuestionStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    CheckAns = true;
                    QuestionNo++;
                }
                break;
            case 5:
                if (SelectedAns == "B")
                {
                    StatusText.text = "Solution \nIn this option, the delivery approach is to source from in-house thereby removing the risk of not having a delivery team in place on time.\n" +
                        "Ok thank you, that is the correct risk response. Please go to the register and fill it out. \nAll the tiles have to be put in the correct space for the description and then question " + (QuestionNo - 1) + ".column " + (QuestionNo - 1) + " only."; ;
                    QuestionStatus.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                    CheckAns = true;
                    QuestionNo++;
                }
                break;

                



        }

        

        QuestionPanel.SetActive(false);
        QuestionStatus.SetActive(true);


    }
    void CallQuestions(int No)
    {
        switch (No)        
        {
            case 1:
                VideoCallText.text = "scenario 1 \nGood morning. My name is Daniel and I have been asked to discuss five risk scenarios with you. Let me start with Risk scenario 1 and input on the following risk. Let me start with the first. There is a growing concern that the long term recruitment agency to FloorIT may not be able to recruit the team of trainers in time. In my assessment I believe the risk summary profile has a high probability and a very high impact. But of course it is your final decision.";
                break;
            case 2:
                VideoCallText.text = "There is a discussion that the project may be cancelled";
                break;
            case 3:
                VideoCallText.text = "It may be advisable to widen the selection process and contacting more recruitment agencies.";
                break;
            case 4:
                VideoCallText.text = "It has been suggested that training staff should be selected from FloorIT to ensure there if a full delivery team.";

                break;
            case 5:
                VideoCallText.text = "It has been suggested that training staff should be selected from FloorIT and seconded to the project to ensure there if a full delivery team.";
                break;
        }
    }

    void Boardpi1(int No)
    {
        if (QuestionNo == 1)
        {

        }
        else
        {
            Pi1boards[QuestionNo - 2].SetActive(false);
        }           
        Pi1boards[QuestionNo - 1].SetActive(true);
    }
    void Boardpi2(int No)
    {
        if (QuestionNo == 2)
        {

        }
        else
        {
            Pi2boards[QuestionNo - 3].SetActive(false);
        }
       
        Pi2boards[QuestionNo - 2].SetActive(true);
    }
    void Register1(int No)
    {
        Reqister1boards[QuestionNo -1].SetActive(true);

        mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
        Player.transform.position = RiskB1pos[QuestionNo - 1].transform.position;
        Player.transform.rotation = RiskB1pos[QuestionNo - 1].transform.rotation;
        mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;






    }
    void Register2(int No)
    {
        Reqister2boards[QuestionNo - 2].SetActive(true);

        if (No == 3)
        {
            PuzzelMaxNo = 3;
        }



        if (No == 2)
        {

        }
        else
        {
            Reqister2boards[QuestionNo - 3].transform.GetChild(0).gameObject.SetActive(false);
        }
    }


    IEnumerator TakingAdvice(int No)
    {

        yield return new WaitForSeconds(2);
        RightAnswer.SetActive(true);
        AllQ(Question_NO, No);

    }

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




                if (AskQuestion)
                {
                   // NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q" + QNO);
                   // NpcAudio.Play();
                }



                Options[0].text = "No because this is not one of the risk responses proscribed within PRINCE2.";
                Options[1].text = "No, because the closure of the project is not a valid planned risk response.";
                Options[2].text = "Yes, because the closure of a project is a possibility and therefore a valid planned risk response.";
                Options[3].text = " Yes, because the closure of projects should always occur if there is a serious risk.";

                AllAnswers[0].text = "Incorrect. Closure of a project can be a proportionate response to a valid risk.";
                AllAnswers[1].text = "Incorrect. Closure of a project can be a proportionate response to a valid risk.";
                AllAnswers[2].text = "Correct. Closure of a project is a valid risk response when it is proportionate.";
                AllAnswers[3].text = "Incorrect. Closure of a project may be appropriate, but will not always have to occur when there is a serious risk.";

                AllAnswers[0].color = Color.white;
                AllAnswers[1].color = Color.white;
                AllAnswers[2].color = new Color32(2, 156, 0, 255);
                AllAnswers[2].transform.parent.gameObject.GetComponent<Image>().sprite = SpriteSelectedAns;
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

                       // NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q1-OP1");
                      //  NpcAudio.Play();

                        ButtionText.text = "Try Again";

                        break;
                    case 3:
                        AnswerStatus.text = "Thankyou for your advice. That’s what Quality assurance has told us also. It’s good that we are all in agreement. Let’s review the reason why.";

                       // NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q1-OP3");
                       // NpcAudio.Play();

                        ButtionText.text = "Solution";

                        Question_NO++;
                        ISAnsTrue = true;
                        break;
                    case 4:
                        AnswerStatus.text = "Thankyou for your advice. Whilst closure is a possibility it is not mandatory for it to always be the planned response to a serious risk. Let’s review the reason why.";

                       // NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q1-OP4");
                       // NpcAudio.Play();

                        ButtionText.text = "Solution";

                        

                        break;
                }
                break;




            case 2:
                QuestionText = "2:</font><indent=1em> The project manager having assessed the risk of not being able to attract sufficient quality trainers, will have to ensure that the job specification is enhanced for trainers leading to an increase in the daily rate of payment to trainers. This is required in order to attract high quality trainers to ensure the success of the project. The Executive has provided approval of the over spend to be funded from the change budget. Is this appropriate, and why or why not?";
                Question.text = QuestionText;
                Question1.text = QuestionText;

                if (AskQuestion)
                {
                   // NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q" + QNO);
                   // NpcAudio.Play();
                }


                Options[0].text = "Yes, because this is a change and therefore funding from the change budget is appropriate.";
                Options[1].text = "Yes, because this change is an off-specification and a change and therefore funding from the change budget is appropriate.";
                Options[2].text = "No, because risk should be funded from the project tolerance budget.";
                Options[3].text = "No, because risks should be funded from a risk budget. A risk is a threat that has not occurred and this is different to a change request.";

                AllAnswers[0].text = "Incorrect. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[1].text = "Incorrect. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[2].text = "Incorrect. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[3].text = "Correct. A risk should be funded from a risk budget and not the change budget.";
                AllAnswers[0].color = new Color32(2, 156, 0, 255);
                AllAnswers[0].transform.parent.gameObject.GetComponent<Image>().sprite = SpriteSelectedAns;
                AllAnswers[1].color = Color.white;
                AllAnswers[2].color = Color.white;
                AllAnswers[3].color = Color.white;



                switch (ANO)
                {
                    case 1:
                        AnswerStatus.text = "Thankyou for the advice. Having consulted quality assurance we have concluded that this is in fact a risk and not a change and therefore it is not appropriate. The lessons learnt are that risks should be funded from the risk budget.";
                       

                       // NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q2-OP1");
                       // NpcAudio.Play();

                        ButtionText.text = "Solution";

                        break;
                    case 2:
                        AnswerStatus.text = "Thankyou for the advice. Having consulted quality assurance we have concluded that this is in fact a risk and not a change and therefore it is not appropriate. The lessons learnt are that risks should be funded from the risk budget.";

                        //NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q2-OP2");
                       // NpcAudio.Play();

                        

                        ButtionText.text = "Solution";

                        break;
                    case 3:
                        AnswerStatus.text = "Thankyou for the advice. Having consulted quality assurance we have concluded that this is in fact a risk and not an overspend and therefore it is not appropriate to fund this from the tolerance budget. The lessons learnt are that risks should be funded from the risk budget.";

                        //NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q2-OP3");
                        //NpcAudio.Play();

                        ButtionText.text = "Try Again";

                        break;
                    case 4:
                        AnswerStatus.text = "Thankyou for your advice. That’s what Quality assurance has told us also. It’s good that we are all in agreement. Let’s review the reason why.";

                        //NpcAudio.clip = Resources.Load<AudioClip>("Audio/A2-Q2-OP4");
                        //NpcAudio.Play();

                        Question_NO++;
                        ISAnsTrue = true;

                        ButtionText.text = "Try Again";

                        break;
                }
                break;

        }
        AskQuestion = false;

    }


}
