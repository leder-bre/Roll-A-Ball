using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
    public float speed;
    private int count;
    public Text countText;
    public Text winText;
    
	void Start() {
		rb = GetComponent<Rigidbody> ();
        count = 0;
        setCountText();
        winText.text = "";
	}

	void Update() {

	}
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive(false);
            count += 1;
            setCountText();
            if (count >= 12) {
                winText.text = "You Win";
            }
		}
	}
    
    void setCountText() {
        countText.text = "Count: " + count.ToString();
    }

}
