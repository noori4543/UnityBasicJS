using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Practice : MonoBehaviour
{
    public string myName = "õ����";
    public int age = 27;
    public string mbti = "INFJ";
    public string favoriteGame = "LOL";
    public float height = 165.3f;
    public string residence = "����";
    public string bloodType = "AB";
    public string gender = "����";
    public string career = "����";
    public string hobby = "���Ȱ��";

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduce();
    }

    public void SelfIntroduce()
    {
        Debug.Log($"�� �̸��� {myName}�Դϴ�.");
        Debug.Log($"{age}�� ���� {gender}�̰� Ű�� {height}cm �Դϴ�. ������ {residence}�� ��� �ֽ��ϴ�.");
        Debug.Log($"���� {mbti}�� �ణ�� �������� Ÿ���Դϴ�. ��, {bloodType}�̶� �Ƕ��� ������ �ֽ��ϴ�.");
        Debug.Log($"��̴� ģ�����̶� {hobby}�ϰ� �ֽ��ϴ�. �����ϴ� ������ {favoriteGame}�Դϴ�. ���� �� �� ���� �ұ��?");
        Debug.Log($"����� ���� {career}������, ������ �����ؼ� ���� ���� ��ȹ�ڰ� �ǰ� �ͽ��ϴ�.");
    }
}