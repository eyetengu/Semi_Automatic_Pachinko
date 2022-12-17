using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public int cameraID;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject urbanImage;

    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        urbanImage.SetActive(false);
    }

    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            cameraID++;
            if (cameraID > 1)
                cameraID = 0;

            switch(cameraID)
            {
                case 0:
                    cam1.SetActive(true);
                    cam2.SetActive(false);
                    urbanImage.SetActive(false);
                break;
                case 1:
                    cam1.SetActive(false);
                    cam2.SetActive(true);
                    urbanImage.SetActive(true);
                break;
                default:
                    break;
            }
        }
    }
}
