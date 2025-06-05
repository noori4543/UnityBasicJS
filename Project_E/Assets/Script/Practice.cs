using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Practice : MonoBehaviour
{
    public string myName = "천지수";
    public int age = 27;
    public string mbti = "INFJ";
    public string favoriteGame = "LOL";
    public float height = 165.3f;
    public string residence = "시흥";
    public string bloodType = "AB";
    public string gender = "남자";
    public string career = "없음";
    public string hobby = "밴드활동";

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduce();
    }

    public void SelfIntroduce()
    {
        Debug.Log($"제 이름은 {myName}입니다.");
        Debug.Log($"{age}살 먹은 {gender}이고 키는 {height}cm 입니다. 지금은 {residence}에 살고 있습니다.");
        Debug.Log($"저는 {mbti}라 약간은 내향적인 타입입니다. 또, {bloodType}이라 또라이 기질도 있습니다.");
        Debug.Log($"취미는 친구들이랑 {hobby}하고 있습니다. 좋아하는 게임은 {favoriteGame}입니다. 언제 한 번 같이 할까요?");
        Debug.Log($"경력은 아직 {career}이지만, 열심히 공부해서 좋은 게임 기획자가 되고 싶습니다.");
    }
}