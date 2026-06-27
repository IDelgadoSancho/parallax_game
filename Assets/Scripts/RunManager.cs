using UnityEngine;
using System;

public class RunManager : MonoBehaviour
{
    public static RunManager Instance;

    public enum Phase
    {
        Playing,
        Boss,
        End
    }

    public Phase CurrentPhase;

    [Header("Run config")]
    public int currentStage = 1;
    public int totalStages = 5;
    public float stageDuration = 25f;

    float timer;

    public event Action<int> OnStageChanged;
    public event Action OnBossStart;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        StartRun();
    }

    void Update()
    {
        if (CurrentPhase != Phase.Playing)
            return;

        timer += Time.deltaTime;

        if (Time.frameCount % 60 == 0)
        {
            //Debug.Log($"[RUN] Stage: {currentStage} | Time: {timer:F1}/{stageDuration} | Phase: {CurrentPhase}");
        }

        if (timer >= stageDuration)
        {
            AdvanceStage();
        }
    }

    void StartRun()
    {
        currentStage = 1;
        timer = 0;
        CurrentPhase = Phase.Playing;

        //Debug.Log("[RUN] START");
        Debug.Log($"[RUN] Stage {currentStage} started");

        OnStageChanged?.Invoke(currentStage);
    }

    void AdvanceStage()
    {
        timer = 0;
        currentStage++;

        Debug.Log($"[RUN] ADVANCE → Stage {currentStage}");

        if (currentStage > totalStages)
        {
            StartBoss();
            return;
        }

        OnStageChanged?.Invoke(currentStage);
    }

    void StartBoss()
    {
        CurrentPhase = Phase.Boss;

        Debug.Log("[RUN] BOSS START");
        OnBossStart?.Invoke();
    }
}