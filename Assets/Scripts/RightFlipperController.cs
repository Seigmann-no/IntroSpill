using UnityEngine;


public class RightFlipperController : MonoBehaviour
{
    public float restPosition = 0f;     // The flipper's normal rotation
    public float pressedPosition = 45f;  // The flipper's raised rotation
    public float hitStrength = 10000f;    // The force applied when the flipper is activated
    public float flipperDamper = 150f;    // The damping effect on the flipper's movement

    private HingeJoint HingeJoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HingeJoint = GetComponent<HingeJoint>();
        HingeJoint.useSpring = true;


    }

    // Update is called once per frame
    void Update()
    {
        JointUpdate();
    }
    private void JointUpdate()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            spring.targetPosition = pressedPosition;
            
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        GetComponent<HingeJoint>().spring = spring;
        GetComponent<HingeJoint>().useLimits = true;
    }

}
