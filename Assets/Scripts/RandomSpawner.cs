using UnityEngine;
using System.Collections.Generic;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public int numberToSpawn = 50;
    public Vector3 areaSize = new Vector3(10, 5, 10);
    public Transform target;  // ← The object all prefabs will look at

    private List<Transform> spawnedObjects = new List<Transform>();

    void Start()
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            Vector3 randomPosition = GetRandomPosition();
            GameObject obj = Instantiate(prefabToSpawn, randomPosition, Quaternion.identity, transform);
            spawnedObjects.Add(obj.transform);
        }
    }

    void Update()
    {
        if (target == null) return;

        foreach (Transform obj in spawnedObjects)
        {
            obj.LookAt(target);
        }
    }

    Vector3 GetRandomPosition()
    {
        Vector3 center = transform.position;
        float x = Random.Range(-areaSize.x / 2f, areaSize.x / 2f);
        float y = Random.Range(-areaSize.y / 2f, areaSize.y / 2f);
        float z = Random.Range(-areaSize.z / 2f, areaSize.z / 2f);
        return center + new Vector3(x, y, z);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, areaSize);
    }
}
