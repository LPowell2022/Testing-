using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
        void OnTriggerEnter(Collider other)
        {
                {
                    SceneManager.LoadScene(7);
                }
        }
}
