using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaSpaw : MonoBehaviour
{
    public List<GameObject> prefab;
    public Vector3 OrigP = new Vector3(0, 0, 0);
    public  float Intervalo = 1;
    private float Cooldown = 0;
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
        Cooldown -= Time.deltaTime;
        if(Cooldown <= 0f) {
            Cooldown = Intervalo;
            SpawnBola();
        }
    }
    private void SpawnBola() {
        int prefabsIndex = Random.Range(0, prefab.Count);
        GameObject prefabs = prefab[prefabsIndex];
        float EixoX = GameM.Inst.EixoX;
        float xOffset = Random.Range(-EixoX / 2f, EixoX / 2f);
        Vector3 Posição = OrigP + new Vector3(xOffset, 0, 0);
        Quaternion Rotação = prefabs.transform.rotation;

        Instantiate(prefabs, Posição, Rotação);
    }
}
