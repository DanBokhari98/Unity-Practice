using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	
    // Update is called once per frame
	void Update () {
        try
        {
            transform.position = player.position + offset;
        }
        catch (InvalidCastException e) {

        }
	}
}
