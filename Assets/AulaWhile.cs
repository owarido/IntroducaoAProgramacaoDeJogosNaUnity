using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaWhile : MonoBehaviour {

    int moedas = 100;

    // Start is called before the first frame update
    void Start() {
        
        /*while(moedas < 1000) {
            Debug.Log("Sua quantidade de moedas é: " + moedas);
            moedas += 100;
        }*/

        do {
            Debug.Log("Sua quantidade de moedas é: " + moedas);
            moedas += 100;
        } while(moedas < 1000);

    }

    // Update is called once per frame
    void Update() {
        
    }
}
