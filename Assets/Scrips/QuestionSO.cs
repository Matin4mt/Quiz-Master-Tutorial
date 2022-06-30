using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Question", fileName = "Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] private string qestion = "Enter the new qestion here ...";
    [SerializeField] private string[] answers = new string[4];
    [SerializeField] private int correctAnswerIndex;
    public string GetQestion()
    {
        return qestion;
    }
    public string GetAnswere(int index)
    {
        return answers[index];
    }
    public int GetCorrectAnswere()
    {
        return correctAnswerIndex;
    }
}
