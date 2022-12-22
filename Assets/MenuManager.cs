using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Events;

public class MenuManager : MonoBehaviour
{

    [Header("player&SpawnPositions")]
    [SerializeField] Transform Player, mainCamera;
    [SerializeField] GameObject DragObj;
    [SerializeField] Transform[] pos;
   



    //Add Coment

    [Header("Activity 2 Atributes")]

    [SerializeField] GameObject SelectCoure;
    [SerializeField] GameObject Arrow;
    [SerializeField] GameObject First;


    [Header("Activity 2 Menu Atributes")]



    [Header("Activity 1 Atributes")]
    [SerializeField] GameObject Activity1lerningObjaectivePanel;
    [SerializeField] GameObject Activity1_1ObjaectivePanel;
    [SerializeField] GameObject Activity1_1Board;
    [SerializeField] int Activity1_1Max_Value;
    [SerializeField] int Activity1_1EndPandel_Value;
    [SerializeField] GameObject Activity1_1EndPanel;



    [SerializeField] GameObject Activity1_2ObjaectivePanel;
    [SerializeField] GameObject Activity1_2Board;
    [SerializeField] int Activity1_2Max_Value;
   
    [SerializeField] int Activity1_2EndPandel_Value;
    [SerializeField] GameObject Activity1_2EndPanel;



    [SerializeField] GameObject Activity1_3ObjaectivePanel;
    [SerializeField] GameObject Activity1_3Board;
    [SerializeField] int Activity1_3Max_Value;
    [SerializeField] int Activity1_3EndPandel_Value;
    [SerializeField] GameObject Activity1_3EndPanel;


    [SerializeField] GameObject Activity1Summary;
    [SerializeField] GameObject Activity1Summary1;

    
    




    [Header("Activity 2 Atributes")]




    [SerializeField] GameObject Activity2lerningObjaectivePanel;
    [SerializeField] GameObject Activity2lerningObjaectivePanel1;

    [SerializeField] GameObject Activity2_1InstructionsPanel;
    [SerializeField] GameObject Activity2_1Board;
    [SerializeField] int Activity2_1Max_Value;
    [SerializeField] int Activity2_1EndPandel_Value;
    [SerializeField] GameObject Activity2_1EndPanel;


    [SerializeField] GameObject Activity2_2InstructionsPanel;
    [SerializeField] GameObject Activity2_2EndPanel;
    [SerializeField] GameObject Activity2_2Board;
    [SerializeField] int Activity2_2Max_Value;
    [SerializeField] int Activity2_2EndPandel_Value;


    [SerializeField] GameObject Activity2_3InstructionsPanel;
    [SerializeField] GameObject Activity2_3Board;
    [SerializeField] int Activity2_3Max_Value;
    [SerializeField] int Activity2_3EndPandel_Value;
    [SerializeField] GameObject Activity2_3EndPanel;

    [SerializeField] GameObject Activity2_4InstructionsPanel;
    [SerializeField] GameObject Activity2_4Board;
    [SerializeField] int Activity2_4Max_Value;
    [SerializeField] int Activity2_4EndPandel_Value;
    [SerializeField] GameObject Activity2_4EndPanel;


    [SerializeField] GameObject Activity2_Summary;




    [Header("Activity 3 Atributes")]

    [SerializeField] GameObject Activity3objective;
    [SerializeField] GameObject Activity3objective1;
    [SerializeField] GameObject Activity3SpawnPoints;   




    [Header("AllBoard")]
    int BordsSovedMaxValue;
    [SerializeField] int BoardIndexNo;
    int ActivityEndPanelNo;
    int SavePos;






    [Header("Activity4")]
    [SerializeField] GameObject Activity4Istrution;
    [SerializeField] GameObject Activity4Questions;
    [SerializeField] GameObject Status;
    [SerializeField] TMPro.TextMeshProUGUI Activity4QuestionText;
    [SerializeField] TMPro.TextMeshProUGUI Activity4StatrusText;
    [SerializeField] int QuestionNo;
    [SerializeField] string OptionSelected; 



    [SerializeField] AudioSource NpcAudio;

    [SerializeField] AudioClip[] Clips;

    [SerializeField] Animation Talk;

    private float[] audioSample = new float[AUDIO_SAMPLE_LENGTH];
    private const int AUDIO_SAMPLE_LENGTH = 4096;
    private const int AMPLITUDE_MULTIPLIER = 10;

   
   



    bool AskQuestion;


    private void Start()
    {
        QuestionNo = 0;
        SavePos = 0;
        Activity1_1Board.transform.GetChild(1).gameObject.SetActive(true);
        Activity1lerningObjaectivePanel.SetActive(true);



    }
    public void Menu(int no)
    {
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
                Arrow.SetActive(false);
                //Activity2.SetActive(false);
                //Activity1.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                
                Player.transform.position = pos[SavePos].transform.position;
                Player.transform.rotation = pos[SavePos].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                break;

            case 17: // Select Activity 2
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;

                Player.transform.position = pos[10].transform.position;
                Player.transform.rotation = pos[10].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;          
                break;

            #endregion

            #region Activity1 
            case 3: //Activity 1.1 Objective 
                Activity1lerningObjaectivePanel.SetActive(false);
                Activity1_1ObjaectivePanel.SetActive(true);
                break;
            case 4: //Activity 1.1 Start
                Activity1lerningObjaectivePanel.SetActive(false);
                Activity1_1ObjaectivePanel.SetActive(false);
                Activity1_1Board.transform.GetChild(0).gameObject.SetActive(true);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity1_1Max_Value;
                ActivityEndPanelNo = Activity1_1EndPandel_Value;

                break;
            case 5: //Activity 1.1 end
                Activity1lerningObjaectivePanel.SetActive(false);
                Activity1_1ObjaectivePanel.SetActive(false);
                Activity1_1EndPanel.SetActive(true);
                break;

            case 6: //Activity 1.2 Objective
                Activity1lerningObjaectivePanel.SetActive(false);
                Activity1_2ObjaectivePanel.SetActive(true); 
                Activity1_1ObjaectivePanel.SetActive(false);
                Activity1_1EndPanel.SetActive(false);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Activity1_1Board.transform.GetChild(1).gameObject.SetActive(false);
                Player.transform.position = pos[1].transform.position;
                Player.transform.rotation = pos[1].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                Activity1_2Board.transform.GetChild(1).gameObject.SetActive(true);

                break;
            case 7: //Activity 1.1 Start
                Activity1lerningObjaectivePanel.SetActive(false);
                Activity1_2ObjaectivePanel.SetActive(false);
                Activity1_2Board.transform.GetChild(0).gameObject.SetActive(true);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity1_2Max_Value;
                ActivityEndPanelNo = Activity1_2EndPandel_Value;
                break;

            case 8: //Activity 1.2 end             
                Activity1_2ObjaectivePanel.SetActive(false);
                Activity1_2EndPanel.SetActive(true);
                break;

            case 9: //Activity 1.3 Objective
                Activity1lerningObjaectivePanel.SetActive(false);
                Activity1_2ObjaectivePanel.SetActive(false);
                Activity1_3ObjaectivePanel.SetActive(true);
                Activity1_2EndPanel.SetActive(false);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Activity1_2Board.transform.GetChild(1).gameObject.SetActive(false);
                Player.transform.position = pos[2].transform.position;
                Player.transform.rotation = pos[2].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;

            case 10: //Activity 1.1 Start
                Activity1lerningObjaectivePanel.SetActive(false);
                Activity1_3ObjaectivePanel.SetActive(false);
                Activity1_3Board.transform.GetChild(0).gameObject.SetActive(true);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity1_3Max_Value;
                ActivityEndPanelNo = Activity1_3EndPandel_Value;
                break;

            case 11: //Activity 1.3 end             
                Activity1_3ObjaectivePanel.SetActive(false);
                Activity1_3EndPanel.SetActive(true);
                break;


            case 12: //Activity 1 Summary
                Activity1_3EndPanel.SetActive(false);
                Activity1Summary.SetActive(true);
                break;
            case 13: //Activity 1 Summary1
                Activity1_3EndPanel.SetActive(false);
                Activity1Summary.SetActive(false);
                Activity1Summary1.SetActive(true);
                break;

            case 14: //Activity 2 objective
                Activity1_3EndPanel.SetActive(false);
                Activity1Summary.SetActive(false);
                Activity1Summary1.SetActive(false);
                Activity2lerningObjaectivePanel.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Activity1_3Board.transform.GetChild(1).gameObject.SetActive(false);
                Player.transform.position = pos[3].transform.position;
                Player.transform.rotation = pos[3].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                Activity2_1Board.transform.GetChild(1).gameObject.SetActive(true);
                break;

                //Activity2

            case 15: //Activity 2 objective1
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2lerningObjaectivePanel1.SetActive(true);
                break;
            case 18: //Activity 2.1 OpenIns
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2lerningObjaectivePanel1.SetActive(false);
                Activity2_1InstructionsPanel.SetActive(true);
                break;
            case 19: //Activity 2.1 Start //Description
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2lerningObjaectivePanel1.SetActive(false);
                
                Activity2_1InstructionsPanel.SetActive(false);
                Activity2_1Board.transform.GetChild(0).gameObject.SetActive(true);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity2_1Max_Value;
                ActivityEndPanelNo = 20;
                break;
            case 20: //Activity 2.1 Start //ProjectDiary
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2lerningObjaectivePanel1.SetActive(false);
                Activity2_1InstructionsPanel.SetActive(false);
                Activity2_1Board.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
                Activity2_1Board.transform.GetChild(0).GetChild(3).gameObject.SetActive(true);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity2_1Max_Value;
                ActivityEndPanelNo = 21;
                break;
            case 21: //Activity 2.1 End     
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2lerningObjaectivePanel1.SetActive(false);
                Activity2_1InstructionsPanel.SetActive(false);
                Activity2_1EndPanel.SetActive(true);
                
                break;

            case 22: //Activity 2.2 Start
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2_2InstructionsPanel.SetActive(true);
                Activity2_1EndPanel.SetActive(false);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Activity2_1Board.transform.GetChild(1).gameObject.SetActive(false);
                Activity2_2Board.transform.GetChild(1).gameObject.SetActive(true);
                Player.transform.position = pos[4].transform.position;
                Player.transform.rotation = pos[4].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;
            case 23: //Activity 2.2 lerningObjective
                Activity2_2Board.transform.GetChild(0).gameObject.SetActive(true);
                Activity2_2InstructionsPanel.SetActive(false);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity2_2Max_Value;
                ActivityEndPanelNo = 24;
                break;
            case 24: //Activity 2.2 End
                Activity2_2EndPanel.SetActive(true);
                Activity2_2InstructionsPanel.SetActive(false);
                break;
            case 25: //Activity 2.3 Start
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2_3InstructionsPanel.SetActive(true);
                Activity2_2EndPanel.SetActive(false);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Activity2_2Board.transform.GetChild(1).gameObject.SetActive(false);
                Activity2_3Board.transform.GetChild(1).gameObject.SetActive(true);
                Player.transform.position = pos[5].transform.position;
                Player.transform.rotation = pos[5].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;

                break;
            case 26: //Activity 2.3 lerningObjective
                Activity2_3Board.transform.GetChild(0).gameObject.SetActive(true);
                Activity2_3InstructionsPanel.SetActive(false);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity2_3Max_Value;
                ActivityEndPanelNo = 27;
                break;
            case 27: //Activity 2.3 //Product description example
                Activity2_3Board.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
                Activity2_3Board.transform.GetChild(0).GetChild(3).gameObject.SetActive(true);
                Activity2_3InstructionsPanel.SetActive(false);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity2_3Max_Value;
                ActivityEndPanelNo = 28;
                break;
            case 28: //Activity 2.3 End
                Activity2_3EndPanel.SetActive(true);
                Activity2_3InstructionsPanel.SetActive(false);
                break;

            case 29: //Activity 2.4 Start
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2_3EndPanel.SetActive(false);
                Activity2_4InstructionsPanel.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Activity2_4Board.transform.GetChild(1).gameObject.SetActive(true);
                Activity2_3Board.transform.GetChild(1).gameObject.SetActive(false);
                Player.transform.position = pos[6].transform.position;
                Player.transform.rotation = pos[6].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;

            case 30: //Activity 2.4 lerningObjective
                Activity2_4Board.transform.GetChild(0).gameObject.SetActive(true);
                Activity2_4InstructionsPanel.SetActive(false);
                BoardIndexNo = 0;
                BordsSovedMaxValue = Activity2_4Max_Value;
                ActivityEndPanelNo = 31;
                break;
            case 31: //Activity 2.4 End
                Activity2_4EndPanel.SetActive(true);
                Activity2_4InstructionsPanel.SetActive(false);
                break;

            case 32: //Activity 2 Summary
                Activity2_4EndPanel.SetActive(false);
                Activity2_Summary.SetActive(true);
                break;
            case 33: //Activity 3 Start
                Activity2lerningObjaectivePanel.SetActive(false);
                Activity2_Summary.SetActive(false);
                Activity2_4EndPanel.SetActive(false);
                Activity3objective.SetActive(true);
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Activity2_4Board.transform.GetChild(1).gameObject.SetActive(false);
                Player.transform.position = pos[7].transform.position;
                Player.transform.rotation= pos[7].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;
            case 34: //Activity 3 lerningObjective
                Activity3objective.SetActive(false);
                Activity3objective1.SetActive(true);
                break;
            case 35: //Activity 3 lerningObjective
                Activity3objective.SetActive(false);
                Activity3objective1.SetActive(false);
                Activity3SpawnPoints.SetActive(true);
                DragObj.SetActive(true);
                break;


            //Activity3 Spawn points 1

            case 36:
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = pos[7].transform.position;
                Player.transform.rotation = pos[7].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;
            case 37:
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = pos[8].transform.position;
                Player.transform.rotation = pos[8].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;
            case 38:
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = false;
                Player.transform.position = pos[9].transform.position;
                Player.transform.rotation = pos[9].transform.rotation;
                mainCamera.GetComponent<UnityTemplateProjects.SimpleCameraController>().enabled = true;
                break;
            #endregion

            case 39:
                Activity4Istrution.SetActive(false);
                Activity4Questions.SetActive(true);
                break;

            case 40:
                Status.SetActive(false);
                Questions1(QuestionNo);
                Activity4Questions.SetActive(true);
               
                break;


            case 41: //Op1 F
                OptionSelected = "F";
                Questions(QuestionNo);
                
               
                break;
            case 42: //Op2 B
                OptionSelected = "B";
                Questions(QuestionNo);
               
                break;
            case 43: //Op3 C
                OptionSelected = "C";
                Questions(QuestionNo);
                
                break;
            case 44: //Op4 D
                OptionSelected = "D";
                Questions(QuestionNo);
                
                break;
            case 45: //Op5 E
                OptionSelected = "E";
                Questions(QuestionNo);
                
                break;

            case 46: //WrongngAns
                Activity4Questions.SetActive(false);
                Status.SetActive(true);
                Activity4StatrusText.text = "Please try another answer";
                Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";

                break;







        }
        Debug.Log("Call");

    }

    public void PuzzelNo()
    {
         BoardIndexNo ++;
        if (BordsSovedMaxValue == BoardIndexNo)
        {
            Menu(ActivityEndPanelNo);
            Debug.Log("sOLVED");
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

    IEnumerator TakingAdvice(int No) // call Wait For taking Advice
    {  
        yield return new WaitForSeconds(2);
       
    }


    void Questions1(int No)
    {
        switch (No)
        {
            case 0:
                Activity4QuestionText.text = "The lead Trainer has advised training the management team before the store staff based on her experience in order to improve the rollout success.";

                break;

            case 1:
                Activity4QuestionText.text = "The FloorIT project manager is waiting for approval to move to the first delivery stage. The project board must approve the project initiation documentation.";

                break;

            case 2:
                Activity4QuestionText.text = "The training pilot will commence once the 'Project Diary Tablet' is completed. Its completion will allow 'Project Diary Training' to commence.";

                break;

            case 3:
                Activity4QuestionText.text = "The project manager has been informed by the lead trainer that the piloting of the course can only start on time once the finalised design of the course has been signed off by the learning and development director on time.";

                break;

            case 4:
                Activity4QuestionText.text = "The recruitment of trainers will be handled by a recruitment agency.";

                break;



        }
      
    }


    void Questions(int No)
    {
       
        switch (No)
        {
            case 0:
                Activity4QuestionText.text = "The lead Trainer has advised training the management team before the store staff based on her experience in order to improve the rollout success.";

                if (OptionSelected == "F")
                {
                    Activity4StatrusText.text = "The correct answer is option F). The lead trainer is recalling lessons learnt from her experience in a previous project.";

                    QuestionNo++;
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                }
                else
                {
                    Activity4StatrusText.text = "Please try another answer";
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
                }
                break;

            case 1:
                Activity4QuestionText.text = "The FloorIT project manager is waiting for approval to move to the first delivery stage. The project board must approve the project initiation documentation.";


                if (OptionSelected == "B")
                {
                    Activity4StatrusText.text = "The correct answer is option B). In this question before stage one can commence the project initiation documentation must be approved. Therefore this is a 'plan prerequisite', something fundamental that needs to be in place before stage one can start.";
                    QuestionNo++;
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                }
                else
                {
                    Activity4StatrusText.text = "Please try another answer";
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
                }


                break;

            case 2:
                Activity4QuestionText.text = "The training pilot will commence once the 'Project Diary Tablet' is completed. Its completion will allow 'Project Diary Training' to commence.";

                if (OptionSelected == "C")
                {
                    Activity4StatrusText.text = "The correct answer is option C). In this question the project in the scenario is dependent on and external project and its completion. Therefore this is an external dependency.";
                    QuestionNo++;
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                }
                else
                {
                    Activity4StatrusText.text = "Please try another answer";
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
                }


                break;

            case 3:
                Activity4QuestionText.text = "The project manager has been informed by the lead trainer that the piloting of the course can only start on time once the finalised design of the course has been signed off by the learning and development director on time.";

                if (OptionSelected == "D")
                {
                    Activity4StatrusText.text = "The correct answer is option D). In this question there is a planning assumption the project. The project manager would mote that the plan is based on the assumption that the sign off must be completed on time for the piloting to commence on time.";
                    QuestionNo++;
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                }
                else
                {
                    Activity4StatrusText.text = "Please try another answer";
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
                }


                break;

            case 4:
                Activity4QuestionText.text = "The recruitment of trainers will be handled by a recruitment agency.";

                if (OptionSelected == "E")
                {
                    Activity4StatrusText.text = "The correct answer is option E). In this question there is a delivery approach to consider. The recruitment will not be managed by the HR department in FloorIT but outsourced to a recruitment agency.";
                    QuestionNo= 0 ;
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Next";
                }
                else
                {
                    Activity4StatrusText.text = "Please try another answer";
                    Status.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "TryAgain";
                }


                break;
               


        }
        Activity4Questions.SetActive(false);
        Status.SetActive(true);

    }



}
