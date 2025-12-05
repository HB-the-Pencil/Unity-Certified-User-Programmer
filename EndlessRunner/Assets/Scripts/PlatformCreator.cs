using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    private GameObject lastCreatedPlatform;

    void Start()
    {
        // Create some platforms to start.
        CreatePlatform(new Vector3(0, 0, 0));
        CreatePlatform(new Vector3(5, 0, 0));
        CreatePlatform(new Vector3(10, 0, 0));
        lastCreatedPlatform = CreatePlatform();

    }

    void Update()
    {
        if (lastCreatedPlatform.transform.position.x < 10)
        {
            lastCreatedPlatform = CreatePlatform();
        }
    }

    GameObject CreatePlatform()
    {
        return Instantiate(platformPrefab, transform.position, Quaternion.identity);
    }

    GameObject CreatePlatform(Vector3 position)
    {
        return Instantiate(platformPrefab, position, Quaternion.identity);
    }

}
