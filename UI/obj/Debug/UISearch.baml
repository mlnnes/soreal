   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.UISearch   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � 
ResizeMode$  NoResize=�5   @    � Title$ SoReal��5   	   $	��250��6   $	��400��6%   ���#212421 � Icon$ Resourses/2.png��5	       � WindowStartupLocation$ CenterOwner=�5
   	    � DataContext 5	   5   �� *
UISearch+   Locator �� Source# [  .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��1.5* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5        $��textBoxSearch��5   v   $
��Lato)�6   ���#8c8080���#8c8080���#212421$��0��6�   $��2��6�   $��0,0,0,1q�6�   $
��Left=�6�   $	��274��6  $��
10,10,0,10q�6  ��69   �� *Query+ �� UpdateSourceTrigger$ PropertyChanged=�6  �� 5   
   -   5        $��ButtonSearch��5   H   $��0q�64   $��2��6]   $��10q�6m   ��6   �� *SearchCommand+��5      �� 5      	 j� Stretch$	 UniformToFill=�6   
 �� ImageSource$
 Resourses/Search.png��65   5      �� 5    
   -   5         ��Name$ listBoxTvShows��5       ���#8c8080���#212421$��1��6�   $��1��6�   $��0��6�   $��3��6�   $��Center=�6�   $��0q�6  $��Center=�6$  $��10q�6@  $	��111��6L  $	��372��6Y  ��6,   �� *ListTvShows+��5!      �� 5"      .R�5#      ��  �� Orientation$ Vertical=�6!   .+�5$      �� $
��Lato)�6$   $��16(�66   ��6D   �� *Name+5&      5'      5)      �� 5*   
   -   5         ��Name$ ButtonAddNew��5*      $��0q�6'   $��0��6;   $��2��6K   $��30,10q�6u   ��5+      �� 5,      $	 UniformToFill=�6   $
 Resourses/AddNew2.png��65   5/      �� 50   
   -   5        $ ButtonSearchInternet��50      $��0q�6/   $��30,10q�6C   $��1��6R   $��2��6b   $��2��6v   ��51      �� 52      $	 UniformToFill=�6   $
 Resourses/FindOnline.png��65   55      58      59      