using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private Scene currentscene;
    public Text score;
    public GameObject KissText;
    public Image Kiss;
    private int counter = 0;

    public int Counter
    {
        get
        {
            return counter;
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
            Destroy(gameObject); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentscene = SceneManager.GetActiveScene();
        score = GetComponentInChildren<Text>();
        KissText.GetComponent<Text>();
        //KissText.GetComponentInChildren<Text>().enabled = false;
        Kiss = GetComponentInChildren<Image>();
        //Kiss.gameObject.GetComponent<Image>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        score.text = ("Score: " + GameManager.instance.counter/2 + "/5");
        if (GameManager.instance.counter >= 3)
        {
            KissText.GetComponent<Text>().enabled = true;
            if (Input.GetKeyDown(KeyCode.K))
            {
                print("scene kya hai");
                ChangeScene();
            }
            //Kiss.gameObject.GetComponent<Image>().enabled = true;
            //Invoke("ChangeScene", 10f);
            //Invoke("ShowKissText", 5f);

        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }

    void ShowKissText()
    {
        //Kiss.gameObject.GetComponent<Image>().enabled = true;
        //Kiss.setActive(true);
        //Kiss.GetComponent<Text>().enabled = true;
        //Kiss.GetComponentInChildren<Text>().enabled = true;
        print("working");
    }
}
