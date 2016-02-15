using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {
	public string gameScene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void loadGameScene(){
		SceneManager.LoadScene (gameScene, LoadSceneMode.Single);
	}
}
