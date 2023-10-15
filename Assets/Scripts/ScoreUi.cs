using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUi : MonoBehaviour
{
    private TextMeshProUGUI _field;
    private int _score = 0;

    public void Awake()
    {
        _field = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _field.text = _score.ToString();
    }

    public void IncreaseScore()
    {
        _score += 1;
        _field.text = _score.ToString();
    }
}
