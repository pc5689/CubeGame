using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;      // 프리팹
    public float spawnDelay = 1.5f;   // 생성 간격
    public float minY = 1.2f;         // 최소 높이
    public float maxY = 2.5f;         // 최대 높이

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    System.Collections.IEnumerator SpawnLoop()
    {
        while (true)
        {
            float y = Random.Range(minY, maxY);
            Instantiate(obstacle, new Vector3(10, y, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
