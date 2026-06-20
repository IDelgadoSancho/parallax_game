using UnityEngine;

public class SimpleLayerMove : MonoBehaviour
{
    [SerializeField] private WorldScroller world;
    [SerializeField] private float multiplier = 1f;

    private void Update()
    {
        transform.position += Vector3.left * world.GlobalSpeed * multiplier * Time.deltaTime;
    }
}
