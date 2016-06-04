interface IName
{
    
}

//interface  包含类或结构可以实现的一组相关功能的定义
            //-     类可以继承多个接口来实现包括多个功能，因为c#不支持类的多重继承。此外，如果要模拟结构的继承，也必须要使用接口，因为结构无法从另一个结构或类继承。
            //-     自动为公共成员，不能包含修饰符，不包含静态成员、常量、字段、运算符，实例构造函数，类型。
            //-     可以包含方法、属性、事件、索引器。
            
            
            //-     实现接口：
                    //-     实现接口：实现接口的类或者结构都必须包含该接口指定的签名匹配的方法定义。
                    //-     实现类对应的成员必须是：公共、非静态、，并且具有与接口成员相同的名称个签名。
                    //-     显示实现接口：如果两个接口成员执行不同的函数，那么这可能会导致其中一个接口的实现不正确或两个接口的实现都不正确
                    
public class SampleClass : IControl, ISurface
{
    void IControl.Paint()           // 这是使用接口名称和一个句点命名该类成员来实现的
    {
        System.Console.WriteLine("IControl.Paint");
    }
    void ISurface.Paint()
    {
        System.Console.WriteLine("ISurface.Paint");
    }
}