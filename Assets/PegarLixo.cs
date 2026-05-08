using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarLixo : MonoBehaviour
{   
    public AudioSource source; 
    public LixoSpawnerController lixoSpawnerController;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            source.Play();
            Destroy(collision.gameObject);
            lixoSpawnerController.AddToPoints(1);
        }
    }
}
