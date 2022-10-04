using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoSegunRotacion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject verticar;
    public GameObject horizontar;

    // Update is called once per frame
    private void Start()
    {
        activador(verticar);
    }
    void Update()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                activador(verticar);
                break;
            case ScreenOrientation.LandscapeRight:
                activador(horizontar);
                break;
            case ScreenOrientation.LandscapeLeft:
                activador(horizontar);
                break;
            default:

                break;
        }
    }

    private void activador(GameObject x)
    {
        verticar.SetActive(false);
        horizontar.SetActive(false);
        x.SetActive(true);
    }
}
