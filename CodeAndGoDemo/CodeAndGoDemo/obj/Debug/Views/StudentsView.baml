   M S B A M L   `   `   `  ����H  DCodeAndGoDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CodeAndGoDemo.ViewsCodeAndGoDemo.Views  5      &     CodeAndGoDemo.Views.StudentsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CodeAndGoDemo.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� -   5        $��studenti��5   A   $��0��6   $��0��6    $��3��60    �� View 5      �� 5      .P�5      �� $��Studenti��6%    �� DisplayMemberBinding 67   �� *Nume+6_   5      5      �� 5   
   $��0��6   $��1��6   $
��Nume��6-   $	��Top=�6<   6V   �� 5    
   $��0��6   $��1��6   $��Varsta��6-   $��Bottom=�6>   6[   �� 5!   
   $��1��6   $��1��6   $��Medie��6-   $	��Top=�6=   6W   �� 5"   
   $��1��6   $��1��6   $��	Facultate��6-   $��Bottom=�6A   6^   �� 5$   
   -   5        $��studentNume��5$   -   $��0��6   $��2��6   $	��Top=�6@   6Z   �� 5%   
   -   5        $��studentVarsta��5%   -   $��0��6   $��2��6   $��Bottom=�6B   6_   �� 5&   
   -   5        $��studentMedie��5&   -   $��1��6   $��2��6   $	��Top=�6A   6[   �� 5'   
   -   5        $��studentFacultate��5'   -   $��1��6   $��2��6   $��Bottom=�6E   6b   5(      5)      