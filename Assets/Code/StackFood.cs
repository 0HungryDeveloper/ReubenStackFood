using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackFood : MonoBehaviour
{
    int points = 0;

    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.CompareTag("Blue") ||
            other.gameObject.CompareTag("Green") ||
            other.gameObject.CompareTag("Pink")){
                Debug.Log("Puntuación: "+ points++);   
        }    
            
        if(other.gameObject.CompareTag("Red")){
            Debug.Log("Puntuación: "+ points--);
        }
    }
}
