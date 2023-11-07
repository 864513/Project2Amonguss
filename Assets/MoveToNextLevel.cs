using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveToNextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string currentSceneName = currentScene.name;
            if (currentSceneName != "8 HIT RESTART")
            {
                // Get the build index of the next scene
                int nextSceneBuildIndex = currentScene.buildIndex + 1;
                // Load the next scene
                SceneManager.LoadScene(nextSceneBuildIndex);
            }
            else
            {
                // Load the first scene by its build index (0)
                SceneManager.LoadScene("1 THE START");
            }
        }
    }
}