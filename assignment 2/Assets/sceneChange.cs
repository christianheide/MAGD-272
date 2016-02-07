using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {
	public string highScore;
	public string gameScene;
	void Start(){

	}
	void Update(){

	}
	public void loadHighScore(){
		SceneManager.LoadScene (highScore, LoadSceneMode.Single);
	}
	public void loadGameScene(){
		SceneManager.LoadScene (gameScene, LoadSceneMode.Single);
	}
}
