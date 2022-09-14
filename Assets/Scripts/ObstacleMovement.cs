using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(-19.5f, -1.5f, 0);
        transform.Rotate(0, 0, 180, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
