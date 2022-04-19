using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class spawn_mainchar : MonoBehaviour
{
    public string SceneName;
    public Vector2 playerPos;
    public GameObject prefab_mainchar,prefab_camera;
    Camera_Controller camera_Controller;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneName));


        GameObject jugador = Instantiate(prefab_mainchar);
        GameObject camera = Instantiate(prefab_camera);
        jugador.transform.position = playerPos;
        camera.transform.position = playerPos;
        camera_Controller = camera.GetComponent<Camera_Controller>();
        camera_Controller.player = jugador.transform;
    }


}
