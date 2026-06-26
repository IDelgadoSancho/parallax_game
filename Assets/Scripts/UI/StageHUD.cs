using UnityEngine;
using UnityEngine.UI;

public class StageHUD : MonoBehaviour
{
    public Image[] stageDots;
    public Color completedColor = Color.gray;
    public Color currentColor = Color.white;
    public Color futureColor = Color.black;

    void Start()
    {
        RunManager.Instance.OnStageChanged += UpdateUI;
        UpdateUI(RunManager.Instance.currentStage);
    }

    void OnDestroy()
    {
        if (RunManager.Instance != null)
            RunManager.Instance.OnStageChanged -= UpdateUI;
    }

    void UpdateUI(int currentStage)
    {
        for (int i = 0; i < stageDots.Length; i++)
        {
            int stageIndex = i + 1;

            if (stageIndex < currentStage)
            {
                stageDots[i].color = completedColor;
                stageDots[i].transform.localScale = Vector3.one;
            }
            else if (stageIndex == currentStage)
            {
                stageDots[i].color = currentColor;
                stageDots[i].transform.localScale = Vector3.one * 1.4f;
            }
            else
            {
                stageDots[i].color = futureColor;
                stageDots[i].transform.localScale = Vector3.one * 0.9f;
            }
        }
    }
}