//__author__ = 'libw 2016-5-25'
//控件的部分属性
//-     一般应用属性：.FONT = NEW SYSTEM.DRAWING.FONT("字体名称","像素值")
//-                  .IMAGESCALING = SYSTEM.WINDOWS.FORMS.TOOLSTRIPITEMIMAGESCALING.NONE
//                   .NAME=;
//                   .SIZE= NEW SYSTEM.DRAWING.SIZE(INT,INT);
//                   .TEXT=;

//控件的部分属性
//-     事件： .MOUSEMOVE= NEW SYSTEM.WINDOWS.FORMS.MOUSEEVENTHANDLER(控件名+事件名)
//      实现：
//       -   鼠标样式设置(在鼠标移动到控件上的时候)：
                        private void xxxxxx(object sender, MouseEventArgs e)
                        {
                            Cursor.Current = Cursors.Hand;
                        }                     