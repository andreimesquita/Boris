using UnityEngine;

[DisallowMultipleComponent]
public class FloorMoedasDeBrindeBehaviour : MonoBehaviour {

    private bool isReceived = false;
    private int value;

    private void Awake()
    {
        value = Random.Range(10, 100);
    }

	private void OnTriggerEnter2D(Collider2D collider)
    {
        if (isReceived)
            return;

        isReceived = true;

        if (collider.CompareTag("Player"))
            GameManager.Instance.GainCoins(value);
    }

}
