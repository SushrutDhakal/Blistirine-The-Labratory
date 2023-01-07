using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiring : MonoBehaviour
{
    Vector3 startPoint;
    public SpriteRenderer WireEnd;
    
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;

        transform.position = newPosition;

        Vector3 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;

        float dist = Vector2.Distance(startPoint, newPosition);
        WireEnd.size = new Vector2(dist, WireEnd.size.y);
        
    }
}
