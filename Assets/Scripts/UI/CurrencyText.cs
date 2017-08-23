using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Updates the text object to reflect current currency.
/// </summary>
public class CurrencyText : MonoBehaviour
{
    private Text text;

    /// <summary>
    /// Refreshes every GUI refresh.
    /// </summary>
    protected void OnGUI()
    {
        text.text = GameManager.HeroManager.Currency + " GP";
    }

    /// <summary>
    /// Sets up the text.
    /// </summary>
    protected void Start()
    {
        text = GetComponent<Text>();
    }
}
