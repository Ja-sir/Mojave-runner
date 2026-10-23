using UnityEngine;
// TODO: Define a simple class called MyMath with the following static methods:
public static class MyMath
{
    public static int sumTotal = 0;

    public static int Add(int a, int b)
    {
        int result = a + b;
        sumTotal += result;
        return result;
    }

    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) => a / b;
}
// * Add - adds two integers together and returns the result.
// * Subtract - subtracts integer b from integer a and returns the result.
// * Multiply - Multiplies two integers and returns the result.
// * Divide - divides two integers and returns the result.

// TODO: In MyMath, add the following static variable:
// * sumTotal - the sum of every time the Add method is called.
public class StaticPractice : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(MyMath.Add(10, 15));
        print(MyMath.Add(13, 22));
        print(MyMath.Add(56, 83));
        print(MyMath.sumTotal);

        print(MyMath.Subtract(10, 5));

        print(MyMath.Multiply(4, 8));

        print(MyMath.Divide(10, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
