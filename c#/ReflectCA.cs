using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace CA.CaBuild
{
    /// <summary>
    /// 反射实体的类
    /// </summary>
    public class ReflectCA
    {
        object objClass;
        Type classType;

        ///获取反射type
        ///获取class
        ///获取方法实体
        ///执行反射的方法
        ///

        /// <summary>
        /// 实例化要反射的类
        /// </summary>
        /// <param name="strLibPath">Lib所在的路径（绝对路径）</param>
        /// <param name="strFullClassName">类的完成名称（包含命名空间）</param>
        public void InitCAClassAndReflectType(string strLibPath, string strFullClassName)
        {
            classType = InitCA(strLibPath, strFullClassName);
            objClass = InitClass(classType);
        }

        /// <summary>
        /// 执行反射后的方法
        /// </summary>
        /// <param name="strMethodName">方法名称</param>
        /// <param name="paramsTypes">参数类型的数组</param>
        /// <param name="objParams">方法的参数数组</param>
        /// <returns>方法的返回值</returns>
        public object DoReflectMethod(string strMethodName,Type[] paramsTypes, object[] objParams)
        {
            MethodInfo methodInfo = GetMethodInfo(classType, strMethodName, paramsTypes);
            return DoMethod(methodInfo, objClass, objParams);
        }

        /// <summary>
        /// 初始化程序集
        /// </summary>
        /// <param name="strLibPath">Lib的路径</param>
        /// <param name="strFullClassName">类名的完整字符串（包含命名空间）</param>
        /// <returns>类的类型</returns>
        private Type InitCA(string strLibPath, string strFullClassName)
        {


            //Assembly表示一个程序集，它是一个可重用、无版本冲突并且可自我描述的公共语言运行时应用程序构建基块
            Assembly assembly = Assembly.LoadFile(strLibPath);  //加载指定路径上的程序集文件的内容
            //使用 Assembly.GetType 或 Assembly.GetTypes 从尚未加载的程序集中获取 Type 对象，
            //并传入所需类型的名称。
            Type type = assembly.GetType(strFullClassName); //获取程序集实例中具有指定名称的Type对象
            //typeof也可以用于获取type
            Type t = typeof(System.String);

            return type;
        }

        /// <summary>
        /// 实例化类
        /// </summary>
        /// <param name="type">类的类型</param>
        /// <returns>类实例化后的实例</returns>
        private object InitClass(Type type)
        {
            object instance = Activator.CreateInstance(type);
            return instance;
        }

        /// <summary>
        /// 获取方法实体
        /// </summary>
        /// <param name="type">反射的类的类型</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="types">参数的数组</param>
        /// <returns>方法的实体</returns>
        private MethodInfo GetMethodInfo(Type type,string methodName,Type[] types)
        {
            //使用 MemberInfo、MethodInfo、FieldInfo 或 PropertyInfo 对象获取有关该类型的方法、属性、事件和字段的信息。
            MethodInfo methodInfo;
            if (types == null || types.Length == 0)
            {
                //搜索具有指定名称的公共方法
                methodInfo = type.GetMethod(methodName);
            }
            else
            {
                //搜索其参数与指定参数类型匹配的指定公共方法。
                methodInfo = type.GetMethod(methodName, types);
            }
            return methodInfo;
        }

        /// <summary>
        /// 执行反射方法
        /// </summary>
        /// <param name="methodInfo">方法实体</param>
        /// <param name="classModel">方法所在类的实例</param>
        /// <param name="paramsObj">参数，如果没有参数，传入空</param>
        /// <returns></returns>
        private object DoMethod(MethodInfo methodInfo,object classModel, object[] paramsObj)
        {
            //发现方法的属性并提供对方法元数据的访问
            return methodInfo.Invoke(classModel, paramsObj);        //调用方法或构造函数使用指定的参数与当前实例表示的。（从 MethodBase 继承)
        }
    }
}
