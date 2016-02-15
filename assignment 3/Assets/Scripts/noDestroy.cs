using UnityEngine;
using System.Collections;

public class noDestroy : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
}
