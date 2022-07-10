using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCotroller : MonoBehaviour
{
    [SerializeField]
    private Transform mPlayerTransform;
    private Vector3 mOffset;
   
    void Start()
    {
        mOffset = transform.position - mPlayerTransform.position;
    }

    void Update()
    {
        transform.position = mOffset + mPlayerTransform.position; 
    }
}
