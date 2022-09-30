using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class verOrientacion : MonoBehaviour
{
    public GameObject verticar;
    public GameObject horizondar;
    public int inicio;
    bool entrada = false;
    //public TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {
        if (!entrada)
        {
            activador(verticar);
            entrada = true;
        }
    }
    private void Update()
    {
        if (Screen.orientation == ScreenOrientation.Portrait)
        {

            activador(verticar);
            //texto.text = "vertical";
        }

        else
        {
            activador(horizondar);
            //texto.text = "horizontal";
        }
        
    }
    void posicionactual()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                activador(verticar);
                break;
            case ScreenOrientation.LandscapeRight:
                activador(horizondar);
                break;
            case ScreenOrientation.LandscapeLeft:
                
                break;
            default:
                
                break;
        }
    }
   public void activador(GameObject avivador)
    {
        verticar.gameObject.SetActive(false);
        horizondar.gameObject.SetActive(false);
        avivador.gameObject.SetActive(true);
    }
}
