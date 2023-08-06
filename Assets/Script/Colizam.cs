using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colizam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision outro)
    {
        if(!GameM.Inst.ativo) {
            return;
        }
        if(outro.gameObject.CompareTag("Bola")) {
            GameM.Inst.Placar++;
            Debug.Log("Placar: " + GameM.Inst.Placar);
            Destroy(outro.gameObject);
        }
    }
}
