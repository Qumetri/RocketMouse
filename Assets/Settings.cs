using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    // Start is called before the first frame update
    public void settings()
    {
        SceneManager.LoadScene("menu");
    }
}
