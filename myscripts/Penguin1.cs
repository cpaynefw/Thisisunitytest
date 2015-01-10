using UnityEngine;
using System.Collections;

public class Penguin1 : MonoBehaviour {
	public Transform target1;
	public Transform target2;
	public Transform target3;
	public Transform target4;
	public Transform target5;
	public Transform target;

	// units per second
	public float speed = 10;

	void Start() {
		Invoke ("walk1", 3);
		}

	void Update(){
		Vector3 dir = target.position - transform.position;
		// remember, 10 - 5 is 5, so target - position is always your direction.
		
		
		// magnitude is the total length of a vector.
		// getting the magnitude of the direction gives us the amount left to move
		float dist = dir.magnitude;
		
		// this makes the length of dir 1 so that you can multiply by it.
		dir = dir.normalized;
		
		// the amount we can move this frame
		float move = speed * Time.deltaTime;
		
		// limit our move to what we can travel.
		if(move > dist) move = dist;
		
		// apply the movement to the object.
		transform.Translate( dir * move);


	}
	void walk1() {
		//Debug.Log("vectorwork");
		target = target1;
		Invoke ("walk2", 5);
		}
	void walk2() {
		//Debug.Log("vectorwork");
		target = target2;
		Invoke ("walk3", 5);
	}
	void walk3() {
		//Debug.Log("vectorwork");
		target = target3;
		Invoke ("walk4", 5);
		}
	void walk4() {
		//Debug.Log("vectorwork");
		target = target4;
		Invoke ("walk5", 5);
		}
	void walk5() {
		//Debug.Log("vectorwork");
		target = target5;
		}
}
