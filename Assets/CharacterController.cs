using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] Camera arCamera;
    public float camYPos = 0;
    private GameObject target = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(arCamera.transform.position.x, camYPos, arCamera.transform.position.z);
        Quaternion rot = arCamera.transform.rotation;
        Vector3 scale = new Vector3(arCamera.transform.localScale.x, arCamera.transform.localScale.y, arCamera.transform.localScale.z);
        if(target == null)
            target = new GameObject();
        target.transform.position = pos;
        target.transform.rotation = rot;
        target.transform.localScale = scale;
        transform.LookAt(target.transform, Vector3.up);


    }
}
