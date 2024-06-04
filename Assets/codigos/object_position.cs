using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("_object_position", new Vector4(this.transform.position.x, this.transform.position.y, this.transform.position.z));
    }
}
