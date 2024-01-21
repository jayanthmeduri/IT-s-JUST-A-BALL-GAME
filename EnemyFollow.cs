using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public int speed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = player.transform.position - transform.position;
        offset = offset.normalized; // The normalized direction in LOCAL space
        transform.Translate(offset.x * Time.deltaTime * speed, offset.y * Time.deltaTime * speed, offset.z * Time.deltaTime * speed);
    }
    //void OnTriggerEnter(Collider collision)
    //{

    //    if (collision.tag.Equals("Enemy"))
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
}
