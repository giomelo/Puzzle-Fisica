using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject Particles;
    public GameObject ParticleCoin;
    private void OnTriggerEnter(Collider other) {

        switch(other.tag)
        {
            case "Death":
            Controlador.controlador.AddMortes(1);
            SceneManager.LoadScene("SampleScene");
            break;

            case "Coin":
            Controlador.controlador.AddCoin(1);
            Instantiate(ParticleCoin, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            break;

            case "Door":
            if(!other.transform.GetComponent<Door>().isFree) return;
            Controlador.controlador.Exit();
            break;

            case "Key":
            var door = other.transform.GetComponent<Key>().referencDoor.transform.GetComponent<Door>();
            door.loackDisplay.SetActive(false);
            door.isFree = true;
            Destroy(other.gameObject);
            Particles.GetComponent<ParticleSystem>().Play();
            break;
            
        }
    }
}
