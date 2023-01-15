using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMovementFixBugs : MonoBehaviour
{
    [System.Obsolete]
    private XRRig XRRigOrigin;
    private CharacterController CharacterController;
    private CharacterControllerDriver driver;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        UpdateCharacterController();
    }

    /// <summary>
    /// Updates the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
    /// based on the camera's position.
    /// </summary>
    [System.Obsolete]
    protected virtual void UpdateCharacterController()
    {
        if (XRRigOrigin == null || CharacterController == null)
            return;

        var height = Mathf.Clamp(XRRigOrigin.CameraInOriginSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = XRRigOrigin.CameraInOriginSpacePos;
        center.y = height / 2f + CharacterController.skinWidth;

        CharacterController.height = height;
        CharacterController.center = center;
    }
}
