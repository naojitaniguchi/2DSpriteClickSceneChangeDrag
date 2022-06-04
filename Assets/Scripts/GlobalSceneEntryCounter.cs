using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSceneEntryCounter : MonoBehaviour
{
    public static GlobalSceneEntryCounter SceneEntryCounter;

    // Start is called before the first frame update
    public List<int> sceneCounter;
    public int sceneNum;

    public int test = 3;

    private void Awake()
    {
         // If Instance is not null (any time after the first time)
         // AND
         // If Instance is not 'this' (after the first time)
         if (SceneEntryCounter != null && SceneEntryCounter != this)
         {
             // ...then destroy the game object this script component is attached to.
             Destroy(gameObject);
         }
         else
         {
             // Tell Unity not to destory the GameObject this
             //  is attached to between scenes.
             DontDestroyOnLoad(gameObject);
            // Save an internal reference to the first instance of this class
            SceneEntryCounter = this;
            sceneCounter = new List<int>();
            for (int i = 0; i < sceneNum; i ++)
            {
                sceneCounter.Add(0);
            }
         }
    }

    public void CountLog()
    {
        for (int i = 0; i < sceneNum; i++)
        {
            Debug.Log(sceneCounter[i]);
        }
    }
}
