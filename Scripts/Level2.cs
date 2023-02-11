using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    bool isCol;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "LevelEnd")
        {
            isCol = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(isCol == true && Input.GetKeyDown("e"))
        {
            Scene();
        }
    }

        void Scene()
    {
        SceneManager.LoadScene("Scene-2");
    }
}
