using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour
{
    public float speed = -3;

    // Start is called before the first frame update
    private Quaternion _origin = Quaternion.identity;

    void Start()
    {
        Input.gyro.enabled = true;
        _origin=Input.gyro.attitude;
    }

    // Update is called once per frame
    void Update()
    {
        // android controls
        #if UNITY_ANDROID
        if(Input.touchCount > 0 || _origin == Quaternion.identity){
            _origin = Input.gyro.attitude;
        }

        transform.localRotation = Quaternion.Inverse(_origin) * Input.gyro.attitude;
        #endif

        //pc controls
        if(Input.GetMouseButton(0))
        {
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));
        }

        if(Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
