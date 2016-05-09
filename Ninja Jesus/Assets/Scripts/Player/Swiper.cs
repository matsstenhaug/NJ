using UnityEngine;
using System.Collections;

public class Swiper : MonoBehaviour {

    private Touch initialTouch = new Touch();
    private float distance = 0f;
    private bool hasSwiped = false;

	void FixedUpdate()
    {
        foreach(Touch t in Input.touches)
        {
            if(t.phase == TouchPhase.Began)
            {
                initialTouch = t;
            }
            else if (t.phase == TouchPhase.Moved && !hasSwiped)
            {
                float deltaX = initialTouch.position.x - t.position.x;
                float deltaY = initialTouch.position.y - t.position.y;
                //distance formula
                distance = Mathf.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
                bool sideSwipe = Mathf.Abs(deltaX) > Mathf.Abs(deltaY);

                if(distance > 100f)
                {
                    if (sideSwipe && deltaX > 0) // left
                    {

                    }else if(sideSwipe && deltaX <= 0) //right
                    {

                    }else if(!sideSwipe && deltaY > 0) // down
                    {

                    }else if(!sideSwipe && deltaY <= 0) // up
                    {

                    }
                }
                //direction

                hasSwiped = true;
            }
            else if (t.phase == TouchPhase.Ended)
            {
                initialTouch = new Touch();
                hasSwiped = false;
            }
        }
    }
}
