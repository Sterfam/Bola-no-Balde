using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public static GameM Inst {get; private set;}
    public float EixoX = 10;
    [HideInInspector]
    public int Placar = 0;
    [HideInInspector]
    public bool ativo = true;
    void Awake() {
        if(Inst != null && Inst != this) {
            Destroy(this);
        } else {
            Inst = this;
        }
    }
}
