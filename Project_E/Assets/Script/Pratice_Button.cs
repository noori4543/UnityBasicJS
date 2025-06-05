using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pratice_Button : MonoBehaviour
{
    string myName = "천지수";
    int age = 27;
    string mbti = "INFJ";
    string favoriteGame = "LOL";
    float height = 165.3f;
    string residence = "시흥";
    string bloodType = "AB";
    string gender = "남자";
    string career = "없음";
    string hobby = "밴드활동";

    public TextMeshProUGUI textMeshProUGUI;

    public void SelfIntroduce1()
    {
        textMeshProUGUI.text = $"제 이름은 {myName}입니다.";
    }

    public void SelfIntroduce2() 
    {
        textMeshProUGUI.text = $"{age}살 먹은 {gender}이고 키는 {height}cm 입니다. 지금은 {residence}에 살고 있습니다.";
    }

    public void SelfIntroduce3()
    {
        textMeshProUGUI.text = $"저는 {mbti}라 약간은 내향적인 타입입니다. 또, {bloodType}이라 또라이 기질도 있습니다.";

    }

    public void SelfIntroduce4()
    {
        textMeshProUGUI.text = $"취미는 친구들이랑 {hobby}하고 있습니다. 좋아하는 게임은 {favoriteGame}입니다. 언제 한 번 같이 할까요?";
    }

    public void SelfIntroduce5()
    {
        textMeshProUGUI.text = $"경력은 아직 {career}이지만, 열심히 공부해서 좋은 게임 기획자가 되고 싶습니다.";
    }
}
