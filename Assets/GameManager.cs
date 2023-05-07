using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{   
    public GameObject ball;
    [SerializeField]private Text P1Score;
    [SerializeField]private Text P2Score;
    private int score1=0;
    private int  score2=0;
    private void player1Score(){
        score1++;
        P1Score.text= score1.ToString();
                resetBall();

    }
    
    private void player2Score(){
        score2++;
        P2Score.text= score2.ToString();
        resetBall();
        }
    private void  resetBall(){
        Instantiate(ball);
    }
}
