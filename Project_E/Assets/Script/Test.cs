using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("�ȳ��ϼ���.");
        Debug.Log("�ݰ����ϴ�.");
    }

    void OnEnable()
    {
        Debug.Log(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
    }

    void Update()
    {
        
    }
}
