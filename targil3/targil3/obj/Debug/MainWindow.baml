   M S B A M L   `   `   `  ����B  >targil3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:targil3targil3  5   	       targil3B.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:targil3     5   	     � Icon$  wow.ico��5	   	    � Title$
 MNSN��5
   	   $	��640��6   $	��900��6#   .��5      � -   5        $��GridMain��5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF74FF00��6    � Offset$ 0Q�61   � 5      $ 	#FF24C4C7��6   $ 1Q�61   � 5      $ 	#FF00E8FF��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5        $��	mainlabel��5      $!��                  m&s buses��6!   $��82��6K   $	��640��6W    J� RenderTransformOrigin$ 
0.518,0.59&�6c   $��40(�6�   $��	ExtraBold"�6�   $��Italic$�6�   $��10,0,143.6,528.4q�6�   $��2��6�   �� 5   
   -   5         ��Name$ buslist��5      $	��524��6$   $ 0.5,0.5&�6b   
���   �
���   �$��0,87,121.6,-0.6q�6�   $��2��6�   	 J� OpacityMask
	 �   ���6L   Z� 
 �� View
 5      �� 5      .P�5      �� $��license bus number��6%    �� Width$
 auto��6A    �� DisplayMemberBinding 6O   �� *pID+�� 5      $��last treatment��6%   $	 100��6=    6I   �� *	plastDate+�� 5      $��km since treatment��6%   $	 105��6A    6M   �� *pckm+�� 5       $	��gas��6%   $
 auto��62    6?   �� *pGaz+�� 5!      $��Time untill return��6%   $
 auto��6A    6N   �� *pTime+�� 5"      $�� ��6%   $
 auto��6/    �� CellTemplate 5#      �� 5$      .R�5%   "   ��  ��Name$ GoForRid��6)   -   5        $��New Ride��5%   M   ��6`   �� *pColor+5&      5(      �� 5)      $�� ��6%   $
 auto��6/    5*      �� 5+      .R�5,   "   �� $ 	RefillGaz��6)   -   5        $��
Refill Gaz��5,   U   5-      5/      �� 50      $�� ��6%   $
 auto��6/    51      �� 52      .R�53   "   �� $ Repair��6)   -   5        $��Repair��53   O   54      56      57      59      � 5:   
   $��1��6   $��Right=�6   $	��122��69   
�������.+�5;      �� -   5        $��addbus��5;   *   $��add bus��68   $
��Left=�6J   $��Bottom=�6e   $	��122��6�   $��57��6�   $��Segoe UI Black)�6�   $��20(�6�   $��	0,0,0,494q�6�   $
��Bold"�6�   #��� ��6�   ��5<      �� 5=      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5>      � $ 	#FFB405FC��6'   � 5?      $ 	#FFFF870D��6'   $ 1Q�69   5@      5B      �� 5C      -   5        $��	Removebus��5C   (   $��
Remove Bus��69   $
��Left=�6N   $��Bottom=�6i   $	��122��6�   $��57��6�   $��Segoe UI Black)�6�   $��18(�6�   $��0,0,0,438.4q�6�   $
��Bold"�6�   #��� ��6�   ��5D      �� 5E      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5F      � $ 	#FFB405FC��6'   � 5G      $ 	#FFFF870D��6'   $ 1Q�69   5H      5J      �� 5K      -	   5        $��Random��5K   '   $��Random��65   $
��Left=�6F   $��Bottom=�6a   $	��122��6|   $��57��6�   $��Segoe UI Black)�6�   $��18(�6�   $��0,0,0,382.4q�6�   $
��Bold"�6�   #��� ��6�   ��5L      �� 5M      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5N      � $ 	#FFB405FC��6'   � 5O      $ 	#FFFF870D��6'   $ 1Q�69   5P      5R      �� 5S      -
   5        $��	menulabel��5S      $��	     Menu��6%   $
��Left=�69   $��37��6T   $��Bottom=�6`   $	��122��6{   $��	0,0,0,560q�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   5T      5U      5V      