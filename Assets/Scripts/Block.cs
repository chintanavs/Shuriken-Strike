using UnityEngine;
using System;
public class Block : MonoBehaviour
{

    public event Action onBeingHit;
    PlayerController pc;

    // Hit by powerup
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log(onBeingHit);
        if(onBeingHit != null) {
            onBeingHit();
            gameObject.SetActive(false);
        }
    }

    // Hit by ball
    private void OnCollisionEnter2D(Collision2D other) {
        if(onBeingHit != null) {
            onBeingHit();
            gameObject.SetActive(false);
        }
    }
}
