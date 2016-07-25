using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ExceptionPractice
{

    public class Person { }
    public class Excep
    {
        public int GetNumber(int index)
        {
            int[] nums = { 300, 600,900 };
            try
            {
                if (index > nums.Length)
                {
                    Console.WriteLine("异常");
                }
                return nums[index];
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                {
                    Type typeOfex = typeof(Excep);
                    string path = string.Empty;
                    Assembly assembly = Assembly.LoadFile(path);
                    Type type = assembly.GetType();
                    object instance = Activator.CreateInstance(type);
                    MethodInfo methodinfo;
                    string str = "无参数";
                    string methname = string.Empty;
                    Type[] param = new Type[] { };
                    if (str.Length == 3)
                    {
                        methodinfo = type.GetMethod(methname);
                    }
                    else
                    {
                        methodinfo = type.GetMethod(methname, param);
                    }

                    Person person = new Person();
                    object[] parames = new object[] { };
                    return Convert.ToInt32(methodinfo.Invoke(person, parames));
                }
                else
                {
                    FileStream fs = null;
                    try
                    {
                        //open
                        fs = new FileStream(@"f:\CODE\data.txt", FileMode.Open);
                        StreamReader sr = new StreamReader(fs);
                        string line;

                        line = sr.ReadLine();
                        Console.WriteLine(line);

                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("[Data File Missing {0}]", e);
                        throw new FileNotFoundException(@"[data.txt not in f:\code\temp directory]");

                    }
                    finally
                    {
                        if (fs != null)
                        {
                            fs.Close();
                        }
                    }

                }
            }

            return 1;
           
        }
    }
}
