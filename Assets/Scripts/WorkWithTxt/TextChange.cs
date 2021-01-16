﻿using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChange : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("Заменён!", 3);
        _text2.DOText("Дополнение", 2).SetRelative();
        _text3.DOText("Я взломал этот текст", 3, true, ScrambleMode.All);
        _text3.DOColor(Color.red, 3);
    }
}