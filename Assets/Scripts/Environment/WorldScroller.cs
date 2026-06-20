using UnityEngine;

public class WorldScroller : MonoBehaviour
{
    [field: SerializeField]
    public float GlobalSpeed { get; private set; } = 5f;
}
