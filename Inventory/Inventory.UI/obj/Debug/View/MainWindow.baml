   M S B A M L   `   `   `  ����G  CInventory.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Inventory.UIInventory.UI  5   	   A%clr-namespace:Inventory.UI.ConvertersInventory.UI.Converters  5   	   I EInventory.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY=clr-namespace:Inventory.Core.Controls;assembly=Inventory.CoreInventory.Core.Controls 5   	       Inventory.UI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ,localclr-namespace:Inventory.UI     5   	   <
converters%clr-namespace:Inventory.UI.Converters     5   	   Rcontrols=clr-namespace:Inventory.Core.Controls;assembly=Inventory.Core     5   	     � Title$  JP Morgan Inventory��5   	   $	��800��6%   $
��1024��62    � 	Resources 5       �� MergedDictionaries �� Source4  .Inventory.UI.Converters.IsRoadVehicleConverter   IsRoadVehicleConverter5  /Inventory.UI.Converters.TypeToTypeNameConverter  TypeToTypeNameConverter7  1Inventory.UI.Converters.TypeToWheelCountConverter  TypeToWheelCountConverter �� DataType)  #Inventory.UI.InventoryItemViewModel!   Inventory.UI.VehicleContent�� 5	   
    5
      �� 5      $! ..\Resources\MainStyle.xaml?�6%   %�   &	        &	      &	 &     (�� 9     5      *, +)  5      60     5      61     5      63   �� 5      "  6   .R�5        5      5       � DataContext 5        Inventory.UI.ViewModel  5   
   .��5      ,  &Inventory.Core.Controls.AdornedControl  -   5        $��IsAdornerVisible��5         IsAdornerVisible 66   �� *IsBusy+   AdornerContent 5   
      Inventory.UI.LoadingWait  5      .��5   
   �  � RowDefinitions 5      �� 5      $��30 �6    �� 5       $��* �6    �� 5!      $��30 �6    �� 5"      $��* �6    	 � ColumnDefinitions	 5$      �� 5%      $
��Auto �6#   �� 5&      $��* �6#   .+�5)      &	   System.Windows.Controls.DataGrid	  -   5        $��dataGrid��5)   )   
 	  
IsReadOnly
 . $��1��69   $��0��6F    	  AutoGenerateColumns .   	  GridLinesVisibility$ Vertical=�6�    	  RowBackground
 ����� 	  AlternatingRowBackground
 �������6V   �� *
Vehicles+ 	  Columns 5+      0
  *System.Windows.Controls.DataGridTextColumn
  5,      ,  &System.Windows.Controls.DataGridColumn   Header$
 Type��6*   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	Vehicle+ �� 	Converter# [ 
  5-      $
 Make��6)    67   �� *Vehicle.Make+
  5.      $ Model��6)    68   �� *Vehicle.Model+
  5/      $ Number of Wheels��6)    6C   �� *	Vehicle+# [ 4  .System.Windows.Controls.DataGridCheckBoxColumn  50      $ Road Vehicle��6-    6C   �� *Vehicle.Environment+# [   �� Mode$ OneWay=�52      �� 53      $��1��6   $��2��6*   ��6:   ��  �� ElementName$ dataGrid�� �� Path$ SelectedItem��� 54      $��2��6   $��2��6%   
���   �69   �� 56      $
��Test��6   $��4��6%   ��57      �� 58       �� 
TargetType" ��6&   .R�59      � .+�5:      A� #��z��6&   �� 5;      $��Center=�6/   $��Center=�6L   5<      5=      5?      5A      5B      5C      