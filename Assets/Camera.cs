using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PlayerPos;
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerPos.position.x,transform.position.y,PlayerPos.position.z - 2);
    }
}
