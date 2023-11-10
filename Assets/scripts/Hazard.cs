using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour{

Vector3 rotation;
void Start()
{
    var xRotation = Random.Range(0.5f, 1f);
    rotation = new Vector3(-xRotation, 0);
}

void Update()
{
    transform.Rotate(rotation);
}

         private void OnCollisionEnter(Collision collision)
        {
        Application.Quit();
        Debug.Log("fim de jogo");
        Destroy(gameObject);
        }

 
}