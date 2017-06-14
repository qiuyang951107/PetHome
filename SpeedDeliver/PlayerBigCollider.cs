using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerBigCollider : MonoBehaviour {

    private PlayerMove playerMove;
    void Awake() {
        playerMove = GameObject.FindGameObjectWithTag(Tags.player).GetComponent<PlayerMove>();
    }

    void OnTriggerEnter( Collider other ) {
        if (other.tag == Tags.obstacles &&!playerMove.isSliding ) {
            
            SceneManager.LoadScene("OverScene");
        }
    }

}
