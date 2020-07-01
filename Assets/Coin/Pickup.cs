using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    MeshRenderer[] mrs;

    void Start()
    {
        mrs = this.GetComponentsInChildren<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameData.singleton.UpdateScore(1);
            
            foreach (MeshRenderer m in mrs)
            {
                m.enabled = false;
            }
        }
    }

    void OnEnable()
    {
        if (mrs != null)
            foreach (MeshRenderer m in mrs)
                m.enabled = true;
    }
}
