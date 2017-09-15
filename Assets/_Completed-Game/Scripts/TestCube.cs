using UnityEngine;
using System.Collections;
public class TestCube : MonoBehaviour {
	public GameObject model;
	private Animator animator;
	public GameObject [] target = new GameObject[8];
	public float speed;
	void Start () {
		animator = model.GetComponent<Animator> ();
	}

	void Update () {
		animator.SetBool("RunState",false);////(1)
		if(Input.GetKey(KeyCode.W)){////(2)
			Vector3 targetDir = target[0].transform.position - transform.position;
			float step = speed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			transform.rotation = Quaternion.LookRotation(newDir);
			animator.SetBool("RunState",true);////(1)
		}
		else if(Input.GetKey(KeyCode.S)){////(2)

			Vector3 targetDir = target[4].transform.position - transform.position;
			float step = speed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			transform.rotation = Quaternion.LookRotation(newDir);
			animator.SetBool("RunState",true);
		}
		else if(Input.GetKey(KeyCode.A)){////(2)

			Vector3 targetDir = target[6].transform.position - transform.position;
			float step = speed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			transform.rotation = Quaternion.LookRotation(newDir);
			animator.SetBool("RunState",true);
		}
		else if(Input.GetKey(KeyCode.D)){////(2)

			Vector3 targetDir = target[2].transform.position - transform.position;
			float step = speed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			transform.rotation = Quaternion.LookRotation(newDir);
			animator.SetBool("RunState",true);
		}
	}
}