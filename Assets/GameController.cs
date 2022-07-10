using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private int mScore, mFinalScore;
    [SerializeField]
    private Text mScoreText, mClearText;
    void Start()
    {
        mScoreText.text = "Score : 0";
        mClearText.text = "";
    }
    public void AddScore(int value)
    {
        mScore += value;
        mScoreText.text = "Score : " + mScore.ToString();
        if(mScore >= mFinalScore)
        {
            mClearText.text = "Clear!!!";
        }
    }
    void Update()
    {
        
    }
}
