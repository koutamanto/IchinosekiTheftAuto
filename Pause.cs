using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	// [SerializeField]
    GameObject PauseMenu;
    bool is_visible = false;
	GameObject MenuText;
    GameObject ResumeButton;
    GameObject RestartButton;
   	GameObject ExitButton;
   	GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
	    Cursor.visible = false;
	    Cursor.lockState = CursorLockMode.Locked;
    	canvas = GameObject.Find("Canvas");
    	PauseMenu = gameObject;
    	MenuText = PauseMenu.transform.Find("Menu").gameObject;
    	ResumeButton = PauseMenu.transform.Find("Resume").gameObject;
       	RestartButton = PauseMenu.transform.Find("Restart").gameObject;
    	ExitButton = PauseMenu.transform.Find("Exit").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        	if(!is_visible)
        	{
	            Cursor.visible = true;
	            Cursor.lockState = CursorLockMode.None;
	            canvas.SetActive(false);
		    	MenuText.SetActive(true);
		    	ResumeButton.SetActive(true);
		    	RestartButton.SetActive(true);
		    	ExitButton.SetActive(true);
		    	is_visible = true;
        	}
        	else if(is_visible)
        	{
        		OnClickResumeButton();
        	}
        }
    }
    public void OnClickResumeButton()
    {
    	MenuText.SetActive(false);
    	ResumeButton.SetActive(false);
    	RestartButton.SetActive(false);
    	ExitButton.SetActive(false);
    	is_visible = false;
	    canvas.SetActive(true);
    	Debug.Log("Resume");
	    Cursor.visible = false;
	    Cursor.lockState = CursorLockMode.Locked;

    }
    public void OnClickRestartButton()
    {
    	OnClickResumeButton();
    	SceneManager.LoadScene("CityScene");
    }
    public void OnClickExitButton()
    {
    	SceneManager.LoadScene("TitleScene");
    }
}
