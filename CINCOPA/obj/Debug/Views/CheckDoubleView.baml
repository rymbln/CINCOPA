   M S B A M L   `   `   `  ����  CINCOPA#    CINCOPA.Views.CheckDoubleView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CheckDoubleView��5   	   $	��768��6!   $
��1024��6.   .��5      ]� .+�5   
   c� $	��Top=�6   .@�5      �� $��Открыть карту��5      ��5      �� *OpenCrfCommand+5      5	      �� 5
   
   $��Bottom=�6   .@�5      �� ��6   ��  �� Path$ 
TotalCards� �� UpdateSourceTrigger$ PropertyChanged=�5      � 5   
    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��5 �6    �� 5      $��* �6    .+�5   
   &   System.Windows.Controls.DataGrid  $��0��6      AutoGenerateColumns .     
IsReadOnly .  �� SelectedItem 5      �� $ 
CurrentCrf� �� Mode$ TwoWay=���5      �� $ CRFCheckDoubles�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ИРК��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� $ Model.NUMBER�  5      $	 ФИО��6)   $
 * 66    6@   �� $ 
Model.NAME�  5      $	 ЛПУ��6)   $
 * 66    6@   �� $ Model.WARD_NAME�  5      $	 Дата рождения��6)   $
 * 6@    6J   �� $ Model.DATE_BIRTH�  5      $+	 %Дата госпитализации��6)   $
 * 6F    6P   �� $  Model.DATE_HOSPITALISATION�  5      $	 Дата выписки��6)   $
 * 6?    6I   �� $ Model.DATE_DISCHARGE�5!      �� 5"      $��1��6   $��5��6(   $��Stretch=�63   $��Center=�6Q   �� 5#      $��2��6   $��Stretch=�6#   $��Stretch=�6?    �� TextWrapping$
 Wrap=�6]   $��2q�6q      TextBoxLarge#��[  6|   ��5$      �� $ CurrentCrf.Result�$ OneWay=�5%      5&      5'      