using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;
    [SerializeField]
    float hitDamage;
    [SerializeField]
    Wood wood;


    public Rigidbody knife_rb;
    Vector3 movementVector;
    bool isMoving;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isMoving=Input.GetMouseButton(0);

        if (isMoving)
        {
            movementVector = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"),0)*movementSpeed*Time.deltaTime;
        }

        
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            knife_rb.position += movementVector;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Coll coll = collision.collider.GetComponent<Coll>();
        if (coll != null)
        {
            coll.HitCollider(hitDamage);

            wood.Hit(coll.index, hitDamage);
        }
        
    }


}
