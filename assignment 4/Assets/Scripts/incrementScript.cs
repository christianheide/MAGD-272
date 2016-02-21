using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class incrementScript : MonoBehaviour {

	public Text livesText;
	public Text healthText;
	public Text scoreText;
	public Text charismaText;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			variables.health++;
			healthText.text = variables.health.ToString ();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			variables.score += 10;
			scoreText.text = variables.score.ToString ();
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			variables.charisma += 2;
			charismaText.text = variables.charisma.ToString ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			variables.lives += 3;
			livesText.text = variables.lives.ToString ();
		}
	}
}
