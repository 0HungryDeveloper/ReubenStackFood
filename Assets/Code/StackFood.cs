using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackFood : MonoBehaviour
{
    int points = 0;

    void OnCollisionEnter2D(Collision2D collision2d) {
        
        if(collision2d.gameObject.CompareTag("Blue") ||
            collision2d.gameObject.CompareTag("Green") ||
            collision2d.gameObject.CompareTag("Pink")){
                Debug.Log("Puntuación: "+ (++points));   
                //Unimos la comida
        }else{
            //Si en la pila de comida esta algo que no queremos
            Debug.Log("Puntuación: "+ points--);
        }
    }
}
