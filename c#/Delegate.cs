///-    by libw  2016-5-21
///-    委托函数   
///-    主线提交issue关闭申请
///
using System;
//定义委托
delegate double MathAction(double num);

class DelegateTest
{
    static double Double(double input)
    {
        return input * 2 ;
    }

    static double Main()
    {

        MathAction ma = Double;

        double multByTwo = ma(4.5);
        Console.WriteLine(multByTwo);

        MathAction ma2 = delegate (double input) { return input*input};

        double square = ma2(5);
        Console.WriteLine(square);

        MathAction ma3 = s => s * s * s;

        double cube = ma3(4.375);
        Console.WriteLine(cube);
    }
}

