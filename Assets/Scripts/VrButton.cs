
using UnityEngine;
using UnityEngine.Events;

public class VrButton : MonoBehaviour
{
    [SerializeField] GameObject Button;
    [SerializeField] UnityEvent OnPress;
    [SerializeField] UnityEvent OnRelese;
    GameObject Presser;
    [SerializeField] bool isPressed;
    AudioSource ClickAvdio;
     


    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        Button = transform.GetChild(0).gameObject;
        ClickAvdio = this.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (isPressed == false && other.tag == "Touch")
        {
            Button.transform.localPosition = new Vector3(0, -0.003f, 0);
            
            isPressed = true;
            Debug.Log("Predded");
            ClickAvdio.Play();
            OnPress.Invoke();



        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (isPressed && other.tag == "Touch")
        {
            Button.transform.localPosition = new Vector3(0, 0, 0);
            OnRelese.Invoke();
            isPressed = false;
        }
    }
}
