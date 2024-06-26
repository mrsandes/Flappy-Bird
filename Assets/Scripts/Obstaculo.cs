using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float variacaoDaPosicaoY;

    private void Awake() {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }   

    void Update() {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        this.Destruir();
    }

    public void Destruir() {
        GameObject.Destroy(this.gameObject);
    }
}
