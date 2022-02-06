using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{

    public GameObject gameObject;

    void OnCollisionEnter2D(Collision2D collision2d) {
        
        if(!collision2d.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }
}
