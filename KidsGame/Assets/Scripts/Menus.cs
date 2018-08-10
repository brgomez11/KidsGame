using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//This class controls nagivation between screens by adding actions to the buttons
public class Menus : MonoBehaviour {
    
    //This method will simply load the screen for users to learn about different animals once the Animals button is clicked. 
    public void LearnAnimalsBtn()
    {
        SceneManager.LoadScene("LearnAnimals");
    }
    //This method will simply load the screen for users to learn about different animals once the Numbers button is clicked. 
    public void LearnNumbersBtn()
    {
        SceneManager.LoadScene("LearnNumbers");
    }
    //The method will simply load the main menu screen once clicked.
    public void HomeBtn()
    {
        SceneManager.LoadScene("Menu");
    }
    //This method simply loads the screen to match animals 
    public void MatchAnimalsBtn()
    {
        SceneManager.LoadScene("MatchAnimals");
    }
    //This method simply loads the screen to match  numbers
    public void MatchNumbersBtn()
    {
        SceneManager.LoadScene("MatchNumbers");
    }
    //This method simply loads screen to be quizzed on animals
    public void AnimalsQuizBtn()
    {
        SceneManager.LoadScene("QuizAnimals");
    }
    //This method simply loads screen to be quizzed on numbers.
    public void NumbersQuizBtn()
    {
        SceneManager.LoadScene("QuizNumbers");
    }
}
