   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollViewerControlTemplate  �� 
TargetType �Name � ColumnDefinitions � RowDefinitions ��Name ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll	 ��Name4   .System.Windows.Automation.AutomationProperties
    AutomationId � Cursor �� ScrollableHeight � Maximum � Minimum* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value �� Mode �� RelativeSource �� ScrollableWidth �� Orientation, �� %ComputedHorizontalScrollBarVisibility �� ViewportWidth  ScrollBarPageButton �� 
TargetType �� Property �� Value  HorizontalThumb  VerticalThumb ��Name �� CornerRadius J� SnapsToDevicePixels ]�Name  J� IsMouseOver! ]� DecreaseRepeatButton" �� PageUpCommand# ]� IncreaseRepeatButton$ �� PageDownCommand% ]� Thumb+   %Microsoft.Windows.Themes.ScrollChrome&   ScrollGlyph' �� Triggers( P� Property) P� Value* �� PageLeftCommand+ �� PageRightCommand�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      gMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5      -   5        Dictionary3��%x  &	        &	 �    &	     &	 �    '�� �    7  7  7  7  �� 5      "  ��6:   .R�5   
   � $
 Grid��6   #��z��6    5      �� 5      �� 5      $
��Auto �6#    5
      �� 5      �� 5      $
��Auto �6    .+�5      �� $ Corner��6   $��1��6(   #��� ��68   $��1��6y   �� 5      $! PART_ScrollContentPresenter��6%   # z��6J    .   .  #��z��6�   #��z��6�   $��2��6  #��z��6#  $��2��6F  �� 5      $	 PART_VerticalScrollBar��6   $
 VerticalScrollBar��68   $ Arrow��6n   $��1��6}   # z 6�   $ 0Q�6�   $��0��6�   #y�z 6�   # z 6u  $��8��6�   6  �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+6�  �� 5      $	 PART_HorizontalScrollBar��6   $
 HorizontalScrollBar��6:   $ Arrow��6r   $��0��6�   # z 6�   $ 0Q�6�   $ 
Horizontal=�6�   $��1��6�   #y�z 6�   # z 6�  $��8��6�   64  �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+6�  5      5      �� 5      " ��6(   .�5   
   ��  �@�OverridesDefaultStyle . 62   �� 5   
    � ��
 ���� 6'   �� 5   
    � |� .  6&   �� 5   
    � �� .  6&   �� 5   
    � �� 5      �� 5      "  ��6"   .R�5      �� #��z��6    #��z��6D   #��z��6f   5      5      5       �� 5"      " n�6$   .�5#   
   ��  � �� 5$      �� 5%      "  n�6"   .R�5&      �  5'      �� 5(      $��4 �6/   �� 5)      $��4 �6/   �� 5*      �� 5+      $��4 �6/   �� 5,      $��4 �6/   .+�5.      A� $��0��6"   $��2��62   
���  ��6F   �� 5/      $��1��6$   $��3��64   ���	#FFF4F4F56H   A� 50      $��3��6"   $��2��62   ���	#FFF4F4F56F   51      52      54      55      �� 56      " n�6"   .�57   
   ��  � �� 58      �� 59      "  n�6"   .R�5:      �  5;      �� 5<      $��4 �6,   �� 5=      $��4 �6,   �� 5>      �� 5?      $��4 �6,   �� 5@      $��4 �6,   .+�5B      A� $��0��6"   $��2��6/   
�������6@   �� 5C      $��1��6$   $��3��61   
�������6B   A� 5D      $��3��6"   $��2��6/   
�������6@   5E      5F      5H      5I      �� 5K      " ��6   .�5L   
   ��  �@��IsPressAndHoldEnabled .  69   �� 5M   
    �@��IsFlicksEnabled .  63   �� 5N   
    � ��# � ��6'   �� 5O   
    � ��$ 10��6"   �� 5P   
    � ��$ 10��6%   �� 5Q   
    � �� 5R      �� 5S      "  ��6"   .R�5T      �� $ Border1��6   
���  ��
�������$��1,1,1,1q�6W   $ 3,3,3,3��6q   ._�5U      � $ Bg��6    . 
������� 5V      �� 5W      $��1* �6,   .+�5]      ]� $ 
PART_Track��6    ��. #{�z  6O   $��0��6y   ! 5^      �� 5_   "   #��Z" 6/   8��  6\   # 5a      �� 5b   "   #��Z$ 6/   8�� 6^   % 5d      n� 5e   "   #���  6(   $& VerticalGripper=�6P   $��8��6�   5g      5h      5i      5j      5l      ' 5m   
   P� 5n      ( �@��Orientation$) 
Horizontal=�6-   . �5o      ��  � ��$ 0��6*   �� 5p       � ��$ 0��6-   �� 5q       � ��$ 0��6+   �� 5r       � ��$ 0��6.   �� 5s       � �� 5t      �� 5u      "  ��6*   .R�5v      � $ Bg��6#    . 
������� 5w   "   �� 5x   &   $��0.00001* �67   .+�5z   "   ]� $ 
PART_Track��6(   $��1��6<   #{�z  6L   ! 5{   &   �� 5|   *   #��Z* 67   8�� 6f   # 5~   &   �� 5   *   #��Z+ 67   8�� 6g   % 5�   &   n� 5�   *   $& HorizontalGripper=�60   #���  6v   $��8��6�   5�   #   5�      5�      5�      5�      5�      5�      