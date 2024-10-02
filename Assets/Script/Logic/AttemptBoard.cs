using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttemptBoard : MonoBehaviour
{
    public Node first;
    public Node second;
    public Node third;
    public Node fourth;
    public Node fifth;
    public Node sixth;
    public Node seventh;
    public Node eighth;
    public Node nineth;
    public Node tenth;

    public Text firstText;
    public Text secondText;
    public Text thirdText;
    public Text fourthText;
    public Text fifthText;
    public Text sixthText;
    public Text seventhText;
    public Text eighthText;
    public Text ninethText;
    public Text tenthText;

    public LogicScript logic;
    public GameObject Board;
    public void UpdateBoard()
    {
        first.score = logic.playerScore;
        second.score = PlayerPrefs.GetInt("first");
        third.score = PlayerPrefs.GetInt("second");
        fourth.score = PlayerPrefs.GetInt("third");
        fifth.score = PlayerPrefs.GetInt("fourth");
        sixth.score = PlayerPrefs.GetInt("fifth");
        seventh.score = PlayerPrefs.GetInt("sixth");
        eighth.score = PlayerPrefs.GetInt("seventh");
        nineth.score = PlayerPrefs.GetInt("eighth");
        tenth.score = PlayerPrefs.GetInt("nineth");
    }
    public void SaveBoard()
    {
        PlayerPrefs.SetInt("first", first.score);
        PlayerPrefs.SetInt("second", second.score);
        PlayerPrefs.SetInt("third", third.score);
        PlayerPrefs.SetInt("fourth", fourth.score);
        PlayerPrefs.SetInt("fifth", fifth.score);
        PlayerPrefs.SetInt("sixth", sixth.score);
        PlayerPrefs.SetInt("seventh", seventh.score);
        PlayerPrefs.SetInt("eighth", eighth.score);
        PlayerPrefs.SetInt("nineth", nineth.score);
        PlayerPrefs.SetInt("tenth", tenth.score);
    }
    public void LoadBoard()
    {
        first.score = PlayerPrefs.GetInt("first");
        second.score = PlayerPrefs.GetInt("second");
        third.score = PlayerPrefs.GetInt("third");
        fourth.score = PlayerPrefs.GetInt("fourth");
        fifth.score = PlayerPrefs.GetInt("fifth");
        sixth.score = PlayerPrefs.GetInt("sixth");
        seventh.score = PlayerPrefs.GetInt("seventh");
        eighth.score = PlayerPrefs.GetInt("eighth");
        nineth.score = PlayerPrefs.GetInt("nineth");
        tenth.score = PlayerPrefs.GetInt("tenth");
    }
    public void GetToString()
    {
        firstText.text = first.score.ToString();
        secondText.text = second.score.ToString();
        thirdText.text = third.score.ToString();
        fourthText.text = fourth.score.ToString();
        fifthText.text = fifth.score.ToString();
        sixthText.text = sixth.score.ToString();
        seventhText.text = seventh.score.ToString();
        eighthText.text = eighth.score.ToString();
        ninethText.text = nineth.score.ToString();
        tenthText.text = tenth.score.ToString();
    }
    void Update()
    {
        if(logic.showBoard == true)
        {
            LoadBoard();
            UpdateBoard();
            SaveBoard();
            Board.SetActive(true);
            GetToString();
            logic.showBoard = false;
        }
    }
}
