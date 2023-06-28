using UnityEngine;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{
    public GameObject LevelSelection;
    public Button buttonPlay;
   /// <summary>
   /// Awake is called when the script instance is being loaded.
   /// </summary>
   private void Awake()
   {
    buttonPlay.onClick.AddListener(PlayButton);
   }
    private void PlayButton()
    
    {
        LevelSelection.SetActive(true);
    }

    public void ExitButton() 
    {
        Application.Quit();
        Debug.Log("Game is exiting");
 
 }
}
