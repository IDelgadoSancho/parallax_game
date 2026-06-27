using UnityEngine;

public class BasicProjectile : MonoBehaviour
{
    [SerializeField] private float speed = 12f;

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}