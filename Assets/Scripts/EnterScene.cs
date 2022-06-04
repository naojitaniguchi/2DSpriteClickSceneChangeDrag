using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScene : MonoBehaviour
{
    public int sceneIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        if ( sceneIndex < GlobalSceneEntryCounter.SceneEntryCounter.sceneNum)
        {
            GlobalSceneEntryCounter.SceneEntryCounter.sceneCounter[sceneIndex]++;
            // GlobalSceneEntryCounter.SceneEntryCounter.CountLog();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
