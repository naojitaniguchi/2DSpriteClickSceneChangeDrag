using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
           // Debug.Log(GlobalSceneEntryCounter.SceneEntryCounter.test);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            //GlobalSceneEntryCounter.SceneEntryCounter.test++;
            //Debug.Log(GlobalSceneEntryCounter.SceneEntryCounter.test);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            //GlobalSceneEntryCounter.SceneEntryCounter.test--;
            //Debug.Log(GlobalSceneEntryCounter.SceneEntryCounter.test);
        }
    }
}
