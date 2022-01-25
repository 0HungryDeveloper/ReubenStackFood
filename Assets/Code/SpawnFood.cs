using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject[] food;
    private float randomPositionInAxisX;
    Vector2 positionToInstantiateFood;
    private float timeToInstantiateAnotherObject = 3.0f;
    private float nextFood = 0.0f;

    void Start() {

    }

    void Update(){
        if(Time.time > nextFood){
            nextFood = Time.time + timeToInstantiateAnotherObject;
            spawnObjects();
        }
    }

    private void spawnObjects(){
        //Obtenemos una posición aleatorio de nuestro punto de spam
        randomPositionInAxisX = Random.Range(-5.0f, 5.0f);
        //La posición donde instanciaremos el objeto
        positionToInstantiateFood = new Vector2(randomPositionInAxisX, transform.position.y);
        //Indice aleatorio de nuestro arreglo de objetos de comida
        int getRandomObject = Random.Range(0,food.Length);
        //Instanciamos el objeto
        Instantiate(food[getRandomObject],positionToInstantiateFood,Quaternion.identity);
    }
}
