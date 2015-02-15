using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	public float jumpStrength = 15f;
	public float runSpeed = 8f;
	private bool doubleJump = false;

	private bool onFloor = true;
	private float onFloorRadius = 0.07f;
	public Transform checkOnFloor;
	public LayerMask floorLayer;

	private bool running = false;

	private Animator animator;

	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
		animator = GetComponent<Animator>();
	}

	void FixedUpdate() {
		if (running) {
			rigidbody2D.velocity = new Vector2(runSpeed, rigidbody2D.velocity.y);
		}
		onFloor = Physics2D.OverlapCircle (checkOnFloor.position, onFloorRadius, floorLayer);

		animator.SetBool ("touchesGround", onFloor);
		animator.SetFloat ("speedX", rigidbody2D.velocity.x);

		if (onFloor) {
			doubleJump = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown( KeyCode.Space)){
			if (running && (onFloor || !doubleJump)) {
				this.audio.Play();
				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpStrength);
				if(!doubleJump  && !onFloor) {
					doubleJump = true;
				}
			} else if(!running) {
				running = true;
				NotificationCenter.DefaultCenter().PostNotification(this, "StartRunning");
			}
		}
	}
}
