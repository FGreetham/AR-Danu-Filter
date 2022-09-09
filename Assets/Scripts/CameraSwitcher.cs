using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARKit;
using UnityEngine.iOS;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject cameraAR;
    public CameraFacingDirection direction;


    //ARKitFaceSubsystem.Provider


    // Start is called before the first frame update
    void Start()
    {
        direction = CameraFacingDirection.User;
       // GetComponent<ARCameraManager>();
    }

    public void ChangeDirection()
    {

        direction = CameraFacingDirection.User;
        Debug.Log("Change to User");
        
        //direction = CameraFacingDirection.World;
        //  ARCameraManager

       // direction.ToFeature();
       // direction.GetType();
      //  direction.Equals("User");
        
    }

  

}
