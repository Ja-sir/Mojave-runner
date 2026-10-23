using UnityEngine;

public class TestStatic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            MyClass m = new MyClass(i.ToString());
        }

        print(MyClass.num);

    }

}

public class MyClass
{
    public static int num = 0;
    
    public string name;

    public MyClass(string name)
    {
        this.name = name;
        num++;
    }
}
