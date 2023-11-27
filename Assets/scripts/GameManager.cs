using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playScore;

    public int PlayScore
    {
        get { return playScore; }
        set { playScore = value; }
    }

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject[] ballPositions;
    public static GameManager Instance;
    [SerializeField] private GameObject[] ball;
    [SerializeField] private GameObject[] BallLine;

    [SerializeField] private float xInput
    void Start()
    {
        Instance = this;
        SetBall(BallColor.White, 0);
        SetBall(BallColor.Red, 1);
        SetBall(BallColor.Yellow, 2);
        SetBall(BallColor.Green, 3);
        SetBall(BallColor.Brown, 4);
        SetBall(BallColor.Blue, 5);
        SetBall(BallColor.Pink, 6);
        SetBall(BallColor.Black, 7);
    }

    void Update()
    {

    }

    private void SetBall(BallColor col, int i)
    {
        GameObject obj = Instantiate(ballPrefab,
            ballPositions[i].transform.position,
            Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }
}