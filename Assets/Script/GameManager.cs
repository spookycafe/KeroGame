using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject comida_prefab;
    public GameObject verdura_prefab;
    public GameObject pizza_prefab;
    public GameObject hotdog_prefab;
    public GameObject grape_prefab;



    void Start()
    {
        InvokeRepeating("spawnComida", 2,2);
        InvokeRepeating("spawnPizza", 1, 7);
        InvokeRepeating("spawnHotdog", 4, 8);
        InvokeRepeating("spawnVerdura", 9, 11);
        InvokeRepeating("spawnGrape", 6, 10);
    }



    void spawnComida()
    {
        float temPos = Random.Range(-1.76f, 1.76f);
        Instantiate(comida_prefab, new Vector3(temPos, 6f, 0), Quaternion.identity);
    
    }

    void spawnVerdura()
    {
        float temPos = Random.Range(-1.76f, 1.76f);
        Instantiate(verdura_prefab, new Vector3(temPos, 6f, 0), Quaternion.identity);
    }

    void spawnPizza()
    {
        float temPos = Random.Range(-1.76f, 1.76f);
        Instantiate(pizza_prefab, new Vector3(temPos, 6f, 0), Quaternion.identity);

    }

    void spawnHotdog()
    {
        float temPos = Random.Range(-1.76f, 1.76f);
        Instantiate(hotdog_prefab, new Vector3(temPos, 6f, 0), Quaternion.identity);
    }

    void spawnGrape()
    {
        float temPos = Random.Range(-1.76f, 1.76f);
        Instantiate(grape_prefab, new Vector3(temPos, 6f, 0), Quaternion.identity);

    }
}
