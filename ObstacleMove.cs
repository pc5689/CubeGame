using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * 5f * Time.deltaTime);

        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
