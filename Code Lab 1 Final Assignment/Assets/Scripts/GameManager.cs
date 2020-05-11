using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text score;
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
        score = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //score.text = ("Score: " + GameManager.instance.counter + "/5"); 
    }
}
