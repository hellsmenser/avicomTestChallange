   M S B A M L   `   `   `  ����N  JavicomTestChallange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:avicomTestChallange.windows.EditData.Pages*avicomTestChallange.windows.EditData.Pages  5      <    6avicomTestChallange.windows.EditData.Pages.ProductPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:avicomTestChallange.windows.EditData.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N� Title$  ProductPage��5
      .��5      � 
������� J� RenderTransformOrigin$ 
0.349,0.77&�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Products��5   7   $	��200��6   $��0, 10, 0, 240q�6       AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *name+6T     5      $ Тип лицензии��6>   $	 200 6T    6%   �� *type+6T     5      $ Цена��6?   $	 200 6M    6%   �� *price+6M     5      $ Период��6@   $	 200 6P    6%   �� *period+6P   5      �� 5   
   -   5        	 ��Name$	 ProductName��5   m   $��30��6   $��14(�6   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Название��6,   $��10,220,10,200q�6V   6m   �� 5   
   -   5         ��Name$ ProductType��5   u   $��30��6   $��14(�6   $
 Тип лицензии��6-   $��10, 270, 10, 150q�6[   5      �� 5   
   -   5        $	 ProductPrice��5   i   $��30��6   $��14(�6   $
 Цена��6,   $��10,320,10,100q�6R   6i   �� 5   
   -   5        $ ProductPeriod��5   n   $��30��6   $��14(�6   $
 Период��6-   $��10, 370, 10, 50q�6U   5      �� 5   
   -   5         ��Name$
 Pick��5   a   $��Выбрать��6   $��30��6#   $	��100��6/   $��10,400, 690,10q�6;   6a   �� 5   
   -   5        $ Change��5   {   $��Изменить��6   $��30��6$   $	��100��60   $��115,400,585,10q�6<   {�.  6{   �� 5   
   -	   5        $	 Add��5   T   $��Добавить��6   $��30��6$   $	��100��60   $��220,400,480,10q�6<   6a   �� 5   
   -
   5        $��Удалить��5      $��30��6#   $	��100��6/   $��325,400,375,10q�6;   6S   5      5       