using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Button_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRestartButtonPressed()
    {
        Debug.Log(message: "Restart Button was Pressed");
        SceneManager.LoadScene("Play");
    }
}
