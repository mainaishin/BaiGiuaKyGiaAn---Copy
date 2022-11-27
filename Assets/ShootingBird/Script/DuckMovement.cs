using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float PosX = Random.Range(-7, 7);
        float VelY = Random.Range(9, 14);
        float VelX = Random.Range(-4, 4);

        if (this.transform.position.y < -6)
        {
            PosX = Random.Range(-7, 7);
            
            if (PosX > 3)
            {
                VelX = Random.Range(-6, 1);
            }
            if (PosX < -3)
            {
                VelX = Random.Range(-1, 6);
            }
            this.transform.position = new Vector2(PosX, -6);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(VelX, VelY);
            this.GetComponent<Rigidbody2D>().AddTorque(15);
            
        }
      
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            PointCount.PointValue += 30;
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Duck")
        {
            IEnumerator coroutine = DuckGone(other.gameObject);
            StartCoroutine(coroutine);
        }
    }

    IEnumerator DuckGone(GameObject toDestroy)
    {
        yield return new WaitForSeconds(4);
        Destroy(toDestroy);
    }




}
