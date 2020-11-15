using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	public void RestartGame()
	{
		Invoke("PerformRestart", 0.5f);
	}
	
	void PerformRestart()
	{
		SceneManager.LoadScene("start", LoadSceneMode.Additive);
	}
}
