using UnityEngine;

public class WorldScroller : MonoBehaviour
{
    public float baseSpeed = 5f;

    public float GlobalSpeed => baseSpeed + (RunManager.Instance.currentStage * 0.5f);

    float lastLoggedSpeed;

    void Update()
    {
        if (RunManager.Instance.CurrentPhase != RunManager.Phase.Playing)
            return;

        float speed = GlobalSpeed;

        if (Mathf.Abs(speed - lastLoggedSpeed) > 0.1f)
        {
            Debug.Log($"[WORLD] Stage: {RunManager.Instance.currentStage} | Speed: {speed:F2}");
            lastLoggedSpeed = speed;
        }
    }

}
