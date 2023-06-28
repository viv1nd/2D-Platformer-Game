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
            SceneManager.LoadScene(LevelName);
        }
    }
}
