using System;
using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.InputSystem.Processors;
using Random = UnityEngine.Random;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject sheep;
    public float spawnRate = 2;
    public float HeightOffSet = 5;
    private float timer = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     spawnSheep();   
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnSheep();
            timer = 0;
        }
    }
    void spawnSheep()
    {
        float LowestPoint = transform.position.y - HeightOffSet;
        float HeighestPoint = transform.position.y + HeightOffSet;
        

        Instantiate(sheep, new Vector3(transform.position.x, Random.Range(LowestPoint, HeighestPoint), 0), transform.rotation);
    }
}
