using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("firstOpen", 1);
        PlayerPrefs.SetInt("level_1", 1);
        for (int i = 16; i > 0; i--)
        {
            if (PlayerPrefs.HasKey("level_" + i))
            {
                if (PlayerPrefs.GetInt("level_" + i) == 1)
                {
                    SceneManager.LoadScene(i);
                    return;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
