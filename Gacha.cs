using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    public Button gacha;
    private Rect gachaBox;
    private bool show = false;

	void Start ()
    {
        this.gacha = gacha.GetComponent<Button>();
	}

	void Update ()
    {
        if (Timer.ticket == 1) //무료 티켓이 있을 경우,
        {
            GameObject.Find("Gacha").GetComponentInChildren<Text>().text = "무료 티켓으로 뽑기";
        }

        else
        {
            GameObject.Find("Gacha").GetComponentInChildren<Text>().text = "골드 x개를 이용하여 뽑기 (보유 골드 수: y)"; //유료 재화로 뽑기, x: 필요량, y: 보유량
        }
    }

    void TaskOnClick()
    {
        
    }
}
