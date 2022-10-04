using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoSegunRotacion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FondoVerticar;
    public GameObject FondoHorizontar;
    private bool OrientacionVerticar;

    private void Start()
    {
        activador(FondoVerticar);
    }
    public void cambiarforma()
    {
        if (OrientacionVerticar)
        {
            activador(FondoVerticar);
            OrientacionVerticar = false;
            Screen.orientation = ScreenOrientation.Portrait;
        }
        else
        {
            activador(FondoHorizontar);
             OrientacionVerticar = true;
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }

    private void activador(GameObject x)
    {
        FondoVerticar.SetActive(false);
        FondoHorizontar.SetActive(false);
        x.SetActive(true);
    }
}
