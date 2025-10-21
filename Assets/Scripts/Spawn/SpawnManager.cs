using UnityEngine;

/// <summary>
/// Simple spawn manager to populate food prefabs in a radius around this object.
/// Replace with procedural spawn rules and caps per area in later sprints.
/// </summary>
public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public float spawnRadius = 50f;
    public int maxFood = 50;

    void Start()
    {
        for (int i = 0; i < maxFood; i++) SpawnFood();
    }

    public void SpawnFood()
    {
        if (foodPrefabs == null || foodPrefabs.Length == 0) return;
        Vector3 pos = transform.position + Random.insideUnitSphere * spawnRadius;
        pos.y = Mathf.Max(0.5f, pos.y); // keep above ground
        int idx = Random.Range(0, foodPrefabs.Length);
        Instantiate(foodPrefabs[idx], pos, Quaternion.identity);
    }
}