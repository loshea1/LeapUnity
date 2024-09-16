using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class TrayController : MonoBehaviour
{
    public Transform leftSide;
    public Transform rightSide;

    private Controller leapController;

    void Start()
    {
        leapController = new Controller();
    }

    void Update()
    {
        Frame frame = leapController.Frame();

            foreach (Hand hand in frame.Hands)
        {
            if (hand.IsLeft)
            {
                // Control left side of the tray
                float rotation = hand.PalmPosition.x; // Adjust rotation based on hand position
                float tilt = hand.PalmPosition.y; // Adjust tilt based on hand position
                AdjustTray(leftSide, rotation, tilt);
            }
            else if (hand.IsRight)
            {
                // Control right side of the tray
                float rotation = -hand.PalmPosition.x; // Adjust rotation based on hand position
                float tilt = hand.PalmPosition.y; // Adjust tilt based on hand position
                AdjustTray(rightSide, rotation, tilt);
            }
        }
    }

    void AdjustTray(Transform side, float rotation, float tilt)
    {
        // Apply rotation and tilt to the side of the tray
        side.rotation = Quaternion.Euler(0f, rotation, 0f);
        side.localRotation *= Quaternion.Euler(tilt, 0f, 0f);
    }
}