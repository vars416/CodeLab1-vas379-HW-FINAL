using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance2;

    public Text TitleCard;
    public Button StartGame;
    public Button Quit;
    public Text Credits;

    private void Awake()
    {
        if (instance2 == null)
        {
            instance2 = this; //set instance to this object
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
        TitleCard = GetComponent<Text>();
        Credits = GetComponent<Text>();
        StartGame = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGameScene()
    {
        SceneManager.LoadScene(1);
    }

}
