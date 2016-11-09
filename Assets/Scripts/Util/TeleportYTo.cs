using UnityEngine;

public class TeleportYTo : MonoBehaviour {

    [SerializeField]
    private Transform teleportYPos;

	private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player")) {
            Vector3 playerPosition = collider.transform.position;
            playerPosition.y = teleportYPos.position.y;
            collider.transform.position = playerPosition;
        }
    }

}
