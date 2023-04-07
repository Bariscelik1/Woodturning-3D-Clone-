using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed =1;
    [SerializeField] 
    private SkinnedMeshRenderer skinnedMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,1) * rotationSpeed * Time.deltaTime);
    }

    public void Hit(int keyIndex, float damage)
    {
        float colliderHeight = 2.383072f;
        
        float newWeight = skinnedMeshRenderer.GetBlendShapeWeight(keyIndex) + damage * (100f / colliderHeight);
        skinnedMeshRenderer.SetBlendShapeWeight(keyIndex, newWeight);
    }
}
