using UnityEngine;

public class CameraController: MonoBehaviour {

    public Transform player;
    
    void Start() {

    }

    void Update() {

        Vector3 position = Vector3.zero;
        position.z = -10;
        position.x = player.position.x;
        position.y = player.position.y;
        transform.position = position;
    }
}
