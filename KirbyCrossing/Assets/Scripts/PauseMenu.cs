using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// using Microsoft.MixedReality.Toolkit;
// using Microsoft.MixedReality.Toolkit.SceneSystem;

public class PauseMenu : MonoBehaviour
{
    // public IMixedRealitySceneSystem sceneSystem;

    // Start is called before the first frame update
    void Start()
    {
        // sceneSystem = MixedRealityToolkit.Instance.GetService<IMixedRealitySceneSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // UnloadCurrentScene();
            SceneManager.LoadScene("Menu");
        }
    }

    public async void UnloadCurrentScene()
    {
        // await sceneSystem.UnloadContent("Flood");
    }
}
