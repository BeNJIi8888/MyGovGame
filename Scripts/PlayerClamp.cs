using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClamp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zPos = Mathf.Clamp(transform.position.y, 0f, 0f);
        transform.position = new Vector3(transform.position.x, transform.position.y, zPos);
    }
}
