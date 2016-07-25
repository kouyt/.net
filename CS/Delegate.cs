///-    by libw  2016-5-21
///-    委托函数   
///-    主线提交issue关闭申请
///


///-    同步回调委托
            ///     -   委托对象通常通过提供委托将封装的方法的名称或使用匿名方法构造。对委托进行实例化后，委托会将对其进行的方法调用传递到该方法。
            ///             调用方传递到委托的参数将传递到该方法，并且委托会将方法的返回值（如果有）返回到调用方。这被称为调用委托
///-    异步回调
            ///     -   委托类型是封装的，它们不能派生出其他类，也不能从 Delegate 派生出自定义类。由于实例化的委托是一个对象，因此可以作为参数传递或分配给一个属性。
            ///             这允许方法作为参数接受委托并在稍后调用委托。这被称为异步回调，是在长进程完成时通知调用方的常用方法。
            ///                 当以这种方式使用委托时，使用委托的代码不需要知道要使用的实现方法。
            
///-    回调的另一个常见用途是定义自定义比较方法并将该委托传递到短方法。它允许调用方的代码成为排序算法的一部分。


///委托的类型由委托的名称确定，托可以封装采用字符串作为参数并返回 void 的方法
///            -    public delegate void name(string str)

using System;
using string;
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

        MathAction ma = Double;     //创建这个委托的实例

        double multByTwo = ma(4.5);   //调用委托
        Console.WriteLine(multByTwo);

        MathAction ma2 = delegate (double input) { return (input * input); };       //匿名方法调用

        double square = ma2(5);
        Console.WriteLine(square);

        MathAction ma3 = s => s * s * s;

        double cube = ma3(4.375);
        Console.WriteLine(cube);
    }
}

/// 在HDEY写的委托
class Name
{
    delegate void name(out string str);     //定义委托
    public name name1;                      //创建委托的实例

    string str2=string.Empty;
    name1(out str2);                        //
    if(str2==null)
    {
    //
    }
}


///
class2 Name2
{
   Name.name +=new Name.name(GetName);     //订阅委托
   
   public void GetName(out string str)     //实现委托函数
   {
       str=1;
   }
}


///异步回调
delegate void Del(string message);

public static void DelegateMethod(string message)
{
    console.writline(message);
}

Del han=DelegateMethod;     

class Name3
{
    public void MethodCallback(int p1,int p2,Del callback)
    {
        callback((p1+p2).Tostring()) 
    }
}

//输出
MethodCallback(1,2,han)



