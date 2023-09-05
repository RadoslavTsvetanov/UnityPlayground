using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject TargetToBeFollowed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(TargetToBeFollowed.transform.position.x, transform.position.y, transform.position.z);
    }
}
