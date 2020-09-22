using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager1 : MonoBehaviour
{
    public GameObject player;
    public GameObject MainCamera;
    public Vector3 tempPos;
    public GameObject pauseMenu;
    public GameObject GameOverMenu;

    public void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            print("escape key was pressed");
            pauseMenu.gameObject.SetActive(!pauseMenu.gameObject.activeSelf);
        }

        if (player.transform.position.y<=-10)
        {
            GameOverMenu.gameObject.SetActive(true);
            MainCamera.GetComponent<CameraController>().enabled = false;
            tempPos.x = 0;
            tempPos.y = 0;
            tempPos.z = 0;
            MainCamera.transform.position = tempPos;
            player.SetActive(false);
        }
    }

    public void PlayGAme()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Menu Loaded");
    }
}
