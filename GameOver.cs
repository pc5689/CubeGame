using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Contains("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
