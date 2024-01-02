using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractCharacter : MonoBehaviour
{
    [SerializeField] float lives;
    [SerializeField] protected float speed;
    protected float damage;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack()
    {

    }

    public void IsDamaged(float damage)
    {
        lives -= damage;
    }

    public void Move()
    {
        
    }
}
