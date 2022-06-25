using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int spawnInterval;
    public List<Transform> ballSpawnPoint;
    public Transform center;
    private float timer;
    public Transform cloneparent;
    public int maxBallsAmount;
    public GameObject BallTemplate;

    private Rigidbody rig;
    public List<GameObject> BallList;
    // Start is called before the first frame update

    public void RemoveBall(GameObject ball)
    {
        BallList.Remove(ball);
        Destroy(ball);
    }

    public void RemoveAllBalls()
    {
        while(BallList.Count>0)
        {
            RemoveBall(BallList[0]);
        }
    }
    public void SpawnBalls() 
    { 
        int index = Random.Range(0, ballSpawnPoint.Count);
        Vector3 spawnpoint = ballSpawnPoint[index].transform.position;
        
        SpawnBalls(spawnpoint); 
    } 
    public void SpawnBalls(Vector3 pos)
    {
        if (BallList.Count >= maxBallsAmount)
        {
            return;
        }

        GameObject ball = Instantiate(BallTemplate, new Vector3(pos.x, 0.19f, pos.z), Quaternion.identity) as GameObject; 
        ball.SetActive(true);
        

        BallList.Add(ball);
    }

    private void Start()
    {
        BallList = new List<GameObject>();
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > spawnInterval)
        {

            SpawnBalls();
            timer -= spawnInterval;

        } 
    }
}
