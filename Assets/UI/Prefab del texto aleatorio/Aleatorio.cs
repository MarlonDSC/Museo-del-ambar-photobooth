using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{
    public Transform pos;


    // luego de crear el publico "GameObject
    // El corchete que abri es para indicar que es una Array por lo cual puedo instancear varios objetos
    public GameObject[] objectsToInstantiate;

    // Start is called before the first frame update
    void Start()
    {

        // llamamos un numero aleatorio dentro de la Array que sera igual 
        //a la cantidad de 0, la cantidad de Elementos Creados
        int n = Random.Range(0, objectsToInstantiate.Length);

        GameObject g = Instantiate(objectsToInstantiate[n], pos.position, objectsToInstantiate[n].transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
