using UnityEngine;
using System.Collections;
public class InputOutputter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Event e = Event.current;
        //if (e.isKey)
        //{
        //    Debug.Log("e.keycode = " + e.keyCode);
       // }
       
        
	}
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            Debug.Log("e.keycode = " + e.keyCode);
        }
    }
}
