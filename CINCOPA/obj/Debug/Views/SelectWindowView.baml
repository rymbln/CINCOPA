   M S B A M L   `   `   `  ����  CINCOPA$    CINCOPA.Views.SelectWindowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  SelectWindowView��5   	   $	��480��6"   $	��640��6/   .��5      ]� $��5q�6   .+�5   
   � $	��Top=�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5	      $��* �6#   .+�5      �� $��0��6   $��
Поиск��6$   �� 5      $��1��6   ��6'   ��  �� Path$ SearchString� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . 5      �� 5   
   $��Bottom=�6    �� Orientation$ 
Horizontal=�5      $��Right=�5      .+�5      �� $��Применить��63    �� 	IsDefault . ��6   �� *	OkCommand+6G   �� 5      	 �� IsCancel	 . $��Отмена��6%   5      � 5   
   $
��Left=�6   $��Bottom=�6*    5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��0��6   $��Добавить��6G    . ��6%   �� *AddNewCommand+6Z   �� 5      $��1��6   $	��500��6&   $��Stretch=�65   ��5      �� $ NewItem�$ TwoWay=�$ PropertyChanged=� .  . 5      �� 5!   
   ��5"      �� $ AllItems�$ TwoWay=�$ PropertyChanged=� .  . 
 �� SelectedItem
 5#      �� $ CurrentItem�$ TwoWay=�$ PropertyChanged=� .  .  �� View 5%      �� 5&      .P�5'      ��  �� Width$	 200��5(      $��Имя��5)       �� DisplayMemberBinding 5*      �� *NAME+5+      5-      5.      5/      