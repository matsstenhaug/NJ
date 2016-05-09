using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public float spawnInterval;
    private float lastSpawn = 0;
    public float maxRange;
    private Vector3 zero = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time >= lastSpawn + spawnInterval)
        {
            Vector3 direction = zero;
            direction = Quaternion.AngleAxis(Random.Range(-70.0f, 70.0f), Vector3.forward) * direction;
           // transform.rotation = Quaternion.LookRotation(direction);
            

           // Vector3 newSpot = zero + (directionVector3.normalized * distanceFloat);
            //float fx = Random.RandomRange(0, 100);
           // Instantiate(Resources.Load("", zero, ))
            GameObject e = Instantiate(Resources.Load("Prefabs/Enemy"), zero, Quaternion.identity) as GameObject;
            e.transform.rotation = Quaternion.Euler(0, 0, Random.Range(-180, 180));
            //e.transform.rotation = Quaternion.LookRotation(direction);

            Vector3 movement = e.transform.rotation * Vector3.forward;


            e.transform.GetComponent<Rigidbody2D>().velocity = movement * maxRange;

            Vector3 newPos = e.transform.position * maxRange;
            e.transform.position = newPos;
            lastSpawn = Time.time;
        }
	}
}
