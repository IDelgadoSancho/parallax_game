using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private GameObject[] segments;

    private void Update()
    {
        int hp = player.CurrentHealth;

        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].SetActive(i < hp);
        }
    }
}
