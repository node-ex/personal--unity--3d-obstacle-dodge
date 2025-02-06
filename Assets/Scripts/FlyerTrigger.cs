using UnityEngine;

public class FlyerTrigger : MonoBehaviour
{
    [SerializeField] bool wasTriggered = false;
    Flyer[] flyers;

    void Awake()
    {
        flyers = FindObjectsByType<Flyer>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        Debug.Log("FlyerTrigger: Awake - found " + flyers.Length + " flyers");
    }

    void OnTriggerEnter(Collider collision)
    {
        if (!wasTriggered && collision.gameObject.CompareTag("Player"))
        {
            wasTriggered = true;
            Debug.Log("Player collided with a trigger");
            foreach (Flyer flyer in flyers)
            {
                flyer.gameObject.SetActive(true);
            }
        }
    }
}
