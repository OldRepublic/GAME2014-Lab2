using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Event handler for the start_Button_Pressed Event
    public void OnStartButtonPressed()
    {
        Debug.Log(message:"StartButton was Pressed");
        SceneManager.LoadScene("Play");
    }
}
