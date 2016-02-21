using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class typeWriterScript : MonoBehaviour {

	public string phrase = "I am a dragon!";
	public string phrase2 = "RAWWWWWWWR!!!";
	public float letterTime;
	public float letterTime2;
	public float delay;
	public Text targetText;
	public Text targetText2;

	public InputField userInput;

	// Use this for initialization
	void Start () {
		StartCoroutine (sayPhrase (phrase));
		StartCoroutine (sayPhrase2 (phrase2));
	}

	IEnumerator sayPhrase(string text){
		int textLength = text.Length;
		for (int i = 0; i < textLength + 1; i++) {
			targetText.text = text.Substring (0, i);
			yield return new WaitForSeconds (letterTime);
		}
	}
	IEnumerator sayPhrase2(string text){
		int textLength = text.Length;
		yield return new WaitForSeconds (delay);
		for (int i = 0; i < textLength + 1; i++) {
			targetText2.text = text.Substring (0, i);
			yield return new WaitForSeconds (letterTime2);
		}
	}

	public void storeUserName(){
		variables.userName = userInput.text;
		StartCoroutine(sayPhrase2("I'll destroy you "+ variables.userName));
	}

}
