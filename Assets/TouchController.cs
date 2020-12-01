using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private HingeJoint myHingeJoint;
    private float defaultangle = 20;
    private float flickangle = -20;
    private int screenwidth;
    // Start is called before the first frame update
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultangle);
        screenwidth = Screen.width;
        Debug.Log(screenwidth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began && touch.position.x < screenwidth / 2 && tag == "LeftFlipperTag")
                {
                    SetAngle(this.flickangle);
                }

                if (touch.phase == TouchPhase.Began && touch.position.x > screenwidth / 2 && tag == "RightFlipperTag")
                {
                    SetAngle(this.flickangle);
                }
                if (touch.phase == TouchPhase.Ended && touch.position.x < screenwidth / 2 && tag == "LeftFlipperTag")
                {
                    SetAngle(this.defaultangle);
                }
                if (touch.phase == TouchPhase.Ended && touch.position.x > screenwidth / 2 && tag == "RightFlipperTag")
                {
                    SetAngle(this.defaultangle);
                }
            }
        }
    }    
    public void SetAngle(float angle)
        {
            JointSpring jointSpr = this.myHingeJoint.spring;
            jointSpr.targetPosition = angle;
            myHingeJoint.spring = jointSpr;

        }
    
}