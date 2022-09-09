using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCamCamera : MonoBehaviour
{
    //Variable setup
    WebCamTexture camTexture;
    WebCamDevice[] laptopCam;
    public RawImage background;

    private void Start()
    {
        laptopCam = WebCamTexture.devices;

        //For loop in case we want to set it to a phone and use front and back camera, add camera's to array.
        for(int i=0; i< laptopCam.Length; i++)
        {
            camTexture = new WebCamTexture(laptopCam[i].name);   
        }

        camTexture.Play();
        background.texture = camTexture;
    }
}
