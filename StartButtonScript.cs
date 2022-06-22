using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour {
	bool is_manual_open = false;
	public void OnClickStartButton()
	{
		SceneManager.LoadScene("CityScene");
	}
	public void update()
	{
		if(Input.GetButton("Cancel"))
		{
			if(is_manual_open)
			{
				GameObject.Find("Canvas").transform.Find("Manual").gameObject.SetActive(true);
				is_manual_open = false;
			}
		}
	}
	public void OnClickManualButton()
	{
		GameObject.Find("Canvas").transform.Find("Manual").gameObject.SetActive(true);
		is_manual_open = true;
	}

}