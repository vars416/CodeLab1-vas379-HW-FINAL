using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //make instance of game manager

    private Scene currentscene;
    public Text score; //text that will show score
    public GameObject KissText; //kiss prompt text
    private int counter = 0; 

    public int Counter
    {
        get
        {
            return counter; //get counter
        }
        set
        {
            counter = value; //set "score" to whatever value was passed
            
        }
    }

    private void Awake()
    {
        if (instance == null)
        { 
            instance = this; //set instance to this object
            DontDestroyOnLoad(gameObject); //Don't Destroy this object
        }
        else
        { 
            Destroy(gameObject); //if another instance is present then destroy this instance
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentscene = SceneManager.GetActiveScene(); //get currentscene
        score = GetComponentInChildren<Text>(); //get text which is child of gamemanager
        KissText.GetComponent<Text>(); //get text from kisstext
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ("Stars: " + GameManager.instance.counter/2); //display score after dividing it by 2
        
        if (Input.GetKeyDown(KeyCode.Escape)) //if 'Esc' is pressed then
        {
            Application.Quit(); //quit game
        }
    }

    private void FixedUpdate() //using fixed update so the function below happens only once
    {
        if (GameManager.instance.counter >= 24) //if score is greater than or equal to 24
        {

            //Kiss.gameObject.GetComponent<Image>().enabled = true;
            //Invoke("ChangeScene", 10f);
            Invoke("ShowKissTextAndStars", 8f); //invoke ShowKissTextAndStars after 8 seconds

        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(2); //go to scene with index no. 2
    }

    void ShowKissTextAndStars()
    {
        KissText.GetComponent<Text>().enabled = true; //text becomes visible
        if (Input.GetKeyDown(KeyCode.K)) //now, if K is pressed
        {
            ChangeScene(); //scene changes
            Destroy(KissText); //text gets destroyed
        }
        print("working");
    }
}
