using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizMenu : MonoBehaviour {

	public void AnimalsQuizBtn()
    {
        SceneManager.LoadScene("QuizAnimals");

    }

    public void NumbersQuizBtn()
    {
        SceneManager.LoadScene("QuizNumbers");
    }

    public void HomeBtn()
    {
        SceneManager.LoadScene("Menu");
    }
}
