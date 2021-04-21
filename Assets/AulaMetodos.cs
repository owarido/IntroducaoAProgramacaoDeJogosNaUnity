using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaMetodos : MonoBehaviour {

    public int vida;

    // Start is called before the first frame update
    void Start() {

        AumentarVida();
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.D))
            Atacar(100);
    }

    public void Atacar(int vida) {
        this.vida += vida;
        Debug.Log(vida);
    }

    public void Movimentar() {

    }

    void Defender() {

    }

    int AumentarVida() {
        this.vida = 10;
        return vida;
    }

}
