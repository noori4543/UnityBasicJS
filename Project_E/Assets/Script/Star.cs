using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;
        star += "Phase 1\n";

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i ; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        star += "Phase 2\n";

        for (int i = 5; i > 0; i--)
        {
            for (int j = 5; j > i; j--)
            {
                star += "　";
            }
            for (int k = 0; k < i; k++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;
        star += "Phase 3-1\n";

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                star += "★";
            }
            star += "\n";
        }
        for (int i = 4; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);

        star = string.Empty;
        star += "Phase 3-2\n";

        int k = 1;

        for (int i = 1; i < 10; i++)
        {
            if (i < 6)
            {
                for (int j = 1; j <= k; j++)
                {
                    star += "★";
                }
                k++;
                star += "\n";
            }
            else
            {
                k--;
                for (int j = 1; j < k; j++)
                {
                    star += "★";
                }
                star += "\n";
            }
        }
        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        star += "Phase 4\n";

        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j > i; j--)
            {
                star += "　";
            }
            for (int k = 0; k <= i; k++)
            {
                star += "★";
            }
            star += "\n";
        }
        for (int i = 4; i > 0; i--)
        {
            for (int j = 5; j > i; j--)
            {
                star += "　";
            }
            for (int k = 0; k < i; k++)
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;
        star += "Phase 5\n";

        int k1 = 5; // 별이 그려질 위치를 나타낼 2가지 수, 5부터 4~6 -> 3~7 -> 2~8 -> 1~9
        int k2 = 5;

        for (int i = 1;i < 10;i++)
        {
            if (i < 6)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (k1 <= j && k2 >= j)
                    {
                        star += "★";
                    }
                    else
                    {
                        star += "　";
                    }
                }
                k1 -= 1;
                k2 += 1;
                star += "\n";
            }
            else
            {
                k1 += 1;
                k2 -= 1;
                for (int j = 1; j < 10; j++)
                {
                    if (k1 < j && k2 > j)
                    {
                        star += "★";
                    }
                    else
                    {
                        star += "　";
                    }
                }
                star += "\n";
            }
        }
        Debug.Log(star);
    }
}
