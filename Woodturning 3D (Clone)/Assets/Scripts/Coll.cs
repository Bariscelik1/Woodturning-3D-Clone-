using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour
{
    public int index;

    BoxCollider boxColl;

    private void Awake()
    {
        boxColl = GetComponent<BoxCollider>();
        index = transform.GetSiblingIndex();
    }

    public void HitCollider(float damage)
    {
        if (boxColl.size.y - damage > 0)
        {
            boxColl.size = new Vector3(boxColl.size.x, boxColl.size.y - damage, boxColl.size.z);
        }
        else
        {
            Destroy(this);

        }

    }
}
