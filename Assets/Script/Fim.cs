using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision outro) {
        if(!GameM.Inst.ativo) {
            return;
        }
        if(outro.gameObject.CompareTag("Bola")) {
            Debug.Log("Fim DE JOGO!");
            Destroy(outro.gameObject);
            GameM.Inst.ativo = false;
        }
    }
}
