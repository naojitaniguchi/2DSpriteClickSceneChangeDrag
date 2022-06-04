using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteClickActivate : MonoBehaviour
{
    public bool deactiveMyself = false;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        target.SetActive(true);
        if (deactiveMyself)
        {
            gameObject.SetActive(false);
        }
    }
}
