using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        {
            SceneManager.LoadScene(6);
        }
    }
}
