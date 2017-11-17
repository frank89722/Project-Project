using UnityEngine;
using UnityEngine.Events;

public class KeyCtrl : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private UnityEvent onStart;
	void Start () {
		this.onStart.Invoke ();
	}
}
