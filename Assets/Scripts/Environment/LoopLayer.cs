using UnityEngine;

public class LoopLayer : MonoBehaviour
{
    [SerializeField] private WorldScroller world;
    [SerializeField] private float multiplier = 1f;

    private Transform tileA;
    private Transform tileB;

    private float width;

    private void Start()
    {
        tileA = transform.GetChild(0);
        tileB = transform.GetChild(1);

        width = tileA.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        float movement = world.GlobalSpeed * multiplier * Time.deltaTime;

        tileA.position += Vector3.left * movement;
        tileB.position += Vector3.left * movement;

        if (tileA.position.x <= -width)
        {
            tileA.position = tileB.position + Vector3.right * width;
            Swap();
        }
        else if (tileB.position.x <= -width)
        {
            tileB.position = tileA.position + Vector3.right * width;
            Swap();
        }
    }

    private void Swap()
    {
        (tileA, tileB) = (tileB, tileA);
    }
}