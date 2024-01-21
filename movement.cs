using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class movement : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;
    private int count;
   // public TextMeshProUGUI textCoins;
    public TMP_Text textCoins;
    public TMP_Text wintext;
    public AudioSource coinFX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      //  textCoins = GetComponent<TextMeshProUGUI>();
        count = 0;
        wintext.text = "";
        setcount();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * speed);
        }
         if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKeyDown("space"))
        {
            Vector3 jump = new Vector3(0, 200, 0);
            rb.AddForce(jump);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("coin"))
        {
            coinFX.Play();
            Destroy(collision.gameObject);
            count++;
            Debug.Log(count);
            setcount();
        }
        //if (collision.tag.Equals("Enemy"))
        //{
        //    Destroy(collision.gameObject);
        //    wintext.text = "You Loose!";
        //}
    }
    void setcount()
    {
        textCoins.text = "Score: " + count.ToString();
        if (count >= 6)
        {
            wintext.text = "You Win!";
            SceneManager.LoadScene("playagain");
        }
    }
}
