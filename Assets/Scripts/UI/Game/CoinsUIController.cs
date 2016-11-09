using UnityEngine;
using UnityEngine.UI;

public class CoinsUIController : MonoBehaviour {

    [SerializeField]
    private Text text;

    private void Awake()
    {
        text.text = "0";
    }

	private void Start()
    {
        GameManager.onCoinAmountChanged += OnCoinAmountChanged;
    }

    private void OnCoinAmountChanged(int newValue)
    {
        text.text = newValue.ToString();
    }

}
