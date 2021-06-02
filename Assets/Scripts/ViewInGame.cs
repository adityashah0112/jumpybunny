using TMPro;
using UnityEngine;

public class ViewInGame: MonoBehaviour {
	public TMP_Text coinsLabel;
	public TMP_Text scoreText;
	public TMP_Text highestScoreText;

	private static ViewInGame sharedInstance;

	private void Awake() {
		sharedInstance = this;
	}

	public static ViewInGame GetInstance() {
		return sharedInstance;
	}
	private void Start() {
	}
	public void ShowHighestScore() {
		highestScoreText.text = PlayerController.GetInstance().GetMaxScore().ToString();
	}
	void Update() {
		
		if(GameManager.GetInstance().currentGameState == GameState.InGame) {
            scoreText.text = PlayerController.GetInstance().GetDistance().ToString();
        }
    }

    public void UpdateCoins() {
        coinsLabel.text = GameManager.GetInstance().GetCollectedCoins().ToString();
    }
}
