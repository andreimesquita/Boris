using UnityEngine;

public class GameManager : MonoBehaviour {

    #region DELEGATES
    public delegate void OnCoinAmountChanged(int newAmount);
    #endregion

    #region EVENTS
    public static event OnCoinAmountChanged onCoinAmountChanged;
    #endregion

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<GameManager>();
        DontDestroyOnLoad(this.gameObject);
        PlayerPrefs.SetInt("coins", 0);
    }

    public void GainCoins(int v)
    {
        int newValue = PlayerPrefs.GetInt("coins") + v;
        PlayerPrefs.SetInt("coins", newValue);
        DispatchOnCoinAmountChanged(newValue);
    }

    private void DispatchOnCoinAmountChanged(int newValue)
    {
        if (onCoinAmountChanged != null)
            onCoinAmountChanged(newValue);
    }
}
