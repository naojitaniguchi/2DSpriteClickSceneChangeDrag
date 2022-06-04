using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpriteDrag : MonoBehaviour
{
    public bool deavtivateOnBox = true;
    bool isDraging;
    bool onBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDraging)
        {
            Vector2 mouthPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mouthPosition);
        }
    }
    public void OnMouseDown()
    {
        isDraging = true;
    }

    public void OnMouseUp()
    {
        isDraging = false;

        if (deavtivateOnBox)
        {
            if (onBox)
            {
                gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.gameObject.tag == "Box")
        {
            onBox = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            onBox = false;
        }
    }
}
