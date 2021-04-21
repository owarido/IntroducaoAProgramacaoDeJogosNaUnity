using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour {
    
    [System.Serializable]
    public class Orc {
        public string nome; 
        public int forca;
        public int dano;
    }

    public List<Orc> orcs = new List<Orc>();

    void Start() {
        
        Orc orc1 = new Orc();
        orc1.nome = "Duratan";
        orc1.forca = 10;
        orc1.dano = 20;

        Orc orc2 = new Orc();
        orc2.nome = "Dotraki";
        orc2.forca = 20;
        orc2.dano = 230;

        orcs.Add(orc1);
        orcs.Add(orc2);

        orcs.Remove(orc2);

    }

}
