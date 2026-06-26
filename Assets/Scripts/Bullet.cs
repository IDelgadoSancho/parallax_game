using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 12f;
    [SerializeField] private int damage = 1;

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable target = other.GetComponent<IDamageable>();

        if (target == null)
            return;

        target.TakeDamage(damage);
        Destroy(gameObject);
    }


}