using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        surfaceEffector2D = GetComponent<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
