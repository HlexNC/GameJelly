using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_camera : MonoBehaviour
{
    public GameObject playerObject;
    // Start is called before the first frame update
    void Awake()
    {
        playerObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = playerObject.transform.position + new Vector3(0, 4, -6);
    }
}
