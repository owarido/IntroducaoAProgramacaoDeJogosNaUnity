using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaIf : MonoBehaviour {

    // Start is called before the first frame update
    void Start() {
        
        if(9 > 9) {
            Debug.Log("Condição Verdadeira!");
        } else if(7 > 9) {
            Debug.Log("Condição Verdadeira!");
        } else {
            Debug.Log("Condição Falsa!");
        }

    }

    // Update is called once per frame
    void Update() {
        
    }
}
