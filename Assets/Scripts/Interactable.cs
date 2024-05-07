using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public int sceneNumber;
    void OnTriggerEnter(Collider other)
    {
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
