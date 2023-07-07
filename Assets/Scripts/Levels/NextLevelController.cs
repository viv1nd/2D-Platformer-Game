using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>()!= null)
        {
            Debug.Log("Level Finished !!!!");
            LevelManager.Instance.MarkLevelFinsihed();

        }
    }
}
