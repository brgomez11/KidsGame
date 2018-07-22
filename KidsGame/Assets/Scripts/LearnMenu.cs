using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LearnMenu : MonoBehaviour {


    public void AnimalsBtn()
    {
        SceneManager.LoadScene("LearnAnimals");
    }
    
    public void NumbersBtn()
    {
        SceneManager.LoadScene("LearnNumbers");
    }

    public void HomeBtn()
    {
        SceneManager.LoadScene("Menu");
    }
}
