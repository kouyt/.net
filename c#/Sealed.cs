//__author__ = 'libw'

//sealed 当对一个类应用 sealed 修饰符时，此修饰符会阻止其他类从该类继承.
//还可以在重写基类中的虚方法或虚属性的方法或属性上使用 sealed 修饰符。 这将使您能够允许类从您的类继承，并防止它们重写特定的虚方法或虚属性。

using System;

public sealed class NameA
{
    System.Console.WriteLine("hello world");
    
}


