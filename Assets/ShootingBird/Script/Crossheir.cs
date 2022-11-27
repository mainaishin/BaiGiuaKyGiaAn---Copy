using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossheir : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = this.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        var target = GameObject.Find("Crossheir");
        target.transform.position = new Vector3(Pos.x, Pos.y, -9);
        Cursor.visible = false;
        
        
    }
    
}
