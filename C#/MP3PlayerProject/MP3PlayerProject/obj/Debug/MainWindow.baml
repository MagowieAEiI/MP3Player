   M S B A M L   `   `   `  ����K  GMP3PlayerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MP3PlayerProject.StandardControl MP3PlayerProject.StandardControl  5   	   U/clr-namespace:MP3PlayerProject.ComponentControl!MP3PlayerProject.ComponentControl  5   	   3clr-namespace:MP3PlayerProjectMP3PlayerProject  5   	   !    MP3PlayerProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   JstandardControl.clr-namespace:MP3PlayerProject.StandardControl     5   	   LcomponentControl/clr-namespace:MP3PlayerProject.ComponentControl     5   	   ;mp3PlayerProjectclr-namespace:MP3PlayerProject     5   	   -   5          �Name$  Window��5   6    � Title$ 
MainWindow��6	   $	��600��6   $
��1150��6)    � 	Resources 5      .  (MP3PlayerProject.WidthAndHeightConventer   MyConventer �� MergedDictionaries �� Source�� 5	   
    5      �� 5      $ ScrollBarStyle.xaml?�6%   %   &	          5
      6M   5      .��5      � ��5   
   
� 5       
� GradientOrigin$ 0.5,0.5&�6"   .��5      �  � Color$ #48494c��6    � Offset$	 0.0Q�6/   � 5      $ #252529��6   $	 1.0Q�6/   5       � RowDefinitions 5      �� 5   
   $��0.75* �6   6)   �� 5   
   $��8* �6   6&   �� 5   
   $��2* �6   6&   .+�5      � $��0��6   .+�5      �� $��0,0,0,3q�6   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6*   
 �� EndPoint$	
 0,1&�6;   .��5       � $ White��6'   $	 0.9Q�65   � 5!      $ Black��6'   $ 1Q�65   5"      5$      5%      � 5&      $��1��6    � ColumnDefinitions 5'      �� 5(      -   5         ��Name$ ColumnDefinition1��5(   #   ��6>   ��  �� ElementName$ Window�� �� Path$ Width� �� 	Converter# [   �� ConverterParameter$ 1��6�   �� 5)      $��* �6#   6/   .+�5+      � $��0��6    5,      �� 5-      $��40 �6(   66   �� 5.      $��40 �6(   66   �� 5/      $��40 �6(   66   �� 50      $��40 �6(   66   �� 51      $��40 �6(   66   .+�53      � $��0��6   $��	10,16,0,0q�6#   .+�54      ]� .+�55      ��  �� BitmapScalingMode$ HighQuality=�6    $
��Left=�6N   $5��/../Assets/ControlImages/LeftBar_Icons/Songs.png��6i   $��30��6�   6�   �� 56      $��Center=�6$   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6?   
�������$
��Bold"�6�   $��12(�6�   $��NoWrap=�6�   Songs6�   57      58      � 59      $��1��6   $��	10,16,0,0q�6#   .+�5:      ]� .+�5;      �� $ HighQuality=�6    $
��Left=�6N   $6��0../Assets/ControlImages/LeftBar_Icons/Albums.png��6i   $��30��6�   6�   �� 5<      $��Center=�6$   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6?   
�������$
��Bold"�6�   $��12(�6�   $��NoWrap=�6�   Albums6�   5=      5>      � 5?      $��2��6   $��	10,16,0,0q�6#   .+�5@      ]� .+�5A      �� $ HighQuality=�6    $
��Left=�6N   $7��1../Assets/ControlImages/LeftBar_Icons/Artists.png��6i   $��30��6�   6�   �� 5B      $��Center=�6$   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6?   
�������$
��Bold"�6�   $��12(�6�   $��NoWrap=�6�   	Artists6�   5C      5D      � 5E      $��3��6   $��	10,16,0,0q�6#   .+�5F      ]� .+�5G      �� $ HighQuality=�6    $
��Left=�6N   $6��0../Assets/ControlImages/LeftBar_Icons/Genres.png��6i   $��30��6�   6�   �� 5H      $��Center=�6$   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6?   
�������$
��Bold"�6�   $��12(�6�   $��NoWrap=�6�   Genres6�   5I      5J      � 5K      $��4��6   $��	10,16,0,0q�6#   .+�5L      ]� .+�5M      �� $ HighQuality=�6    $
��Left=�6N   $9��3../Assets/ControlImages/LeftBar_Icons/Playlists.png��6i   $��30��6�   6�   �� 5N      $��3,0,0,0q�6$   $��Center=�65   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6P   
�������$
��Bold"�6�   $��12(�6�   $��NoWrap=�6�   
Playlist6�   5O      5P      5Q      �� 5R      $��-4,0,0,0q�6   $��1��6+   $��3,0,0,0q�6;   ��5S      �� 5T      $		 0,0&�6*   $	
 1,0&�6;   .��5U      � $ Black��6'   $	 0.0Q�65   � 5V      $ 	LightGray��6'   $ 0.005Q�69   5W      ._�5Y      � $��1��6    5Z      �� 5[      $��6* �6+   68   �� 5\      $��4* �6+   68   .+�5^      � $��0��6    5_      �� 5`      $	��75* �6,   6;   �� 5a      $	��25* �6,   6;   .+�5c      � $��0��6    5d      �� 5e   "   $��6* �63   6@   �� 5f   "   $��4* �63   6@   .+�5h      � $��0��6#    5i   "   �� 5j   &   $��9* �64   6B   �� 5k   &   $��1* �64   6B   .+�5m   "   � $��0��6'   .+�66   1   +MP3PlayerProject.ComponentControl.CoverFlow  6S   6p   � 5n   "   $��1��6'    5o   &   �� 5p   *   $��5* �6;   6H   �� 5q   *   $��5* �6;   6H   �� 5r   *   $��2* �6;   6H   .+�5t   &   � $��1��6+   .+�67   1   +MP3PlayerProject.ComponentControl.StarPanel  6T   6q   5u   #   5v      � 5w      $��1��6#   .+�5x   "   �� .+�5y   &   �� $��0,20,0,0q�60   $��WrapWithOverflow=�6B   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6b   
��� ���$
��Bold"�6�   $��25(�6�   Strawberry Fields Forever6�   �� 5z   &   $��WrapWithOverflow=�60   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6P   
�������$
��Bold"�6�   $��30(�6�   The Beatles6�   �� 5{   &   $��WrapWithOverflow=�60   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6P   
�������$
��Bold"�6�   $��10(�6�   '%Sgt. Pepper's Lonely Hearts Club Band6�   �� 5|   &   $��WrapWithOverflow=�60   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6P   
�������$
��Bold"�6�   $��10(�6�   19676�   5}   #   5~      5      � 5�      $��1��6    5�      �� 5�   "   $��3* �63   6@   �� 5�   "   $��6* �63   6@   .+�5�      � $��1��6#    5�   "   �� 5�   &   $��1* �64   6B   �� 5�   &   $��1* �64   6B   .+�5�   "   �� $��1��6-   .+�5�   &   �� $��WrapWithOverflow=�60   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6P   
�������$��15(�6�   $��Bottom=�6�   $��Center=�6�   Let me take you down,6  �� 5�   &   $��WrapWithOverflow=�60   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6P   
�������$��15(�6�   $��Bottom=�6�   $��Center=�6�   ,*‘Cause I’m going to Strawberry Fields,6  5�   #   5�      5�      5�      �� 5�      $��1��6#   $��8q�63   $
��Auto=�6>   $��Disabled=�6a   .��5�      � $��1��6   .+�5�      ,� " ,� VerticalScrollBarVisibility$ Disabled=�64   $ ,� HorizontalScrollBarVisibility$ Disabled=�6[   .��5�   "   /� .T�5�   &   J� -   5         J�Name$ 
Paragraph1��5�   �   
�������$��12(�6C   $>��8/MP3PlayerProject;component/Assets/Fonts/#Century Gothic)�6Q   .*�6�   .*�5�   *   0�  0� HorizontalAlignment$ Right=�62    0� Width$	 150��6N   .t�5�   .   �� .r�5�   2   �� $	��-10q�68   $*��$../Assets/SampleBandFoto/beatles.jpg��6E   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      � 5�      $��2��6   .+�5�      �� $��0,3,0,0q�6   ��5�      �� 5�      $		 0,0&�6*   $	
 0,1&�6;   .��5�      � $ 	LightGray��6'   $	 0.0Q�69   � 5�      $ Black��6'   $ 0.025Q�65   5�      ._�5�      3   -MP3PlayerProject.ComponentControl.BottomPanel  -   5          Name$ BottomPanel��5�   +   5�      5�      5�      5�      