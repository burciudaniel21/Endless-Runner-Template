using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    public GameObject groundSection;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnTrigger"))
        {
            Instantiate(groundSection, other.transform.position + new Vector3(-10, 0, 0), Quaternion.identity);
        }

        if (other.gameObject.CompareTag("DeleteTrigger"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }
}
