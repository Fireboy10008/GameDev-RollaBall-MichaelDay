using Unity.VisualScripting;
using UnityEngine;

public class WaspSpawner : MonoBehaviour
{
    public GameObject targetObject;
    
    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(true);
    }       
}
