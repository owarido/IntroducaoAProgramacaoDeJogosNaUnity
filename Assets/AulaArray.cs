using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaArray : MonoBehaviour {

    public int[] numeros = {1, 2, 3};
    public int[] outrosNumeros;

    // Start is called before the first frame update
    void Start() {
        
        outrosNumeros = new int[3];
        
        for(int i = 0; i < numeros.Length; i++)
            outrosNumeros[i] = numeros[i];

        foreach(int indice in outrosNumeros) {
            Debug.Log(indice);
        }

    }

    // Update is called once per frame
    void Update() {
        
    }
}