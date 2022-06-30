using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI qestionText;
    [SerializeField] private QuestionSO question;
    [SerializeField] private GameObject[] answereButtons= new GameObject[4];

    private void Start()
    {
        qestionText.text = question.GetQestion();
        for (int i = 0; i < answereButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answereButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswere(i);
        }
    }
}