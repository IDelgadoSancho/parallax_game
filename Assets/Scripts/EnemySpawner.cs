using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float minY = -4f;
    [SerializeField] private float maxY = 4f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

            Vector3 spawnPos = transform.position;
            spawnPos.y = Random.Range(minY, maxY);

            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }


}
