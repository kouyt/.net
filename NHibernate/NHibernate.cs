NHibernate是一个基于.Net的针对关系型数据库的对象持久化(ORM)类库
Spring.NET对NHibernate提供了很好的支持与封装
* Model 
  NHibernate要求实体必须是带有无参构造函数和带有virtual修饰的属性。两个实体的关系是双向(一对多——多对一)映射关系
  当年在封装CA映射数据库DTO的时候有一个函数没有带virtual修饰符，造成了报错
  
* Repository.xml db:provider节点是数据的连接字符串配置，
    我们引入xmlns:db="http://www.springframework.net/database"这项命名空间便可以使用它。
    其中provider属性为数据库提供者的名称
* Repository.xml 
  connectionString属性为数据库的连接字符串，这里用${xxx}的方式来表示一个占位符，
  因为我们经常将Spring.NET的配置文件设置为“嵌入系统资源”，这样一来在程序编译后就不能够修改，
  所以我们就要在应用程序配置文件中填写连接字符串，而不是在Spring.NET的配置文件中填写。
* App.config 
  NHibernate中的Session控制取决于SessionFactory，Spring.NET提供了LocalSessionFactoryObject类来统一管理SessionFactory。
  其中MappingAssemblies属性为实体程序集的名称，可以填写多个名称。
  HibernateProperties为NHibernate的配置，dialect属性为数据库的方言，因为是SQL server 2K数据库，所以使用NHibernate.Dialect.MsSql2000Dialect 。
  proxyfactory.factory_class属性为延迟加载的代理类驱动，在NHibernate 2.1版中必须配置。
  hbm2ddl.auto属性为反向建立映射表的配置，我们配置为update后，NHibernate会帮我们自动根据实体的结构生成数据库中的表。
