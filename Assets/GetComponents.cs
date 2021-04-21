using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour {

    private BoxCollider box;
    private Personagem player;

    public GameObject persona;

    // Start is called before the first frame update
    void Start() {

        box = GetComponent<BoxCollider>();
        box.isTrigger = true;
        box.size = new Vector3(10, 10);

        player = persona.GetComponent<Personagem>();
        player.vida = 30;
        player.tipo = "Guerreiro";

    }

    // Update is called once per frame
    void Update() {
        
    }
}
