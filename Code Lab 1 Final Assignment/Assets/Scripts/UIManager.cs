using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance2;

    public Text TitleCard; //text for title
    public Button StartGame; //button for start
    public Button Quit; //button for quit
    public GameObject Credits; //text for credits

    private void Awake()
    {
        if (instance2 == null)
        {
            instance2 = this; //set instance to this object
            DontDestroyOnLoad(gameObject); //Don't Destroy this object
        }
        else
        {
            Destroy(gameObject); //if another instance is present, then destroy this object
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        TitleCard = GetComponent<Text>(); //get text for title
        Credits.GetComponent<Text>(); //get text for credits
        StartGame = GetComponent<Button>(); //get button for start
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGameScene()
    {
        SceneManager.LoadScene(1); //load scene with index number 1
    }

    public void QuitGame()
    {
        Application.Quit(); //quit game
    }

    public void ShowCredits()
    {
        Credits.GetComponent<Text>().enabled = true; //show credits
    }

    public void HideCredits()
    {
        Credits.GetComponent<Text>().enabled = false; //hide credits
    } 

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0); //load scene with index number 0
    }

}
