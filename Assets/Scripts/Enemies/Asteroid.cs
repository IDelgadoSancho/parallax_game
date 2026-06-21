using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>()?.TakeDamage(1);
            Destroy(gameObject);
        }
    }


}
