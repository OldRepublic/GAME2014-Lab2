﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Event Handler for the back button pressed event
    public void OnBackButtonPressed()
    {
        Debug.Log(message: "Back Button was Pressed");
        SceneManager.LoadScene("Start");
    }
}
