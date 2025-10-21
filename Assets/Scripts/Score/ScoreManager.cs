using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public int score = 0;
    public int combo = 1;
    public float comboTimer = 0f;
    public float comboWindow = 3f;

    void Awake()
    {
        if (Instance != null && Instance != this) Destroy(gameObject);
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (comboTimer > 0) comboTimer -= Time.deltaTime;
        else combo = 1;
    }

    public void AddFoodPoints(int points)
    {
        score += Mathf.RoundToInt(points * combo);
        combo = Mathf.Min(5, combo + 1);
        comboTimer = comboWindow;
    }

    public void AddEnemyKill(int count = 1)
    {
        score += 100 * count;
    }

    public void ApplyDamagePenalty(int penalty = 25)
    {
        score = Mathf.Max(0, score - penalty);
    }
}