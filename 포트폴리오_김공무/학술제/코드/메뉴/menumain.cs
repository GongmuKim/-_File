using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menumain : MonoBehaviour {

    bool text_quit = false;
	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<Text>().enabled = true;
            Debug.Log("Text print");
            Debug.Log("require is true");

            if (Input.GetKeyDown(KeyCode.Escape) && text_quit == true)
            {
                Debug.Log("Would you exit game?");
                Application.Quit();
            }
            text_quit = true;
        }
    }
    public void go_main(int h)
    {
        PlayerPrefs.SetInt("h_scene", h);
        PlayerPrefs.Save();
        SceneManager.LoadScene("main");
    }
}
