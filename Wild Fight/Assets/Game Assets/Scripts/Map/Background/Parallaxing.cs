using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour
{

    public Transform[] backgrounds; // Array (list) of all the back- and foreground to be parallaxes
    private float[] parallaxScales; // The Proportion of the camera's movement to move the background by
    private float smoothing = 1f;   // How smooth the parallax is going to be. Make sure to set this above 0

    private Transform cam;
    private Vector3 previousCamPos;

    // Is called bevore Start(). Gut für das zuweisen von Variablen zwischen Objekten und variablen
    void Awake()
    {
        // set up camera the reference
        cam = Camera.main.transform;

    }

    void Start()
    {
        // The previouse frame had the current frame's camera position
        previousCamPos = cam.position;

        parallaxScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < backgrounds.Length; i++)
        {
            //the parallax is the opposite of the camera movement because the previous frame multiplied by the scale
            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];
            // set a target x position which is the current position plus the parallax
            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            //create a rarget position which is the backgrounds current position with its raget x position
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            //fade between position and target position using lerp
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        //set previouseCamPos to the camera's position at the end of the frame
        previousCamPos = cam.position;
    }
}
