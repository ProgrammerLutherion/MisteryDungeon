using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_mainchar : MonoBehaviour
{
    public GameObject prefab_mainchar,prefab_camera;
    Camera_Controller camera_Controller;
    // Start is called before the first frame update
    void Start()
    {
        GameObject jugador = Instantiate(prefab_mainchar);
        GameObject camera = Instantiate(prefab_camera);
        camera_Controller = camera.GetComponent<Camera_Controller>();
        camera_Controller.player = jugador.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
