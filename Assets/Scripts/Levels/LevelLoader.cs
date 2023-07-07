using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AimingRig.Assets.Scripts.Levels
{
    [RequireComponent(typeof(Button))]
     public class LevelLoader : MonoBehaviour
    {
        private Button button;
        public string LevelName;
        
        private void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClick);
            
        }

        private void OnClick()
        {
            LevelStatus levelStatus = LevelManager.Instance.GetLevelStatus(LevelName);
            switch(levelStatus)
            {
                case LevelStatus.Locked:
                     Debug.Log("Can't Play this LEVEL ! The Level is LOCKED ");
                     break;

                case LevelStatus.Unlocked:
                    SceneManager.LoadScene(LevelName);
                    
                    break;

                case LevelStatus.Completed:
                     SceneManager.LoadScene(LevelName);
                break;
            }
            
        }
    }
}
