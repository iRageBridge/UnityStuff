using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {
	private Animator anim;
	private bool facingRight;

	public GameObject mountains;
	private GameObject sky;
	private GameObject road;
	private GameObject foreground;
	private GameObject sign;

	private int heroIdleFrameCount;
	private const int REQUIRED_IDLE_FRAMES = 3;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		if (transform.localScale.x < 0) {
			flip ();
		}
		facingRight = true;

		sky = GameObject.FindGameObjectWithTag ("Sky");
		road = GameObject.FindGameObjectWithTag ("Road");
		foreground = GameObject.FindGameObjectWithTag ("Foreground");
		sign = GameObject.FindGameObjectWithTag ("Sign");

		heroIdleFrameCount = REQUIRED_IDLE_FRAMES;
	}
	
	// Update is called once per frame
	void Update () {
        float hAxis = Input.GetAxis("Horizontal");

		if (hAxis != 0) {
			anim.SetBool ("Walking", true);
			heroIdleFrameCount = 0;

			if (hAxis > 0 && !facingRight) {
				flip ();
			} 
			else if (hAxis < 0 && facingRight) {
				flip ();
			}

			move (hAxis);
		}

		else{
			if (heroIdleFrameCount == REQUIRED_IDLE_FRAMES) {
				anim.SetBool ("Walking", false);
			} 
			else {
				heroIdleFrameCount++;
			}
		}
	}

	void flip(){
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void move(float direction){
		Transform theTransform = GetComponent<Transform> ();
		Vector3 thePos = theTransform.position;
		thePos.x += (0.05f * direction);

		if ((thePos.x >= -2.5) && (thePos.x <= 2.5)) {
			theTransform.position = thePos;
		} 
		else if (atEdgeOfScene(direction) == false){

			moveGameObjectsBy (sky, 0.03f, direction * -1);
			moveGameObjectsBy (mountains, 0.04f, direction * -1);
			moveGameObjectsBy (road, 0.05f, direction * -1);
			moveGameObjectsBy (sign, 0.05f, direction * -1);
			moveGameObjectsBy (foreground, 0.07f, direction * -1);
		}
	}

	private void moveGameObjectsBy(GameObject theGO, float dist, float dir){
		Vector3 thePos = theGO.transform.position;
		thePos.x += (dist * dir);
		theGO.transform.position = thePos;
	}

	private bool atEdgeOfScene(float direction){
		bool ans = false;
		float xPathPos = road.transform.position.x;
		xPathPos += (0.05f * (direction * -1));

		if ((xPathPos > 40f) || (xPathPos < -32f)) {
			ans = true;
		}

		return ans;
	}
}
