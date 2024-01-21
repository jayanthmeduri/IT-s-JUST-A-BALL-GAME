using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class EnemyDestroy : MonoBehaviour
{
    public TMP_Text Loosetext;
    public AudioSource enemydestroysound;
    // Start is called before the first frame update
    void Start()
    {
        Loosetext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.tag.Equals("Enemy"))
        {
            //Destroy(collision.gameObject);
           
            collision.gameObject.SetActive(false);
            enemydestroysound.Play();
            Loosetext.text = "You Loose!";
            SceneManager.LoadScene("playagain");
        }
    }
}
