using UnityEngine;

public class Asteroid : MonoBehaviour, IDamageable
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int hp = 3;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void TakeDamage(int amount)
    {
        hp -= amount;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>()?.TakeDamage(1);
            Destroy(gameObject);
        }
    }
}