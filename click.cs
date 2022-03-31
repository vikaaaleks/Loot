using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    // Start is called before the first frame update
    static int num = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {        
        num = num + 1;
        print(num);

        if (num <= 4){
            Destroy(gameObject);
            print("Ты выбрал " + gameObject.name);
        }        

        if (num == 4){
            print("Полный рюкзак");

        }

        
        
    }
}
