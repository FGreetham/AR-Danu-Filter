using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARCamera : MonoBehaviour
{ 
    WebCamTexture camTexture;
    WebCamDevice[] laptopCam;
    public RawImage background;

    private void Start()
    {
        laptopCam = WebCamTexture.devices;

        for(int i=0; i< laptopCam.Length; i++)
        {
            camTexture = new WebCamTexture(laptopCam[i].name);
            
        }

        camTexture.Play();
        background.texture = camTexture;
    }
}
