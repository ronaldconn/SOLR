using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelRay : MonoBehaviour
{   
    public GameObject lasthit, theSun, checker, player;
    public Vector3 collision = Vector3.zero;
    public LayerMask layer;
    
    // public void lightchange()
    // {
        
    // }

    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            lasthit = hit.transform.gameObject;
            collision = hit.point;
            var checkerRenderer = checker.GetComponent<Renderer>();
            if (lasthit == theSun || lasthit == player)
            {
                checkerRenderer.material.SetColor("_Color", Color.green);
            }
            else
            {
                checkerRenderer.material.SetColor("_Color", Color.red);
            }
            
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(collision, 0.2f);
    }

    

}
