   M S B A M L   `   `   `  ����K  GWpfCalimbru_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfCalimbru_MVVM.ViewsWpfCalimbru_MVVM.Views  5   	   &     WpfCalimbru_MVVM.Views.ShellView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WpfCalimbru_MVVM.Views     5   	   $��18(�5        � Title$  	ShellView��5   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5    
   �� $��1��5!      $��2��6$   ��5       ��  �� Path$ FullName� �� Mode$ OneWay=�5!   $   �� 5$   
   -   5         ��Name$ 	FirstName��5&      $��1��5%      $��2��6   $	��100��5&       �� 5)   
   -   5        $ LastName��5+      $��2��5*      $��2��6   $	��100��5+      �� 5.   
   -   5         ��Name$ People��50      $��1��5/      $��3��6   $	��100��50       �� DisplayMemberPath$ 	FirstName��52      	 �� SelectedItem	 51      �� *SelectedPerson+$ OneWayToSource=�52      �� 55   
   -   5        $ SelectedPerson_LastName��57      $��2��56      $��3��6   57      �� 5:   
   -   5        
 ��Name$
 	ClearText��5<      $��1��5;      $��4��6   $��Clear Names��5<   !   5>      5?      