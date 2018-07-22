using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//This class controls nagivation between screens by adding actions to the buttons
public class MainMenu : MonoBehaviour {
    
    // This method will simply load the learning screen once the Learn Button is clicked.
	public void LearnBtn()
    {
        SceneManager.LoadScene("LearnMenu");
    }
    //This method will simply load the matching screen once the Match Button is clicked.
    public void MatchBtn()
    {
        SceneManager.LoadScene("MatchMenu");
    }
    // This method will simply load the quizzing screen once the Quiz Button is loaded.
    public void QuizBtn()
    {
        SceneManager.LoadScene("QuizMenu");
    }	
}
