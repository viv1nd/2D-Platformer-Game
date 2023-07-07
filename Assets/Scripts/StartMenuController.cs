using UnityEngine;
using UnityEngine.UI;
using System;

public class StartMenuController : MonoBehaviour
{
    public GameObject LevelSelection;
    public Button buttonPlay;
    private static bool firstTimeGame = true;
   /// <summary>
   /// Awake is called when the script instance is being loaded.
   /// </summary>
   private void Awake()
   {
        buttonPlay.onClick.AddListener(PlayButton);
        if(firstTimeGame == false)
        {
            PlayButton();
        }
   }
    public void PlayButton()
    {
       
        firstTimeGame = false;
        LevelSelection.SetActive(true);
    }

    public void ExitButton() 
    {
        Application.Quit();
        Debug.Log("Game is exiting");
 
    }
}
