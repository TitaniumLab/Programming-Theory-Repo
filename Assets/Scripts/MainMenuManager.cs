using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private Button playButton;
    [SerializeField]
    private TMP_InputField nameInputField;


    //disable play button if input field is empty
    public void DisablePlayButton()
    {
        if (nameInputField.text.Length > 0)
        {
            playButton.interactable = true;
        }
        else
            playButton.interactable = false;
    }

    //load main game scene
    public void LoadMainOnClick()
    {
        DataManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene("Main");
    }

    //close application
    public void ExitMainOnClick()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else 
        Application.Quit();
#endif
    }
}
