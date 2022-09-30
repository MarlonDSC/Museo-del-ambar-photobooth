using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librerias a usar...
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CargadorEscena : MonoBehaviour
{
    public GameObject PantallaDeCarga;
    public Slider Slidercarga;

    public void Cargarescena(int NumeroDeEscena)
    {
        StartCoroutine(ExampleCoroutine(NumeroDeEscena));
    }
    IEnumerator ExampleCoroutine(int NumeroDeEscena)
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        PantallaDeCarga.SetActive(true);
        yield return new WaitForSeconds(4);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        StartCoroutine(CargarAsync(NumeroDeEscena));
    }
    IEnumerator CargarAsync(int NumeroDeEscena)
    {
        AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);
        while (!Operacion.isDone)
        {
            float progreso = Mathf.Clamp01(Operacion.progress / 0.9f);
            Slidercarga.value = progreso;
            //Debug.Log(progreso);
            //Debug.Log(Operacion.progress);

            yield return null;
        }
    }

}
