   M S B A M L   `   `   `  ����G  CInventory.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Inventory.UI.ConvertersInventory.UI.Converters  5      +clr-namespace:Inventory.UIInventory.UI  6G   !    Inventory.UI.VehicleContent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <
converters%clr-namespace:Inventory.UI.Converters     5      ,localclr-namespace:Inventory.UI     6G     � 	Resources  5      /  )Inventory.UI.Converters.ImageUriConverter   ImageUriConverter8  2Inventory.UI.Converters.VehiclePropertiesConverter  VehiclePropertiesConverter7  1Inventory.UI.Converters.NullToVisibilityConverter  NullToVisibilityConverter6  0Inventory.UI.Converters.VehicleToReviewConverter  VehicleToReviewConverter-  'Inventory.UI.Converters.HeightConverter  HeightConverter<  6Inventory.UI.Converters.VehicleToReviewRatingConverter " VehicleToReviewRatingConverter1  +Inventory.UI.Converters.InvertBoolConverter  InvertBoolConverter(  "Inventory.UI.UpdateQuantityCommand  UpdateQuantityCommand �� 
TargetType �� Property �� Value �� 
TargetType � RowDefinitions �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path��%�  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     &	 �     '�� �     '�� �      5	   
   6'     5
   
   60     5   
   6/     5   
   6.     5   
   6%     5   
   64     5   
   6)     5   
   6&   �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �  5      �� 5   "   $
��Auto �60   �� 5   "   $��* �60   .+�5      �� $��0��6%   $��1q�62   ���#25A0DA
������._�5   "   �� 
�������$��	ExtraBold"�6;   .��5    &   �� $��2q�67   $��Header��6B   ��. 6Y   5!   #   5"      �� 5#      $��1��6%   $��1,0,1,1q�62   ���#25A0DA._�5$   "   �� $��4q�63   5%      5&      5'      5)      5*      �� 5,   
   " ��6   .�5-      ��  � ��$ 30��6'    5.      P� 5/       �@=�HasError . . �50      ��  �@�ToolTip 60   �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�51      53      55      .��56      �� 
�������$��2q�6!    �� Padding$ 1q�65   ._�57   
   �� .��58      �� .+�59      9� $��0��6   $��Quantity��6(    9� 
IsExpanded . .��5:      �  � ColumnDefinitions 5;      �� 5<      $��30 �6/   �� 5=      $	��150 �6/   �� 5>      $��30 �6/   �� 5?      $	��100 �6/   .+�5A      �� -   5        $��QuantityTextBox��5A   "   $��1��69   ��6I   �� $
 Quantity� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5B      $��3��6!   $��Update��61   $��0q�6B   $��30��6N   #��[ 5C   !   ��6R   �� *.+{�5D   !   ��  �� ElementName$ QuantityTextBox��$
 (Validation.HasError)� �� 	Converter# [ 5E      5F      9� 5H      $��1��6   $��Summary��6(    .  .��5I      �� $��5��6   $��3��6-   ��6B   �� $
 Vehicle�# [ ��5J      �� 5K      .R�5L   "   �  5M   &   �� 5N   *   $��30 �6;   �� 5O   *   $	��150 �6;   �� 5P   *   $��30 �6;   �� 5Q   *   $	��150 �6;   .+�5T   &   �� $��1��6,   ��6<   �� $	
 Key��� 5U   &   $��3��60   ��6@   �� $
 Value�5V   #   5X      5Z      5[      9� 5]      $��2��6   $��Photo��6(    . ��6I   �� $
 Vehicle.PhotoName�# [ .��5^      �� .+�5_      �� $ ��No Vehicle Image Available��6$   y�6F   �� $
 Vehicle.PhotoName�# [ �� 5`      $	��200��6x   $��
0,0,0,-177q�6�   ��6    �� $
 Vehicle.PhotoName�# [  6�   5a      5b      9� 5d      $��3��6   $��Review��6(    . $��10��6J   ��5e      �� 5f      .R�5g      �  5h   "   �� 5i   &   $��50 �67   �� 5j   &   $��10 �67   �� 5k   &   $
��Auto �67   .+�5m   "   �� $��0��6,   ��6<   �� �� 5n   "   $��3��6/   ��6?   �� 	 �� *FindAncestor+ �� AncestorType" ��$
 DataContext�# [ ��5p   &   �� 5q   *   .R�5r   .   ��  �� Orientation$ 
Horizontal=�69   5s   +   ��5u   &   �� 5v   *   .R�5w   .   �� $��../Images/star.png��64   $��20��6P   5x   +   5z   #   5{      5|      .��5~      �� $
��Wrap=�6�   ��6    �� $
 Vehicle�# [  �� FallbackValue$ 	No Review��6�   5      5�      5�      5�      5�      