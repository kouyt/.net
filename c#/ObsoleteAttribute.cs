//__author__ = 'libw'
//'2016-5-22 安装了.NET CORE V1.0 的SDK'
//'VSCode 成功安装了 .NET Core 的 Debugger'

//- F#是一种函数型程序设计语言。作用于：程序核心数据多线程处理

//- svg文件为：可缩放矢量图形

//- .NET Framework 类库中过时的内容（这里是指类型）
                                //  -官方文档解释
                                //          .NET Framework 旧版本中类型，功能被新版本中类型，功能所替代。但是为了向后兼容就无法删除
                                //          旧类型。所以，通过将类型或类型成员标记为过时或弃用，指示不应再使用旧类型。
                                
//- 注意  术语“已过时”和“弃用”在应用于.NET Framework的类型和成员具有相同的含义

//- .NET Framework 
                   //使用ObsoleteAttribute特性标记或类型成员指示它已过时。将该特性应用于某个类型或成员指示该类型或成员会在将来某个版本的 .NET Framework 中删除，但不会破坏使用该成员的已编译代码。
                   //除了指示类型或类型成员已过时之外，ObsoleteAttribute 还定义编译器如何处理包含该类型或成员的源代码。 编译器可以编译代码但发出警告消息，也可以将该类型或成员的使用视为错误。 在第一种情况下，代码可以成功编译，但警告消息会指示类型或成员已过时。 在第二种情况下，编译会失败。
                   //即使编译生成错误而不是警告消息，ObsoleteAttribute 也不会影响运行时行为。 也就是说，使用该类型或成员并且已成功编译的应用程序会始终成功运行。 只有重新编译使用该类型或成员的应用程序的尝试会失败。

//- 如何处理已过时的类型和成员：
                //- 删除代码（显然不可能）
                //- 不升级.NET Framework框架
                //- 低版本的框架下编译，在高版本的框架的下运行
                                    //- 为主可执行文件创建appName.exe.config,appName是应用程序可执行文件的名称。
                                    //- 配置文件中添加内容：
                                                //<configuration>
                                                    //<startup>
                                                       //<supporetedRuntime version="v4.0">
                                                    //</startup>
                                                //</configuration>
                                                
                                                //version的值解释：
                                                        //4.5 - v4.0
                                                        //4   - v4.0
                                                        //3.5 - v2.0.50727
[ObsoleteAttribute("do not use this type", true)]
public class ExecutionScope
{
    
}
        

