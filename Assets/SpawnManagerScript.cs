using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject[] SpawnPrefab;
    GameObject referenceObject;
    private float leftEdge;
    private float rightEdge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This gets the Main Camera from the Scene
        referenceObject = GameObject.Find("Ground");
        SpawnRangeByScale(out leftEdge, out rightEdge);
        InvokeRepeating(nameof(Spawn), 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRangeByScale(out float leftX, out float rightX)
    {
        var groundTransform = referenceObject.transform;
        var groundScale = groundTransform.localScale;
        leftX = groundTransform.position.x - groundScale.x / 2;
        rightX = groundTransform.position.x + groundScale.x / 2;
    }

    void Spawn()
    {
        float spawnX = Random.Range(leftEdge, rightEdge);
        float spawnProbability = Random.Range(0, 100);
        int spawnObjectIndex = 0;
        if (spawnProbability < 30)
        {
            spawnObjectIndex = 1;
        }
        Instantiate(SpawnPrefab[spawnObjectIndex], new Vector3(spawnX, 50, 0), transform.rotation);
    }
}
