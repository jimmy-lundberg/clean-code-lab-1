   M S B A M L   `   `   `  ����G  CPointManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PointManager.ViewsPointManager.Views  5   	   A%clr-namespace:PointManager.ViewModelsPointManager.ViewModels  5   	       PointManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /UC clr-namespace:PointManager.Views     5   	   <
viewmodels%clr-namespace:PointManager.ViewModels     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5   	   ��    ViewModelLocator �� Source# [   �� Path$ MainViewModel�.��5	      �� -   5         ��Name$ 
LayoutRoot��5	      $	��300��6%   $	��300��65   .+�5
   
   ,   &PointManager.Views.PointNavigationView  �� 5   
   $��Id��6   �� 5   
   ��6   �� *ModelCameraPosition.Id+�� 5   
   $��PositionName��6   �� 5   
   ��6   �� *" ModelCameraPosition.PositionName+�� 5   
   $��X��6   �� 5   
   ��6   �� *ModelCameraPosition.X+�� 5   
   $��Y��6   �� 5   
   ��6   �� *ModelCameraPosition.Y+�� 5   
   $��Z��6   �� 5   
   ��6   �� *ModelCameraPosition.Z+�� 5   
   $��HorizontalDegree��6   �� 5   
   ��6   �� *&$ModelCameraPosition.HorizontalDegree+�� 5   
   $��VerticalDegree��6   �� 5   
   ��6   �� *$"ModelCameraPosition.VerticalDegree+�� 5    
   $
��Save��6   ��6!   �� *SaveCameraPositionCommand+5"      5#      