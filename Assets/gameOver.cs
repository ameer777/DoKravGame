using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
   [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] int lifes = 3;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if(lifes == 0){
            Debug.Log("Game over!");
            Application.Quit();
            #if UNITY_EDITOR
             UnityEditor.EditorApplication.isPlaying = false;
            #endif
            }
            lifes--;
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
