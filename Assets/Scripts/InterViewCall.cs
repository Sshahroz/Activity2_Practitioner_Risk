using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterViewCall : MonoBehaviour
{
    [SerializeField] bool ChkCV = true;
    [SerializeField] Transform ActiveObj;
    [SerializeField] Animation ScanAni;


    [SerializeField] GameObject StartCallPane;
    [SerializeField] GameObject ReadyForCallPannel;

    [SerializeField] GameObject[] NPCs;

    [SerializeField] GameObject SpawnNpcPos;


    [SerializeField] TMPro.TextMeshProUGUI[] NpcQuestions; 
    [SerializeField] TMPro.TextMeshProUGUI infoText; 
    [SerializeField] TMPro.TextMeshProUGUI NpcAns;


    int Npcindex;


    //NPCS Audios
    AudioSource NpcAnsAudio;


    private void Start()
    {
        ScanAni = transform.parent.GetComponent<Animation>();
        NpcAnsAudio = this.GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider other)
    {

        if (ChkCV && ActiveObj == null )
        {
            //other.transform.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = false;
            other.transform.GetComponent<BoxCollider>().enabled = false;
            other.transform.GetComponent<Rigidbody>().isKinematic = true;


            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;


            StartCoroutine(ExampleCoroutine());
            if (other.transform.position == transform.position)
            {
                ScanAni.Play();
                ActiveObj = other.transform;
                ChkCV = false;
                StartCoroutine(ReadyCall());
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {

        if (ActiveObj == null )
        { return; }
        if (other.name == ActiveObj.name)
        {
            ActiveObj = null;
            ChkCV = true;
            ReadyForCallPannel.SetActive(false);
            StartCallPane.SetActive(false);

            if (SpawnNpcPos.transform.childCount > 0)
            {
                Destroy(SpawnNpcPos.transform.GetChild(0).gameObject);
            }
            
        }



    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        //ActiveObj.GetComponent<WebXR.Interactions.MouseDragObject>().enabled = true;
        ActiveObj.GetComponent<BoxCollider>().enabled = true;
        ActiveObj.transform.GetComponent<Rigidbody>().isKinematic = false;
    }
    IEnumerator ReadyCall()
    {
        yield return new WaitForSeconds(1.5f);
        ReadyForCallPannel.SetActive(true);
    }


    public void Call()
    {
        
        int.TryParse(ActiveObj.name, out Npcindex);
        StartCalling(Npcindex);
    }


     void StartCalling(int No)
    {
        GameObject NPC;


        NpcQuestions[0].text = "What is your experience of working on a project board?";
        NpcQuestions[1].text = "Do you have sufficient time to dedicate to this project?";
        NpcQuestions[2].text = "Do you have a PRINCE2 qualification?";
        NpcQuestions[3].text = "What is your experience of working on a project?";
        NpcQuestions[4].text = "What is your experience of managing a project?";


        switch (No)
        {
            case 1: // CEO
                NPC = Instantiate(NPCs[0], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y -.2f, SpawnNpcPos.transform.position.z) , SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "The chief executive officer is the founding member and built the business 15 years ago. She is primarily focused on marketing strategies to improve the revenue stream following the pandemic sales slump. She has mobilized a range of projects to achieve this. She was surprised at how many appointments were canceled, confused over the agreed times and dates, and the customer’s annoyance at this. She is extremely busy and cannot commit her time to any singular project.";
               
                break;

            case 2: // Marketing Director 
                NPC = Instantiate(NPCs[1], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "The Marketing Director is responsible for all marketing strategies and deployment and is specifically tasked with increasing sales following the sales slump. He has a particular interest in this project and it’s a success as it features directly in the business recovery plan. And this has been highlighted as a key project to re-ignite sales.";

                break;
            case 3: // Financial Director   
                NPC = Instantiate(NPCs[2], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "The financial director for FloorIT is responsible for the financial management of the company. He is very experienced with the implementation of a new software system within finance.";

                break;
            case 4: // Head of Learning and development
                NPC = Instantiate(NPCs[3], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "The Head of Learning and development is responsible for designing the training program and roll-out and has a certification in PRINCE2. he has led many roll-outs of training across major new implementations.";

                break;
            case 5: // Marketing manager at FloorIT
                NPC = Instantiate(NPCs[4], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "The marketing manager at FloorIT oversees all sales and marketing activities and the deployment of all related projects.";

                break;
            case 6: // Executive Administrator 
                NPC = Instantiate(NPCs[5], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "Executive Administrator created and administered FloorIT’s documentation management system on SharePoint. This stores all documents and naturally orders files by prioritizing files by version and date. All project documents are filed here. She is a shared resource for all executives and also provides administrative support to major projects. The Project manager at the contracted company Diary systems manages the building of the diary system and its maintenance for FloorIT.";

                break;
            case 7: // The IT manager at FloorIT
                NPC = Instantiate(NPCs[6], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "The chief operating officer at FloorIT oversees the out-sourced production of all products in Europe and the Far-east.";

                break;
            case 8: // Chief operating officer at FloorIT
                NPC = Instantiate(NPCs[7], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();
            
                infoText.text = "The IT manager at FloorIT managed the contractor DiarySystems and is Agile-qualified.";

                break;
            case 9: // Head of HR 
                NPC = Instantiate(NPCs[8], new Vector3(SpawnNpcPos.transform.position.x, SpawnNpcPos.transform.position.y - .2f, SpawnNpcPos.transform.position.z), SpawnNpcPos.transform.rotation);
                NPC.transform.parent = SpawnNpcPos.transform;
                Debug.Log("Sel");
                StartCallPane.SetActive(true);
                StartCallPane.GetComponent<Animation>().Play();

                infoText.text = "The Head of HR is tasked with ensuring the many store teams and stakeholders’ feedback for new systems and it’s implementation are heard and engaged and understood throughout the project life-cycle.";

                break;

        }
        NpcAns.text = "";
    }



    public void QuestionsAns(int QuestionNo)
    {


        switch (QuestionNo)
        {
            case 1: // What is your experience of working on a project board?

                if (Npcindex == 1 || Npcindex == 2 || Npcindex == 3 || Npcindex == 8)
                {
                    NpcAns.text = "I have experience working within a Project Board";


                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_R");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_R");
                        NpcAnsAudio.Play();
                    }





                }
                else
                {
                    NpcAns.text = "I do not have experience of working on a Project Board";


                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_W");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_W");
                        NpcAnsAudio.Play();
                    }





                }
                        break;

            case 2:

                if (Npcindex == 2 || Npcindex == 3 || Npcindex == 4 || Npcindex == 5 || Npcindex == 6 || Npcindex == 7 || Npcindex == 8 || Npcindex == 9)
                {
                    NpcAns.text = "I have sufficient time";


                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_R");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_R");
                        NpcAnsAudio.Play();
                    }



                }
                else
                {
                    NpcAns.text = "I do not have time to work on this project";

                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_W");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_W");
                        NpcAnsAudio.Play();
                    }

                }              
                        break;

            case 3:

                if (Npcindex == 1 || Npcindex == 2 || Npcindex == 3 || Npcindex == 4 || Npcindex == 8)
                {
                    NpcAns.text = "I am PRINCE2 qualified";

                   

                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_R");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_R");
                        NpcAnsAudio.Play();
                    }


                }
                else
                {
                    NpcAns.text = "I am not PRINCE2 qualified";

                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_W");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_W");
                        NpcAnsAudio.Play();
                    }


                }

                        break;

            case 4:

                 NpcAns.text = "I have experience of working within a project";



                if (Npcindex == 1 || Npcindex == 6)
                {
                    NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_R");
                    NpcAnsAudio.Play();
                }
                else
                {
                    NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_R");
                    NpcAnsAudio.Play();
                }




                break;

            case 5:

                if (Npcindex == 1 || Npcindex == 2 || Npcindex == 3 || Npcindex == 4 || Npcindex == 5 || Npcindex == 7 || Npcindex == 8 || Npcindex == 9)
                {
                    NpcAns.text = "I have experience of managing a project";

                   

                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_R");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_R");
                        NpcAnsAudio.Play();
                    }



                }
                else
                {
                    NpcAns.text = "I have not managed a project";

                    if (Npcindex == 1 || Npcindex == 6)
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_G_W");
                        NpcAnsAudio.Play();
                    }
                    else
                    {
                        NpcAnsAudio.clip = Resources.Load<AudioClip>("CallAudio/" + QuestionNo + "_B_W");
                        NpcAnsAudio.Play();
                    }




                }

                    break;
                }           
      }
    }






