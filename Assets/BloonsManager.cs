using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloonsManager : MonoBehaviour
{
    private float timer;
    private float maxTimer;
    public GameObject bloon;

    private Vector3 startPosition; //3
    [SerializeField] private Pathing _pathing;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        maxTimer = Random.Range(5f,12f);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("SpawnBloonTimer");
    }
    void SpawnBloon()
    {
        float y = 1.25f;
        Vector3 spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0,1f), y, -2));
        spawnPoint.z = -2;
        GameObject.Instantiate(bloon, spawnPoint, new Quaternion(0,0,0,0));
    }
    IEnumerator SpawnBloonTimer()
    {
        if(timer>= maxTimer)
        {
            SpawnBloon();
            timer = 0;
            maxTimer = Random.Range(5f,12f);
        }
        timer += 0.1f;
        yield return new WaitForSeconds(0.1f);
    }

}
