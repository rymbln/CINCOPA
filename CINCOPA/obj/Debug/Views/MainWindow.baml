   M S B A M L   `   `   `  ����  CINCOPA    CINCOPA.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CINCOPA Обзор ИРК��5   	   $	��768��6#   $
��1024��60   .��5      ]� .+�5   	   c� $	��Top=�6   .@�5      �� $��Открыть карту��5      ��5      �� *OpenCrfCommand+5      �� 5	      �� 5
      $!��Добавить карту��5      ��5
      �� *AddCrfCommand+5      �� 5      �� 5      $��Удалить карту��5      ��5      �� *DeleteCrfCommand+5      �� 5      �� 5      $*��$Проверить все карты��5      ��5      �� *CheckCrfCommand+5      �� 5      �� 5      $��Обновить��5      ��5      �� *RefreshCommand+5      5      �� 5   
   $��Bottom=�6   .@�5      �� ��6   ��  �� Path$ 
TotalCards� �� UpdateSourceTrigger$ PropertyChanged=�5      &   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns .     
IsReadOnly .  �� SelectedItem 5      �� $ 
CurrentCrf� �� Mode$ TwoWay=���5      �� $ AllCrf�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ИРК��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 66   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� $ NUMBER�  5      $ ФИО��6)   $	 * 66   
 6@   �� $
 NAME�  5       $ ЛПУ��6)   $	 * 66   
 6@   �� $ 	WARD_NAME�  5!      $ Дата рождения��6)   $	 * 6@   
 6J   �� $ 
DATE_BIRTH� �� StringFormat$ 
dd-MM-yyyy��  5"      $+ %Дата госпитализации��6%   $	 * 6B   
 6L   �� $ DATE_HOSPITALISATION�$ 
dd-MM-yyyy��  5#      $ Дата выписки��6%   $	 * 6;   
 6E   �� $ DATE_DISCHARGE�$ 
dd-MM-yyyy��5&      5(      5)      