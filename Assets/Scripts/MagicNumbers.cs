using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    #region Variable

    [SerializeField] private int _min;
    [SerializeField] private int _max;

    [Header("TextLabel")]
    [SerializeField] private TextMeshProUGUI _infoLabel;
    [SerializeField] private TextMeshProUGUI _guessLabel;
    [SerializeField] private TextMeshProUGUI _guessCountLabel;

    [Header("Button")]
    [SerializeField] private Button _moreButton;
    [SerializeField] private Button _lessButton;
    [SerializeField] private Button _finishButton;

    private int _guess;
    private int _guessCount;
    private bool _isGameOver;
    private int _minInspector;
    private int _maxInspector;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        _minInspector = _min;
        _maxInspector = _max;
        _moreButton.onClick.AddListener(MoreButtonClicked);
        _lessButton.onClick.AddListener(LessButtonClicked);
        _finishButton.onClick.AddListener(FinishButtonClicked);

        SetInfoText($"Загадай число от {_min} до {_max}.");
        CalculateGuess();
    }

    #endregion


    #region Private methods

    private void CalculateGuess()
    {
        _guess = (_maxInspector + _minInspector) / 2;
        _guessCount++;

        SetGuessText($"Твое число {_guess}?");
        SetGuessCountText($"Количество попыток {_guessCount}");
    }

    private void SetInfoText(string text)
    {
        _infoLabel.text = text;
    }

    private void SetGuessText(string text)
    {
        _guessLabel.text = text;
    }

    private void SetGuessCountText(string text)
    {
        _guessCountLabel.text = text;
    }

    private void LessButtonClicked()
    {
        if (_isGameOver)
            return;
        _maxInspector = _guess;
        CalculateGuess();
    }

    private void MoreButtonClicked()
    {
        if (_isGameOver)
            return;

        _minInspector = _guess;
        CalculateGuess();
    }

    private void FinishButtonClicked()
    {
        _isGameOver = true;
        SetGuessText($"Твое число {_guess}!");
    }

    #endregion
}