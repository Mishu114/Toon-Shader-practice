using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleControl : MonoBehaviour
{
    Material material;
    // Start is called before the first frame update
    void Start()
    {
        //material = GetComponent<MeshRenderer>().sharedMaterial;
        material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        Vector3 pos = other.gameObject.transform.position;

        float scaleX = transform.localScale.x;
        float scaleZ = transform.localScale.z;

        float x = 0.5f + ((0.5f * (this.transform.position.x - pos.x)) / (5.0f * scaleX));
        float z = 0.5f + ((0.5f * (this.transform.position.z - pos.z)) / (5.0f * scaleZ));

        material.SetFloat("_RipplePosX", x);
        material.SetFloat("_RipplePosY", z);
        material.SetFloat("_RippleON", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        material.SetFloat("_RippleON",0);
    }
}
