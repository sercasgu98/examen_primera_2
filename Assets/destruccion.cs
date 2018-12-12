using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class destruccion : MonoBehaviour {
    bool si = false;
    public GameObject objeto;
    private void Update()
    {
        if (si == true)
        {
            Destroy(objeto);
        }
           
    }
    void OnTriggerEnter(Collider other){
        si = true;
    
    }

}
