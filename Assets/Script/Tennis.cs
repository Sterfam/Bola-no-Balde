using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tennis : MonoBehaviour
{

    private static readonly float Destruir = -10;
    private Rigidbody myRigidbody;
    public Vector2 force = new Vector2(10, 10);

    // Start is called before the first frame update
    void Start()
    {
        var forceAmounty = Random.Range(force.x, force.y);
        var forceAmountX = forceAmounty * Random.Range(-0.05f, 0.05f);
        var forceAmountz = forceAmounty * Random.Range(-0.05f, 0.05f);
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        var forceVector = new Vector3(forceAmountX, forceAmounty, forceAmountz);
        myRigidbody.AddForce(forceVector, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        if(y <= Destruir) {
        Destroy(gameObject);
        }
    }
}
