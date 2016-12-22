using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {
    private float moveSpeed = 10f;
    private Vector3 inputValue;
 
	void Update () {
        if (!isLocalPlayer) {
            return;
        }

        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical") * Time.deltaTime *  moveSpeed;

        transform.Translate(inputValue);
    }

    public override void OnStartLocalPlayer () {
        GetComponentInChildren<Camera>().enabled = true;
    }
}
