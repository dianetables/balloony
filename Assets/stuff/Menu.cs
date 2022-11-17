using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// idk if i should change the menu name o.o
public class Menu : MonoBehaviour
{
    //string sceneName = "";
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
