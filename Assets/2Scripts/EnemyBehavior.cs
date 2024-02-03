using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UI;
using UnityEngine;

public class EnemyBehavior : AbstractCharacter
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Hit(collision.gameObject, false);
        }
        else if (collision.gameObject.layer == 10)
        {
            Hit(collision.gameObject, true);
        }
    }

    
    protected void Hit(GameObject objectHit, bool isPlayer)
    {
        if (!isPlayer)
            objectHit.GetComponent<MachineBehavior>().IsDamaged(damage);
        else
            objectHit.GetComponent<PlayerBehavior>().IsDamaged(damage);
    }

    public void TakeObject(GameObject objectSelected)
    {
        objectSelected.GetComponent<ObjectBehavior>().SetPossesedCharacter(gameObject);
    }

}
