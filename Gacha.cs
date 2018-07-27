using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    public Button gacha;

	void Start ()
    {
        this.gacha = gacha.GetComponent<Button>();
	}

	void Update ()
    {
        if (Timer.ticket == 1) //무료 티켓이 있을 경우,
        {
            GetComponent<Button>().interactable = true;
            GameObject.Find("Gacha").GetComponentInChildren<Text>().text = "무료 티켓으로 뽑기";
            gacha.onClick.AddListener(GetGacha);
        }

        //else if (Timer.ticket == 0)
        //{
        //    GetComponent<Button>().interactable = true;
        //    GameObject.Find("Gacha").GetComponentInChildren<Text>().text = "골드 x개를 이용하여 뽑기 (보유 골드 수: y)"; //유료 재화로 뽑기, x: 필요량, y: 보유량
        //    gacha.onClick.AddListener(GetGacha);
        //}

        else if (Timer.ticket == 0) // 조건문에 '&& 보유 골드량 < 필요 골드량' 추가 필요 
        {
            GameObject.Find("Gacha").GetComponentInChildren<Text>().text = "보유한 티켓이 없거나 골드가 부족합니다!";
            GetComponent<Button>().interactable = false;
        }
    }

    void GetGacha()
    {
        
    }
}
