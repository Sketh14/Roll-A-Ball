using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
	public void LoadData()
    {
        PlayerController player = new PlayerController();
        PlayerData data = SaveSystem.LoadPlayer();

        player.level = data.level;

        SceneManager.LoadScene(player.level);
    }
}
