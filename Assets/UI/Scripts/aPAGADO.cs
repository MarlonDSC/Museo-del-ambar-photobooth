using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aPAGADO : MonoBehaviour
{
    public GameObject apagar1;
    public GameObject apagar2;




    // Start is called before the first frame update
    void Start()
    {
        Screen.autorotateToPortrait = true;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.autorotateToPortraitUpsideDown = false;
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.touchCount == 1)
        {

            Touch dedo = Input.GetTouch(0);

            if (dedo.phase == TouchPhase.Began)
            {

                apagar1.SetActive(false);
                apagar2.SetActive(false);

            }


        }
        



    }
}
