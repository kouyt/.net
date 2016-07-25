
一、Jquery测试题  

$("#test div")
$("#test").childen();
下面哪种不是jquery的选择器？(单选)  A、基本选择器 B、后代选择器 C、类选择器 D、进一步选择器 
考点:jquery的选择器 (C)  

当DOM加载完成后要执行的函数，下面哪个是正确的？(单选) 
 jQuery(expression, [context]) B、jQuery(html, [ownerDocument]) C、jQuery(callback) D、jQuery(elements)  考点：jquery的核心函数 (C)  
 
 下面哪一个是用来追加到指定元素的末尾的？(单选) A、insertAfter() B、append() C、appendTo() D、after() 考点：jquery的核心函数 (C)  
 
 下面哪一个不是jquery对象访问的方法？(单选)  A、each(callback) B、size() C、index(subject) D、index() 考点： jquery的核心函数之对象访问 （D） 
 
 jquery访问对象中的size()方法的返回值和jQuery对象的_______属性一样. 考点：jquery的核心函数之对象访问 （length） jquery中$(this).get(0)的写法和__________是等价的。 考点：jquery的核心函数之对象访问 （$(this)[0]）
 7. 有这样一个表单元素  ，想要找到这个hidden元素，下面哪个是正确的？(单选) A、visible B、hidden C、visible() D、hidden() 考点：jquery的选择器 （B）
 
 如果需要匹配包含文本的元素，用下面哪种来实现？(单选) A、text() B、contains() C、input() D、attr(name) 考点：jquery的选择器 （B） 
 
 现有一个表格，如果想要匹配所有行数为偶数的，用________实现，奇数的用_______实现。 考点：jquery的选择器 （even,odd）  如果想要找到一个表格的指定行数的元素，用下面哪个方法可以快速找到指定元素？(单选) A、text() B、get() C、eq() D、contents（） 考点：jquery的选择器 （C）
 
 在一个表单里，想要找到指定元素的第一个元素用_________实现，那么第二个元素用_________实现。 考点：jquery的选择器 （first,eq(1)） 
 
下面哪种不属于jquery的筛选？（单选） A、过滤 B、自动 C、查找 D、串联 考点：jquery的筛选 (B)

  下面哪几种是属于jquery文档处理的？ （多选） A、包裹 B、替换 C、删除 D、内部和外部插入 考点：jquery的文档处理 (ABD)  
  如果想在一个指定的元素后添加内容，下面哪个是实现该功能的？（单选）  A、append(content) B、appendTo(content) C、insertAfter(content) D、after(content) 考点：jquery的文档处理 (D)
  在jquery中，用一个表达式来检查当前选择的元素集合，使用______来实现，如果这个表达式失效，则返回___________值。  考点：jquery的筛选 （is(expr),false） 
  
  在jquey中，如果想要从DOM中删除所有匹配的元素，下面哪一个是正确的？（单选） A、delete() B、empty() C、remove() D、removeAll() 考点：jquery的文档处理 （C） 
  
  在jquery中，想要给第一个指定的元素添加样式，下面哪一个是正确的？（单选） A、first B、eq(1) C、css(name) D、css(name,value) 考点： jquery的css处理 （C） 
  在编写页面的时候，如果想要获取指定元素在当前窗口的相对偏移，用_________来实现，该方法的返回值有两个属性，分别是________和__________。 考点：jquery的css处理 （offset,top,left） 
  
  在jquery中，如果想要获取当前窗口的宽度值，下面哪个是实现该功能的？ （单选） A、width() B、width(val) C、width D、innerWidth() 考点：jquery的css处理 （A）
  
  在一个表单中，如果将所有的div元素都设置为绿色，实现功能是____________________________。 考点：jquery的css处理 ($(“div”).css(“color”,”green”))  
  
  为每一个指定元素的指定事件（像click）绑定一个事件处理器函数，下面哪个是用来实现该功能的？ （单选）  A、trigger (type) B、bind(type) C、one(type) D、bind 考点：jquery的事件操作 (B) 
  $().bind("onclcik",function(){
  
  });
  在jquery中，鼠标移动到一个指定的元素上，会触发指定的一个方法，实现该操作的是______________。  考点：jquery的事件操作 (hover(over,out)) 
  
下面哪几个不是属于jquery的事件处理? (多选) A、bind(type) B、click() C、change() D、one(type) 考点：jquery的事件处理 (BC) 
 在一个表单中，如果想要给输入框添加一个输入验证，可以用下面的哪个事件实现？ (单选) A、hover(over ,out) B、keypress（fn） C、change() D、change(fn) 考点：jquery的事件处理 (D) 
 
 当一个文本框中的内容被选中时，想要执行指定的方法时，可以使用下面哪个事件来实现？（单选） A、click(fn) B、change(fn) C、select(fn) D、bind(fn) 考点：jquery的事件处理 (C) 
 
 在jquery中，想让一个元素隐藏，用________实现，显示隐藏的元素用_________实现。 考点：jquery的页面效果 （hide(),show()）  在一个表单中，用600毫秒缓慢的将段落滑上，用__________________________________来实现。 考点：jquery的页面效果 （$(“p”).slideUp(“slow”)） 
 
 在jquery中，如果想要自定义一个动画，用___________________________函数来实现。 考点：jquery的页面效果 (animate(params, options))  在jquery中想要实现通过远程http get请求载入信息功能的是下面的哪一下事件？ (单选) A、$.ajax() B、load(url) C、$.get(url) D、$. getScript(url) 考点：jquery的ajax (C) 

 下面不属于ajax事件的是？ (单选)  A、ajaxComplete(callback) B、ajaxSuccess(callback) C、$.post(url) D、ajaxSend(callback) 考点：jquery的ajax （C）  
 
 彻底将jQuery变量还原，可以使用___________________方法实现。 考点：jquery的多库共存 ($.noConflict(extreme)) 
 上机题：  用jquery 来实现动态添加和删除表格行  在一个表单中，查找所有选中的input元素，可以用jquery中的____________________来实现。 考点：jquery的选择器（:not()）  
 下面哪几种是jquery中表单的对象属性？（多选）  A、:checked B、: enabled C、:hidden D、:selected E、:file F、: disabled 考点：jquery的选择器（ABDF）
 在jquery中如果将一个“名/值”形式的对象设置为所有指定元素的属性，可以用________________实现。  考点：jquery选择器之属性 （attr(pro)）

 jQuery的美元符号$有什么作用？

回答：其实美元符号$只是”jQuery”的别名，它是jQuery的选择器，如下代码：

?
1
2
3
$(document).ready(function(){
 
});

当然你也可以用jQuery来代替$，如下代码：

?
1
2
3
jQuery(document).ready(function(){
 
});

jQuery中就是通过这个美元符号来实现各种灵活的DOM元素选择的，例如$(“#main”)即选中id为main的元素。
问题：body中的onload()函数和jQuery中的document.ready()有什么区别？

回答：onload()和document.ready()的区别有以下两点：

1、我们可以在页面中使用多个document.ready()，但只能使用一次onload()。

2、document.ready()函数在页面DOM元素加载完以后就会被调用，而onload()函数则要在所有的关联资源（包括图像、音频）加载完毕后才会调用。

问题：jQuery中有哪几种类型的选择器？

回答：从我自己的角度来讲，可以有3种类型的选择器，如下：

1、基本选择器：直接根据id、css类名、元素名返回匹配的dom元素。

2、层次选择器：也叫做路径选择器，可以根据路径层次来选择相应的DOM元素。

3、过滤选择器：在前面的基础上过滤相关条件，得到匹配的dom元素。

问题：请使用jQuery将页面上的所有元素边框设置为2px宽的虚线？

回答：这正是jQuery选择器上场的时候了，代码如下：

?
1
2
3
4
5
<script language="javascript" type="text/javascript">
 
         $("*").css("border", "2px dotted red"); 
 
</script>
问题：当CDN上的jQuery文件不可用时，该怎么办？

回答：为了节省带宽和脚本引用的稳定性，我们会使用CDN上的jQuery文件，例如google的jquery cdn服务。但是如果这些CDN上的jQuery服务不可用，我们还可以通过以下代码来切换到本地服务器的jQuery版本：

?
1
2
3
4
5
6
7
8
9
10
11
<script type="text/javascript" language="Javascript" src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.4.1.min.js "></script>
 
<script type='text/javascript'>//<!--[CDATA[
 
if (typeof jQuery == &#39;undefined&#39;) {
 
document.write(unescape("%3Cscript src='/Script/jquery-1.4.1.min.js' type='text/javascript' %3E%3C/script%3E"));
 
}//]]-->
 
</script>

问题：如何使用jQuery实现点击按钮弹出一个对话框？

回答：代码如下：

HTML：

?
1
<input id="inputField" type="text" size="12">

jQuery：
?
1
2
3
4
5
6
7
<script type="text/javascript"> 
$(document).ready(function () {
 $('#Button1').click(function () { 
alert($('#inputField').attr("value")); 
}); 
});
 </script>

问题：jQuery中的Delegate()函数有什么作用？

回答：delegate()会在以下两个情况下使用到：

1、如果你有一个父元素，需要给其下的子元素添加事件，这时你可以使用delegate()了，代码如下：

?
1
2
3
4
5
$("ul").delegate("li", "click", function(){
 
$(this).hide();
 
});
2、当元素在当前页面中不可用时，可以使用delegate()

问题：怎样用jQuery编码和解码URL？

回答：在jQuery中，我们可以使用以下方法实现URL的编码和解码。

?
1
encodeURIComponent(url) and decodeURIComponent(url)
问题：如何用jQuery禁用浏览器的前进后退按钮？

回答：实现代码如下：

?
1
2
3
4
5
6
7
8
9
10
11
<script type="text/javascript" language="javascript">
 
$(document).ready(function() {
 
     window.history.forward(1);
     //OR
     window.history.forward(-1);
 
});
 
</script>