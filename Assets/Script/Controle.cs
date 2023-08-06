using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balde : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameM.Inst.ativo) {
            return;
        }
        bool PresL = Input.GetKey(KeyCode.LeftArrow);
        bool PresR = Input.GetKey(KeyCode.RightArrow);

        if(PresL == PresR) {
            return;
        }

        float Mov = speed * Time.deltaTime;
        if(PresL) {
            Mov *=-1f;
        }
        transform.position += new Vector3(Mov, 0, 0);
        float MovLim = GameM.Inst.EixoX / 2;
        if(transform.position.x < -MovLim) {
            transform.position = new Vector3(-MovLim, transform.position.y, transform.position.z);
        } else if (transform.position.x > MovLim) {
            transform.position = new Vector3(MovLim, transform.position.y, transform.position.z);
        }
    }
}
