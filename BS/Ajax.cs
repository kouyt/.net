1、什么是AJAX，为什么要使用Ajax（请谈一下你对Ajax的认识）
什么是ajax：
AJAX是“Asynchronous JavaScript and XML”的缩写。他是指一种创建交互式网页应用的网页开发技术。
Ajax包含下列技术：
基于web标准（standards-basedpresentation）XHTML+CSS的表示；
使用 DOM（Document ObjectModel）进行动态显示及交互；
使用 XML 和 XSLT 进行数据交换及相关操作；
使用 XMLHttpRequest 进行异步数据查询、检索；
使用 JavaScript 将所有的东西绑定在一起。
2、为什么要用ajax：
Ajax应用程序的优势在于：
1. 通过异步模式，提升了用户体验
2. 优化了浏览器和服务器之间的传输，减少不必要的数据往返，减少了带宽占用
3. Ajax引擎在客户端运行，承担了一部分本来由服务器承担的工作，从而减少了大用户量下的服务器负载。
2、AJAX最大的特点是什么。
Ajax可以实现动态不刷新（局部刷新）
就是能在不更新整个页面的前提下维护数据。这使得Web应用程序更为迅捷地回应用户动作，并避免了在网络上发送那些没有改变过的信息。

3、请介绍一下XMLhttprequest对象。
Ajax的核心是JavaScript对象XmlHttpRequest。该对象在Internet Explorer 5中首次引入，它是一种支持异步请求的技术。简而言之，XmlHttpRequest使您可以使用JavaScript向服务器提出请求并处理响应，而不阻塞用户。通过XMLHttpRequest对象，Web开发人员可以在页面加载以后进行页面的局部更新。
4、AJAX技术体系的组成部分有哪些。
HTML，css，dom，xml，xmlHttpRequest，javascript
5、AJAX应用和传统Web应用有什么不同。
在传统的Javascript编程中，如果想得到服务器端数据库或文件上的信息，或者发送客户端信息到服务器，需要建立一个HTML form然后GET或者POST数据到服务器端。用户需要点击”Submit”按钮来发送或者接受数据信息，然后等待服务器响应请求，页面重新加载。
因为服务器每次都会返回一个新的页面， 所以传统的web应用有可能很慢而且用户交互不友好。
使用AJAX技术， 就可以使Javascript通过XMLHttpRequest对象直接与服务器进行交互。
通过HTTP Request， 一个web页面可以发送一个请求到web服务器并且接受web服务器返回的信息(不用重新加载页面)，展示给用户的还是通一个页面，用户感觉页面刷新，也看不到到Javascript后台进行的发送请求和接受响应。
6、AJAX请求总共有多少种CALLBACK。
Ajax请求总共有八种Callback
onSuccess
onFailure
onUninitialized
onLoading
onLoaded
onInteractive
onComplete
onException
7.Ajax和javascript的区别。

javascript是一种在浏览器端执行的脚本语言，Ajax是一种创建交互式网页应用的开发技术 ，它是利用了一系列相关的技术其中就包括javascript。
Javascript是由网景公司开发的一种脚本语言，它和sun公司的java语言是没有任何关系的，它们相似的名称只是一种行销策略。
在一般的web开发中，javascript是在浏览器端执行的，我们可以用javascript控制浏览器的行为和内容。
在 Ajax应用中信息是如何在浏览器和服务器之间传递的
      通过XML数据或者字符串
8、在浏览器端如何得到服务器端响应的XML数据。
       XMLHttpRequest对象的responseXMl属性

9、 XMLHttpRequest对象在IE和Firefox中创建方式有没有不同。

  有，IE中通过new ActiveXObject()得到，Firefox中通过newXMLHttpRequest()得到

10、介绍一下XMLHttpRequest对象的常用方法和属性。
 open(“method”,”URL”) 建立对服务器的调用，第一个参数是HTTP请求    方式可以为GET，POST或任何服务器所支持的您想调用的方式。
 第二个参数是请求页面的URL。
    send()方法，发送具体请求
    abort()方法，停止当前请求
    readyState属性   请求的状态 有5个可取值0=未初始化 ，1=正在加载
    2=以加载，3=交互中，4=完成
    responseText 属性  服务器的响应，表示为一个串
    reponseXML 属性 服务器的响应，表示为XML
    status   服务器的HTTP状态码，200对应ok  400对应not found
12、什么是XML

  XML是扩展标记语言，能够用一系列简单的标记描述数据

13、XML的解析方式
   常用的用dom解析和sax解析。dom解析是一次性读取xml文件并将其构造为DOM对象供程序使用，优点是操作方便，但是比较耗内存。Sax是按事件驱动的方式解析的，占用内存少，但是编程复杂
14、你采用的是什么框架（架包）

   这题是必问的，一般也是最开始就会问到。
   在java中比较流行的有 dojo, Prototype , JQuery, Dwr, extjs  等等
15、如果熟悉某种ajax框架，他可能会问到怎样在程序中使用这种框架

DWR框架介绍
    DWR(DirectWeb Remoting)是一个WEB远程调用框架.利用这个框架可以让AJAX开发变得很简单.利用DWR可以在客户端利用JavaScript直接调用服务端的Java方法并返回值给JavaScript就好像直接本地客户端调用一样(DWR根据Java类来动态生成JavaScrip代码).
   DWR的实现原理是通过反射，将java翻译成javascript，然后利用回调机制，从而实现了javascript调用Java代码
16、介绍一下Prototype的$()函数，$F()函数，$A()函数都是什么作用

$() 方法是在DOM中使用过于频繁的document.getElementById() 方法的一个便利的简写，就像这个DOM方法一样，这个方法返回参数传入的id的那个元素。
$F()函数是另一个大收欢迎的“快捷键”，它能用于返回任何表单输入控件的值，比如textbox,drop-down list。这个方法也能用元素id或元素本身做为参数。
$A()函数能把它接收到的单个的参数转换成一个Array对象。

17、介绍一下XMLHttpRequest对象

通过XMLHttpRequest对象，Web开发人员可以在页面加载以后进行页面的局部更新。
AJAX开始流行始于Google在2005年使用的”Google Suggest”。
“Google Suggest”就是使用XMLHttpRequest对象来创建动态的Web接口：
当用户开始输入google的搜索框，Javascript发送用户输入的字符到服务器，然后服务器返回一个建议列表。
XMLHttpRequest对象在IE5.0+, Safari 1.2, Mozilla1.0/Firefox, Opera 8+ 和NetScapt7 开始被支持。

18、AJAX的全称是什么？ 介绍一下AJAX？

AJAX的全称是Asynchronous JavaScript And XML.
AJAX是2005年由Google发起并流行起来的编程方法， AJAX不是一个新的编程语言，但是它是一个使用已有标准的新的编程技术。
使用AJAX可以创建更好，更快，更用户界面友好的Web应用。
AJAX技术基于Javascript和HTTP Request.

19、Ajax主要包含了哪些技术？
Ajax（Asynchronous JavaScript + XML）的定义
基于web标准（standards-based presentation）XHTML+CSS的表示；
使用 DOM（Document Object Model）进行动态显示及交互；
使用 XML 和 XSLT 进行数据交换及相关操作；
使用XMLHttpRequest 进行异步数据查询、检索；
使用 JavaScript 将所有的东西绑定在一起。英文参见Ajax的提出者Jesse James Garrett的原文,原文题目(Ajax: A New Approach to Web Applications)。
类似于DHTML或LAMP，AJAX不是指一种单一的技术，而是有机地利用了一系列相关的技术。事实上，一些基于AJAX的“派生/合成”式（derivative/composite）的技术正在出现，如“AFLAX”。
AJAX的应用使用支持以上技术的web浏览器作为运行平台。这些浏览器目前包括：Mozilla、Firefox、Internet Explorer、Opera、Konqueror及Safari。但是Opera不支持XSL格式对象，也不支持XSLT。

20、AJAX都有哪些优点和缺点？
1、最大的一点是页面无刷新，用户的体验非常好。
2、使用异步方式与服务器通信，具有更加迅速的响应能力。
3、可以把以前一些服务器负担的工作转嫁到客户端，利用客户端闲置的能力来处理，减轻服务器和带宽的负担，节约空间和宽带租用成本。并且减轻服务器的负担，ajax的原则是“按需取数据”，可以最大程度的减少冗余请求，和响应对服务器造成的负担。
4、基于标准化的并被广泛支持的技术，不需要下载插件或者小程序。
ajax的缺点
1、ajax不支持浏览器back按钮。
2、安全问题 AJAX暴露了与服务器交互的细节。
3、对搜索引擎的支持比较弱。
4、破坏了程序的异常机制。
5、不容易调试。

$.ajax()方法详解
1.url:要求string类型（默认当前界面地址，发送请求的地址）
2.type:string类型参数，请求post，get，默认get。put与delete仅部分浏览器支持。
3.timeout：要求number类型参数，设置请求超时的时间。覆盖$.ajaxSetup()方法的全局设置。
4.aync:要求为boolean类型参数，所有请求为异步。同步请求为false，锁住浏览器，用户其他操作必须等待请求完成才可以执行。
5.cache:要求为boolean类型参数，默认为true，(当dataType为scipt时，默认为false)
6.data：要求为object或String类型参数，发送到服务器的数据
7.dataType:要求string类型的参数，预期服务器返回的数据类型。
8.beforeSend：要求function类型的参数，发送请求前可以修改XMLHttpRequest对象的函数，例如添加自定义HTTP头。
在beforeSend中如果返回false可以取消本次ajax请求。XMLHttpRequest对象是惟一的参数。
            function(XMLHttpRequest){
               this;   //调用本次ajax请求时传递的options参数
            }
9.complete:要求为Function类型的参数，请求完成后调用的回调函数（请求成功或失败时均调用）。参数：XMLHttpRequest对象和一个描述成功请求类型的字符串。
          function(XMLHttpRequest, textStatus){
             this;    //调用本次ajax请求时传递的options参数
          }
10.success:要求为Function类型的参数，请求成功后调用的回调函数，有两个参数。
         (1)由服务器返回，并根据dataType参数进行处理后的数据。
         (2)描述状态的字符串。
         function(data, textStatus){
            //data可能是xmlDoc、jsonObj、html、text等等
            this;  //调用本次ajax请求时传递的options参数
         }
11.error:要求为Function类型的参数，请求失败时被调用的函数。该函数有3个参数，即XMLHttpRequest对象、错误信息、捕获的错误对象(可选)。ajax事件函数如下：
       function(XMLHttpRequest, textStatus, errorThrown){
          //通常情况下textStatus和errorThrown只有其中一个包含信息
          this;   //调用本次ajax请求时传递的options参数
       }
12.contentType：
要求为String类型的参数，当发送信息至服务器时，内容编码类型默认为"application/x-www-form-urlencoded"。该默认值适合大多数应用场合。

13.dataFilter：
要求为Function类型的参数，给Ajax返回的原始数据进行预处理的函数。提供data和type两个参数。data是Ajax返回的原始数据，type是调用jQuery.ajax时提供的dataType参数。函数返回的值将由jQuery进一步处理。
            function(data, type){
                //返回处理后的数据
                return data;
            }

14.dataFilter：
要求为Function类型的参数，给Ajax返回的原始数据进行预处理的函数。提供data和type两个参数。data是Ajax返回的原始数据，type是调用jQuery.ajax时提供的dataType参数。函数返回的值将由jQuery进一步处理。
            function(data, type){
                //返回处理后的数据
                return data;
            }

15.global：
要求为Boolean类型的参数，默认为true。表示是否触发全局ajax事件。设置为false将不会触发全局ajax事件，ajaxStart或ajaxStop可用于控制各种ajax事件。

16.ifModified：
要求为Boolean类型的参数，默认为false。仅在服务器数据改变时获取新数据。服务器数据改变判断的依据是Last-Modified头信息。默认值是false，即忽略头信息。

17.jsonp：
要求为String类型的参数，在一个jsonp请求中重写回调函数的名字。该值用来替代在"callback=?"这种GET或POST请求中URL参数里的"callback"部分，例如{jsonp:'onJsonPLoad'}会导致将"onJsonPLoad=?"传给服务器。

18.username：
要求为String类型的参数，用于响应HTTP访问认证请求的用户名。

19.password：
要求为String类型的参数，用于响应HTTP访问认证请求的密码。

20.processData：
要求为Boolean类型的参数，默认为true。默认情况下，发送的数据将被转换为对象（从技术角度来讲并非字符串）以配合默认内容类型"application/x-www-form-urlencoded"。如果要发送DOM树信息或者其他不希望转换的信息，请设置为false。

21.scriptCharset：
要求为String类型的参数，只有当请求时dataType为"jsonp"或者"script"，并且type是GET时才会用于强制修改字符集(charset)。通常在本地和远程的内容编码不同时使用。

案例代码：

复制代码
$(function(){
    $('#send').click(function(){
         $.ajax({
             type: "GET",
             url: "test.json",
             data: {username:$("#username").val(), content:$("#content").val()},
             dataType: "json",
             success: function(data){
                         $('#resText').empty();   //清空resText里面的所有内容
                         var html = ''; 
                         $.each(data, function(commentIndex, comment){
                               html += '<div class="comment"><h6>' + comment['username']
                                         + ':</h6><p class="para"' + comment['content']
                                         + '</p></div>';
                         });
                         $('#resText').html(html);
                      }
         });
    });
});
复制代码
 

22.顺便说一下$.each()函数:
$.each()函数不同于JQuery对象的each()方法，它是一个全局函数，不操作JQuery对象，而是以一个数组或者对象作为第1个参数，以一个回调函数作为第2个参数。回调函数拥有两个参数：第1个为对象的成员或数组的索引，第2个为对应变量或内容。

