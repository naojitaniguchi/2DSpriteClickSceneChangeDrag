using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBySceneCount : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] countConditions;
    public GameObject target;

    void Start()
    {
        activateTarget();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void activateTarget()
    {
        int okCount = 0;

        for ( int i = 0; i < countConditions.Length; i ++)
        {
            if ( i < GlobalSceneEntryCounter.SceneEntryCounter.sceneNum)
            {
                // Debug.Log(GlobalSceneEntryCounter.SceneEntryCounter.sceneCounter[i]);
                if ( GlobalSceneEntryCounter.SceneEntryCounter.sceneCounter[i] >= countConditions[i])
                {
                    okCount++;
                }
            }
        }

        //Debug.Log("okCount");
        //Debug.Log(okCount);

        if ( okCount == countConditions.Length)
        {
            target.SetActive(true);
        }
        else
        {
            target.SetActive(false);
        }
    }
}
