using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Text : MonoBehaviour
{
    public Text isText;
    // Start is called before the first frame update
    void Start()
    {
        isText.enabled = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            isText.enabled = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
{
     // Here is where you make the text disappear off screen
      if(collision.gameObject.tag == "Player")
{
        isText.enabled = false; // May need to use .SetActive(false);
}
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
