   M S B A M L   `   `   `  ����A  =PL.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PL.WPFPL.WPF  5   	   !    PL.WPF.addLineStationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:PL.WPF     5   	     � Title$  addLineStationWindow��5   	   $	��250��6&   $	��450��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ 	LineIDTBL��5      $
��Left=�6'   $��17��6B   $��	31,29,0,0q�6N   $
��Wrap=�6a   $	��Top=�6u   $	��131��6�   $��line ID:��6�   $��2��6�   �� 5   
   -   5        $��	LineIDTBO��5      $
��Left=�6#   $��17��6>   $��
162,29,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��169��6�   $��2��6�   �� 5   
   -   5        $��StationIndexTBO��5      $
��Left=�6)   $��17��6D   $��
162,85,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��169��6�   $��2��6�   �� 5   
   -   5        $ StationIDBL��5      $
��Left=�6)   $��17��6D   $��	31,51,0,0q�6P   $
��Wrap=�6c   $	��Top=�6w   $	��131��6�   $��station ID:��6�   $��2��6�   �� 5   
   -   5        $ StationIndexTBL��5      $
��Left=�6-   $��29��6H   $��	31,73,0,0q�6T   $
��Wrap=�6g   $	��Top=�6{   $	��131��6�   $%��The station number on the line:��6�   $��2��6�   �� 5   
   -   5        $ PrevStationTBL��5      $
��Left=�6,   $��17��6G   $��
31,107,0,0q�6S   $
��Wrap=�6g   $	��Top=�6{   $	��131��6�   $��previous station:��6�   $��2��6�   �� 5   
   -   5         ��Name$ PrevStationTBO��5      $
��Left=�6*   $��17��6E   $��162,107,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��169��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $��Add station��6$   $
��Left=�6:   $��36��6U   $��145,174,0,0q�6a   $	��Top=�6v   $��89��6�   $��2��6�   �� 5   
   -	   5        $ UpdateButton��5      $��Update station��6'   $
��Left=�6@   $��36��6[   $��145,174,0,0q�6g   $	��Top=�6|   $��89��6�   $��2��6�   �� 5   
   -
   5        $ StationIDBO��5      $
��Left=�6'   $��17��6B   $��
162,51,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��169��6�   $��2��6�   6�   �� 5   
   -   5        $ NextStationTBO��5      $
��Left=�6*   $��17��6E   $��162,129,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��169��6�   $��2��6�   �� 5   
   -   5        $ NextStationTBL��5      $
��Left=�6,   $��17��6G   $��
31,129,0,0q�6S   $
��Wrap=�6g   $	��Top=�6{   $	��131��6�   $��Next Station:��6�   $��2��6�   5      5      