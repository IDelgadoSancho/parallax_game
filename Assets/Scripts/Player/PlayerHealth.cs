using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health = 3;

    public void TakeDamage(int damage)
    {
        health -= damage;

        Debug.Log("Vida: " + health);

        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
