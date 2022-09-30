using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encendido : MonoBehaviour
{
    public GameObject prende;



    // Start is called before the first frame update
    void Start()
    {
        




    }

    // Update is called once per frame
    void Update()
    {




        if (Input.touchCount == 1)
        {

            Touch dedo = Input.GetTouch(0);

            if (dedo.phase == TouchPhase.Began)
            {
                prende.SetActive(true);


            }

        }



    }
}
