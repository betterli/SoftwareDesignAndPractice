   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          �Name$
  this��5   (   $��20(�6    � Title$ 
MainWindow��5   	   $
��1080��6   $	��720��6*   .��5	      ]� .+�5
   
   �� $	��Top=�6   %#请在下方输入有效Email地址6;   �� 5   
   -   5         ��Name$ valid_email��5      �� 5   
    �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $��Stretch=�6C   .+�5      �� $	��650��6   请在下方输入Email正文64   �� 5      -   5        $��20��5      6    5      �� 5   
   -   5        $��email��5       �� TextWrapping$
 Wrap=�6   $	��Top=�63   �� 5   
   $ 
Horizontal=�6   $	��Top=�6.   $��Stretch=�6C   .+�5      �� $	��650��6   /-请在下方输入或是选择附件图片：67   c� 5      .@�5      �� -   5        $��20��5      6$   5      5      �� 5   
   .+�5      �� $	��100��6-   ��6   �� *Image+6-   5      �� 5   
   -   5        $��确定��5      $��Bottom=�67   y�6O   �� �� 5   
   ��6   �� *Data+5      5      