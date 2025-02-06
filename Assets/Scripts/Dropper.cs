using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeSinceLastSceneLoadInSecondsRounded = 0;
    [SerializeField] float timeBeforeLastSceneLoad = 0f;
    [SerializeField] int delayBeforeDroppingInSeconds = 3;
    [SerializeField] bool isDropped = false;

    MeshRenderer meshRenderer;
    Rigidbody rigidbody;

    void Awake()
    {
        ResetDependencies();

        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start");

        ResetState();
    }

    void Update()
    {
        UpdateTimer();
        DropObstacle();
    }

    void ResetDependencies()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void ResetState()
    {
        timeBeforeLastSceneLoad = Time.time;
    }

    void UpdateTimer()
    {
        float timeSinceApplicationStarted = Time.time;
        float timeSinceLastSceneLoad = timeSinceApplicationStarted - timeBeforeLastSceneLoad;
        if (timeSinceLastSceneLoad > timeSinceLastSceneLoadInSecondsRounded + 1)
        {
            timeSinceLastSceneLoadInSecondsRounded = Mathf.RoundToInt(timeSinceLastSceneLoad);
        }
    }

    void DropObstacle()
    {
        if (!isDropped && timeSinceLastSceneLoadInSecondsRounded >= delayBeforeDroppingInSeconds)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
            isDropped = true;
        }
    }

}
