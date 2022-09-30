using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Manager para escena
using UnityEngine.SceneManagement;

public class CambiarSceneWithBtn : MonoBehaviour
{
    //Vacio publico, que sirve para cargar la escena, (llama la escena por el nombre de esta)
    public void LoadScene(string SceneName)
    {
        //funciona dandole esta funcion a un boton y cuando este es presionado llama a la escena seleccionada...
        SceneManager.LoadScene(SceneName);
    }
}
