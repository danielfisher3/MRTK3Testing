using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVTool : MonoBehaviour
{
    [SerializeField] Transform cornerMax;
    [SerializeField] Transform cornerMin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Vector3 topRightCorner = Vector3.zero;
        Vector3 bottRightCorner = Vector3.zero;
        Vector3 bottLeftCorner = Vector3.zero;
        Vector3 topLeftCorner = Vector3.zero;

        if(cornerMax && cornerMin)
        {
            topRightCorner = cornerMax.position;
            bottLeftCorner = cornerMin.position;
            bottRightCorner = topRightCorner;
            bottRightCorner.y = bottLeftCorner.y;
            topLeftCorner = topRightCorner;
            topLeftCorner.x = bottLeftCorner.x;

        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(topRightCorner, bottRightCorner);
        Gizmos.DrawLine(bottRightCorner, bottLeftCorner);
        Gizmos.DrawLine(bottLeftCorner, topLeftCorner);
        Gizmos.DrawLine(topLeftCorner, topRightCorner);


    }
}
