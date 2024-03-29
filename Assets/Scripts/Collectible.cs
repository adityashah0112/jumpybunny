using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    bool isCollected = false;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Player") {
            CollectCoin();
        }
    }

    void CollectCoin() {
        isCollected = true;
        HideCoin();
        GameManager gm = GameManager.GetInstance();
        gm.CollectCoins();
        print("Coins Collected:\t" + gm.GetCollectedCoins());
    }

    void HideCoin() {
        var sprite = GetComponent<SpriteRenderer>();
        if(sprite != null) {
            sprite.enabled = false;
        }
        var collider = GetComponent<CircleCollider2D>();
        if(collider != null) {
            collider.enabled = false;
        }
    }
}
