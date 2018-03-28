using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    private int count;

    //public float speed;
	public AudioClip Tada;
    public Text countText;
    public Text winText;
    public GameObject countObj;
    public GameObject winObj;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
        count = 13;
        SetCountText();
    }

    /**
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    } **/

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
			AudioSource.PlayClipAtPoint(Tada, transform.position);
            other.gameObject.SetActive(false);
            count = count - 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Collectibles Remaining:  " + count.ToString();
 
        if (count == 0)
        {
            winText.text = "You Win!";
        }
    }
}
