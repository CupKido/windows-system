   M S B A M L   `   `   `  ����A  =PL.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PL.WPFPL.WPF  5   	       PL.WPF.UserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:PL.WPF     5   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ StationsList��5
      $��16(�6)    J� RenderTransformOrigin$ 0.5,0.5&�67   $
��Left=�6W   $	��372��6r   $	��384��6   $��0,48,0,0q�6�   $	��Top=�6�    �� View 5      �� 5      .P�5      �� $
��Code��6%    �� Width$ 50��63    �� DisplayMemberBinding 6>   �� *Code+�� 5      $
��Name��6%   $	 200��63    6?   �� *Name+5      5      �� 5   
   -   5         ��Name$ ClockTBO��5      $��00:00:00��6&   $��30(�66   $��506,10,146.6,367q�6D   �� 5   
   $��
 Moovit V2��6   $��24(�6&   $��Center=�64   $	��118��6Q   $��40��6]   $��367,0,408.6,570.4q�6j   �� 5   
   -   5        $ UserName��5       �� TextAlignment$ Center=�6&   $�� ��6=   $��15(�6E   $��Center=�6S   $	��175��6p   $��30��6|   $��0,0,618.6,390q�6�   �� 5   
   -   5        $�� Log Off��5      $ Center=�6$   $��10(�6^   $��Center=�6l   $��62��6�   $��20��6�   $��-1,28,732.6,372q�6�   �� 5   
   -   5        $�� User Details��5      $ Center=�6)   $��10(�6h   $��Center=�6v   $��62��6�   $��20��6�   $��61,28,670.6,372q�6�   �� 5   
   -   5         ��Name$ SimClockButton��5      $��Start Simulator��6)   $��561,58,146.6,328q�6a   �� 5   
   -   5        $ AskDataButton��5      $��insert Data��6(   $��469,58,238.6,328q�6[   �� 5   
   -   5        $ listView��5      $
��Left=�6%   $	��228��6@   $��402,165,0,0q�6M   $	��Top=�6b   $	��374��6z    5      �� 5      .P�5      �� $
��line��6%   $ 50��63   5      5       5!      5"      