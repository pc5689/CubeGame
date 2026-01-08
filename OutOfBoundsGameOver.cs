using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBoundsGameOver : MonoBehaviour
{
    void Update()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        // 화면 밖으로 벗어나면
        if (viewPos.y < -0.1f || viewPos.y > 1.1f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
