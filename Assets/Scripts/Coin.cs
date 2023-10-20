using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private AudioSource coinSound;

    // Use this for initialization
    void Start () {
        // Encuentra el objeto CoinSound en la escena
        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Coleccionable"))
        {
            // Reproduce el sonido de la moneda cuando el jugador la recolecta
            coinSound.Play();
            // Aquí puedes agregar lógica adicional para sumar puntos, desactivar la moneda, etc.
            //gameObject.SetActive(false);
        }
    }
}
