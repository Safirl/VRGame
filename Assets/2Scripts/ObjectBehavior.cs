using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : AbstractCharacter
{
    [SerializeField] GameObject PossesedCharacter;

    //Getter and Setter
    public void SetPossesedCharacter(GameObject newPossesedCharacter)
    {
        PossesedCharacter = newPossesedCharacter;
    }
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
            collision.gameObject.GetComponent<MachineBehavior>().Repair(damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.layer == 3)
        {
            collision.gameObject.GetComponent<PlayerBehavior>().IsDamaged(damage);
            Destroy(gameObject);
        }
    }

}
