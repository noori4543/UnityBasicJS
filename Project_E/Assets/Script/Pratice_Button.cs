using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pratice_Button : MonoBehaviour
{
    string myName = "õ����";
    int age = 27;
    string mbti = "INFJ";
    string favoriteGame = "LOL";
    float height = 165.3f;
    string residence = "����";
    string bloodType = "AB";
    string gender = "����";
    string career = "����";
    string hobby = "���Ȱ��";

    public TextMeshProUGUI textMeshProUGUI;

    public void SelfIntroduce1()
    {
        textMeshProUGUI.text = $"�� �̸��� {myName}�Դϴ�.";
    }

    public void SelfIntroduce2() 
    {
        textMeshProUGUI.text = $"{age}�� ���� {gender}�̰� Ű�� {height}cm �Դϴ�. ������ {residence}�� ��� �ֽ��ϴ�.";
    }

    public void SelfIntroduce3()
    {
        textMeshProUGUI.text = $"���� {mbti}�� �ణ�� �������� Ÿ���Դϴ�. ��, {bloodType}�̶� �Ƕ��� ������ �ֽ��ϴ�.";

    }

    public void SelfIntroduce4()
    {
        textMeshProUGUI.text = $"��̴� ģ�����̶� {hobby}�ϰ� �ֽ��ϴ�. �����ϴ� ������ {favoriteGame}�Դϴ�. ���� �� �� ���� �ұ��?";
    }

    public void SelfIntroduce5()
    {
        textMeshProUGUI.text = $"����� ���� {career}������, ������ �����ؼ� ���� ���� ��ȹ�ڰ� �ǰ� �ͽ��ϴ�.";
    }
}
