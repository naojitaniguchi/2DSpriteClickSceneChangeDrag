using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DispSceneCountToTMP : MonoBehaviour
{
    public GameObject textObj;
    // Start is called before the first frame update
    void Start()
    {
        dispCount();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            dispCount();
        }
    }

    void dispCount()
    {
        string dispStr = "";

        for ( int i = 0; i < GlobalSceneEntryCounter.SceneEntryCounter.sceneNum; i ++)
        {
            string str = i.ToString() + ":";
            str += GlobalSceneEntryCounter.SceneEntryCounter.sceneCounter[i].ToString();
            str += "\n";
            dispStr += str;
        }

        textObj.GetComponent<TMP_Text>().text = dispStr;

    }
}
