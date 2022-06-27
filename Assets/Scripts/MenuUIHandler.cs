using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{


    public TextMeshProUGUI bestScore;

    [SerializeField] Text playerNameInput;



    public void DisplayPlayerName()
    {

        GameManager.Instance.playerName = playerNameInput.text;
    
    }

    public void StartButtonClicked()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitButtonClicked()
    {
#if UNITY_EDITOR

        EditorApplication.ExitPlaymode();

#else
        Application.Quit();

#endif
    }

   
}
