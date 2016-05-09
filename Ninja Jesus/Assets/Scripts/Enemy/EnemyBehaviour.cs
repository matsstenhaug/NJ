using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public Transform target;
    public float speed;
    void Update()
    {
        MoveToCenter();
    }
    void MoveToCenter()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), step);
    }
}
