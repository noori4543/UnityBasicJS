using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public TextMeshProUGUI Txt_Bumin;
    int count;
    void Awake()
    {
        count = 0;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Gocha() 
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

            if (count >= 80)
            {
                count = 0;
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�.");
                Debug.Log(count);
            }
            else if (randomValue <= 10)
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
                count = 0;
                Debug.Log(count);
            }
            else if (randomValue <= 30)
            {
                Debug.Log("'��'�� �̾Ҵ�!");
                count++;
                Debug.Log(count);
            }
            else
            {
                Debug.Log("'ġġ'�� �̾Ҵ�!");
                count++;
                Debug.Log(count);
            }
        }
    }

        public void GachaSwitch()
    {
        
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
                        // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }

 

    string[] character = { "������", "���ѳ�", "�ռ���", "����ȣ", "������", "������", "������", "������" };
    List<string> characterList = new List<string>();

    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0 ~ 7

        Debug.Log("������? " + character[randomValue] + "�� �����ϴ�.");
        Txt_Bumin.text = "������? " + character[randomValue] + "�� �����ϴ�.";
    }

    public void ListGacha() // characterList.Count
    {
        int randomValue = Random.Range(0, characterList.Count);  // 8 , 0 ~ 7
        Txt_Bumin.text = "������? " + characterList[randomValue] + "�� �����ϴ�.";
    }

    public void AddList()
    {
        // character �迭���� ��� �̸��� �ֽ��ϴ�.
        // characterList���� �ƹ� �����͵� �����ϴ�.

        // character �迭�� �����͸� charcterList���ٰ� �־��ִ� ���� �����ô�.
        // �츮�� ��� �ݺ����� ����ؼ� ����� ���ô�.

        for (int i = 0; i < character.Length; i++) // i < 8 -> 0 ~ 7
        {
            characterList.Add(character[i]);
        }

        for (int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(characterList[i]);
        }
    }
}
