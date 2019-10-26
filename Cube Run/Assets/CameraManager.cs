using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject MainPlayer;
    public Camera MainCamera;
    public float offsetZ;//set the z distance away from the main player
    public float offsetY;//set the y distance away from the player

    private Vector3 CameraRealTimePosition;

    // Start is called before the first frame update
    void Start()
    {
        CameraRealTimePosition = new Vector3(MainPlayer.transform.position.x, MainPlayer.transform.position.y+offsetY, MainPlayer.transform.position.z-offsetZ);//set the camera's real time position
    }

    // FixedUpdate is called every 200 ms(keep the camera in line with player movement)
    void FixedUpdate()
    {
        CameraRealTimePosition.x = MainPlayer.transform.position.x;//update X pos
        CameraRealTimePosition.y = MainPlayer.transform.position.y+offsetY;//update y pos
        CameraRealTimePosition.z = MainPlayer.transform.position.z - offsetZ;//update z pos
        MainCamera.transform.position = CameraRealTimePosition;//set actual camera position to calculated position
    }
}
