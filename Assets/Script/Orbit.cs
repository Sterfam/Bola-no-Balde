using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject reference;

    public Vector2 frequency;
    public Vector2 distancy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var sin = Mathf.Sin(Time.time * frequency.x) * distancy.x;
        var cos = Mathf.Cos(Time.time * frequency.y) * distancy.y;
        var referencePosition = reference.transform.position;
        transform.position = referencePosition + new Vector3(sin, cos, 0);



    }
}