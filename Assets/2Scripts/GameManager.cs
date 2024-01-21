using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class GameManager : MonoBehaviour
{
    [SerializeField] float _score = 0f;
    [SerializeField] float _timer = 0f;
    [SerializeField] GameObject[] machines;
    [SerializeField] GameObject[] ennemies;

    //Getter and Setter

    public float GetScore()
    {
        return _score;
    }

    public void SetScore(float newScore)
    {
        _score = newScore;
    }

    public void AddScore(float newScore)
    {
        _score += newScore;
    }
    //Getter and Setter ---------------------------



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void Win()
    {

    }

    public void Lose()
    {

    }

}

