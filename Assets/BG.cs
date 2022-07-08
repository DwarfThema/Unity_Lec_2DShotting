using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    MeshRenderer mr;
    Material mtl;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mtl = mr.materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        mtl.mainTextureOffset += Vector2.up * 0.2f * Time.deltaTime;
        
    }
}
