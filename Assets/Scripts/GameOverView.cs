using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverView : MonoBehaviour
{
	public TMP_Text coinsLabel;
	public TMP_Text scoreText;
	private static GameOverView sharedInstance;
	private void Awake() {
		sharedInstance = this;
	}

	public static GameOverView GetInstance() {
		return sharedInstance;
	}

	public void UpdateGui() {
		if(GameManager.GetInstance().currentGameState == GameState.GameOver) {
			coinsLabel.text = GameManager.GetInstance().GetCollectedCoins().ToString();
			scoreText.text = PlayerController.GetInstance().GetDistance().ToString();
		}
	}
}
