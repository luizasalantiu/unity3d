using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int currentScore;
	public static int highScore;
	public static int currentLevel;
	public static int unblockLevel;

	public static void CompleteLevel(){
		Application.LoadLevel (1);
	}

}
