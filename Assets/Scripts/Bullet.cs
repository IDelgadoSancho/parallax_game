using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 12f;

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
