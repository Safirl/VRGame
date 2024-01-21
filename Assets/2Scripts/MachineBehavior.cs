using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MachineBehavior : AbstractCharacter
{
    [SerializeField] float deteriorationAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoseLife();
    }

    void LoseLife() 
    { 
        lives -= deteriorationAmount * Time.deltaTime;
    }

    public void Repair(float regenerationAmount)
    {
        lives += regenerationAmount;
    }
}
