using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchMenu : MonoBehaviour {

	public void MatchAnimalsBtn()
    {
        SceneManager.LoadScene("MatchAnimals");
    }

    public void MatchNumbersBtn()
    {
        SceneManager.LoadScene("MatchNumbers");
    }

    public void HomeBtn()
    {
        SceneManager.LoadScene("Menu");
    }
}
