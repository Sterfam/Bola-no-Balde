using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odio : MonoBehaviour
{

    public float Speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        string name = gameObject.name;
        Debug.Log("Delicia " + name + " with speed: " + Speed);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, Speed * Time.deltaTime);
    }
}
