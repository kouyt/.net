using System.Runtime.Serialization.Formatters;
using System.IO;

class Function
{
	///
	///
	public static object GetClone(object obj)
	{
		//以二进制格式将对象或整个连接对象图形序列化和反序列化
		BinaryFormatter formatter=new BinaryFormatter();
		//创建支持存储区为内存的流
		MemoryStream stream = new MemoryStream();
		//将对象或具有指定级的对象图形序列化为给定流
		formatter.Serialize(stream, obj);
		//将当前流中的位置设置为指定值				// 不明白什么意思
		stream.Seek(0,SeekOrigin.Begin);
		// 将指定的流反序列化为对象图形
		object o = formatter.Deserialize(stream);
		//关闭当前流并释放与之关联的所有资源
		stream.Close();

		return o;
	}


	public static object[] Ilist<T>(Ilist<T> list)
	{
		if(list==null||list.count==0)
		{
			return null;
		}
		object[] arr=new object[list.count];
		for(int i=0;i<arr.count;++i)
		{
			arr[i]=list[i];
		}
		return arr;
	}
}
