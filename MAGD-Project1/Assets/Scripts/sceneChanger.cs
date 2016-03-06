using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour {
	public string main;
	public string intro;
	//peaceful route
	public string peaceful;
	public string optionsP;
	public string throwStuff;
	public string butterfly;
	public string fightP;
	public string riddle;
	public string playSong;
	public string playAgain;
	public string lie;
	//insult route
	public string insult;
	public string optionsI;
	public string fightI1, fightI2, fightI3;
	public string weapons;
	public string battleSong;
	//endings
	public string ending3;

	public void loadMain(){
		SceneManager.LoadScene (main, LoadSceneMode.Single);
	}
	public void loadPeacful(){
		SceneManager.LoadScene (peaceful, LoadSceneMode.Single);
	}
	public void loadInsult(){
		SceneManager.LoadScene (insult, LoadSceneMode.Single);
	}
	public void loadOptionsP(){
		SceneManager.LoadScene (optionsP, LoadSceneMode.Single);
	}
	public void loadOptionsI(){
		SceneManager.LoadScene (optionsI, LoadSceneMode.Single);
	}
	public void loadThrow(){//death scene
		SceneManager.LoadScene (throwStuff, LoadSceneMode.Single);
	}
	public void loadFightP(){//death scene
		SceneManager.LoadScene (fightP, LoadSceneMode.Single);
	}
	public void loadButterfly(){
		SceneManager.LoadScene (butterfly, LoadSceneMode.Single);
	}
	public void loadWeapons(){
		SceneManager.LoadScene (weapons, LoadSceneMode.Single);
	}
	public void loadFightI1(){//death scene
		SceneManager.LoadScene (fightI1, LoadSceneMode.Single);
	}
	public void loadRiddle(){//death scene
		SceneManager.LoadScene (riddle, LoadSceneMode.Single);
	}
	public void loadPlaySong(){
		SceneManager.LoadScene (playSong, LoadSceneMode.Single);
	}
	public void loadBattleSong(){
		SceneManager.LoadScene (battleSong, LoadSceneMode.Single);
	}
	public void loadFightI2(){//death scene
		SceneManager.LoadScene (fightI2, LoadSceneMode.Single);
	}
	public void loadPlayAgain(){//ending 1
		SceneManager.LoadScene (playAgain, LoadSceneMode.Single);
	}
	public void loadLie(){//ending2
		SceneManager.LoadScene (lie, LoadSceneMode.Single);
	}
	public void loadEnding3(){//ending 3
		SceneManager.LoadScene (ending3, LoadSceneMode.Single);
	}
	public void loadFightI3(){//ending 4
		SceneManager.LoadScene (fightI3, LoadSceneMode.Single);
	}
	public void loadIntro(){
		SceneManager.LoadScene (intro, LoadSceneMode.Single);
	}
}
