using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    int count = 2;

    void Start()
    {
        for(int i = 2; i <= 50; i += 2)
        {
            if(i % 10 == 0)
            {
                print("HONK!");
            }
            else
            {
                print(i);
            }
        }

        while(count <= 50)
        {
            if(count % 10 == 0)
            {
                print("HONK!");
            }
            else
            {
                print(count);
            }

            count += 2;
        }
    }
}
