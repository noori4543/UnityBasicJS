using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Practice_Gacha : MonoBehaviour
{
    public GameObject gachaPanel;
    string[] character = { "ũ���", "���϶�", "R1", "R2" };
    List<string> characterList = new List<string>();
    public Image[] gachaImages = new Image[10];
    public Sprite[] sprite = new Sprite[4];
    public TextMeshProUGUI[] gachaTexts = new TextMeshProUGUI[10];
    public TextMeshProUGUI countText;
    int countSSR = 0;

    void Start()
    {
        for (int i = 0; i < character.Length; i++)
        {
            characterList.Add(character[i]);
        }
    }

    public void GachaPanelOn()
    {
        gachaPanel.SetActive(true);
    }

    public void GachaPanelOff()
    {
        gachaPanel.SetActive(false);
    }

    public void CharacterGacha()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);
            if (countSSR >= 80)
            {
                Debug.Log($"'ũ���'�� �̾Ҵ�.");
                gachaTexts[i].text = characterList[0];
                gachaImages[i].sprite = sprite[0];
                countSSR = 1;
            }
            else if (randomValue <= 1)
            {
                Debug.Log($"'ũ���'�� �̾Ҵ�.");
                gachaTexts[i].text = characterList[0];
                gachaImages[i].sprite = sprite[0];
            }
            else if (randomValue <= 30)
            {
                Debug.Log($"'���϶�'�� �̾Ҵ�.");
                gachaTexts[i].text = characterList[1];
                gachaImages[i].sprite = sprite[1];
                countSSR++;
            }
            else
            {
                Debug.Log($"'���� F.A.'�� �̾Ҵ�.");
                gachaTexts[i].text = characterList[2];
                gachaImages[i].sprite = sprite[2];
                countSSR++;
            }
        }
        countText.text = $"Ȯ�� SSR: {countSSR}";
    }
}
