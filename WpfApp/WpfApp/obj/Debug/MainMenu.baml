   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5          WpfApp.MainMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:WpfApp     5        N� Title$  MainMenu��5	      .��5      � -   5        $
��1064��5      $	��571��6   $��Bottom=�6%   
�������.+�5   
   �� $��Добавить��6   $��106,37,872,0q�6$   $	��Top=�6:   $��33��6R   $��16(�6^   �� 5   
   -   5         ��Name$ 	addEmploy��5      $+��%Добавить сотрудника��6$   $
��Left=�6B   $��	51,94,0,0q�6]   $	��Top=�6p   $	��208��6�   $��40��6�   $��16(�6�    � Cursor$
 Hand��6�   6�   �� 5   
   -   5        $ addTech��5      $%��Добавить технику��6"   $
��Left=�6=   $��
51,162,0,0q�6X   $	��Top=�6l   $	��208��6�   $��40��6�   $��16(�6�   $
 Hand��6�   �� 5   
   -   5        $ addSysCharacter��5      $
��Left=�6-   $��
51,228,0,0q�6H   $	��Top=�6\   $	��208��6t   $��66��6�   $
 Hand��6�   .��5      �� $D��>Добавить истемные характеристики��6   $
��Wrap=�5       �� TextAlignment$ Center=�6$   $��16(�6;   5      �� 5   
   -   5        $ addHDD��5      $
��Left=�6$   $��
51,319,0,0q�6?   $	��Top=�6S   $	��208��6k   $��66��6w   $��16(�6�   $
 Hand��6�   .��5      �� $.��(Добавить жёсткий диск��6   $
��Wrap=�5      $ Center=�6$   5      �� 5   
   $��
Найти��6   $��381,37,612,0q�6!   $	��Top=�67   $��33��6O   $��16(�6[   �� 5   
   -   5        $ findTechByEmploy��5      $
��Left=�6.   $��
306,94,0,0q�6I   $	��Top=�6]   $	��208��6u   $��53��6�   $
 Hand��6�   .��5      �� $9��3Поиск техники по сотруднику��6   $
��Wrap=�5      $ Center=�6%   $��16(�6<   5      �� 5   
   -   5        $ findEmployByCSO��5      $
��Left=�6-   $��306,162,0,0q�6H   $	��Top=�6]   $	��208��6u   $��53��6�   $
 Hand��6�   .��5      �� $>��8Поиск сотрудника по номеру ЦСО��6   $
��Wrap=�5      $ Center=�6%   $��16(�6<   5      �� 5    
   -   5        $ findEmployByRoom��5       $
��Left=�6.   $��306,241,0,0q�6I   $	��Top=�6^   $	��208��6v   $��53��6�   $
 Hand��6�   .��5!      �� $H��BПоиск сотрудника по номеру кабинета��6   $
��Wrap=�5"      $ Center=�6%   $��16(�6<   5#      �� 5$   
   -	   5        $ findHDDByEmploy��5$      $
��Left=�6-   $��306,319,0,0q�6H   $	��Top=�6]   $	��208��6u   $��53��6�   $
 Hand��6�   .��5%      �� $B��<Поиск жёсткий диск по сотруднику��6   $
��Wrap=�5&      $ Center=�6%   $��16(�6<   5'      �� 5(   
   $��Изменить��6   $��630,37,337,0q�6$   $	��Top=�6:   $��33��6R   $��16(�6^   �� 5*   
   -
   5        $ changeEmploy��5*      $
��Left=�6*   $��
560,94,0,0q�6E   $	��Top=�6Y   $	��208��6q   $��53��6}   $
 Hand��6�   .��5+      �� $;��5Изменить данные о сотруднике��6   $
��Wrap=�5,      $ Center=�6%   $��16(�6<   5-      �� 5.   
   -   5        $ changeTechInfo��5.      $
��Left=�6,   $��560,162,0,0q�6G   $	��Top=�6\   $	��208��6t   $��53��6�   $
 Hand��6�   .��5/      �� $5��/Изменить данные о технеке��6   $
��Wrap=�50      $ Center=�6%   $��16(�6<   51      �� 52   
   -   5        $ changeSystemCharac��52      $
��Left=�60   $��560,319,0,0q�6K   $	��Top=�6`   $	��208��6x   $��53��6�   $
 Hand��6�   .��53      �� $F��@Изменить системные характеристики��6   $
��Wrap=�54      $ Center=�6%   $��16(�6<   55      �� 56   
   -   5        $ changeHDDIonfo��56      $
��Left=�6,   $��560,241,0,0q�6G   $	��Top=�6\   $	��208��6t   $��53��6�   $
 Hand��6�   .��57      �� $@��:Изменить данные о жёстком диске��6   $
��Wrap=�58      $ Center=�6%   $��16(�6<   59      �� 5;   
   $��Удалить��6   $��880,37,97,0q�6#   $	��Top=�68   $��33��6P   $��16(�6\   �� 5<   
   -   5        $ removeEmploy��5<      $
��Left=�6*   $��
815,94,0,0q�6E   $	��Top=�6Y   $	��208��6q   $��53��6}   $
 Hand��6�   .��5=      �� $)��#Удалить сотрудника��6   $
��Wrap=�5>      $ Center=�6%   $��16(�6<   5?      �� 5@   
   -   5        $ 
removeTech��5@      $
��Left=�6(   $��815,162,0,0q�6C   $	��Top=�6X   $	��208��6p   $��53��6|   $
 Hand��6�   .��5A      �� $#��Удалить технику��6   $
��Wrap=�5B      $ Center=�6%   $��16(�6<   5C      �� 5D   
   -   5        $ 	removeHDD��5D      $
��Left=�6'   $��815,241,0,0q�6B   $	��Top=�6W   $	��208��6o   $��53��6{   $
 Hand��6�   .��5E      �� $,��&Удалить жёсткий диск��6   $
��Wrap=�5F      $ Center=�6%   $��16(�6<   5G      �� 5H   
   -   5        $ 	allEmploy��5H      $
��Left=�6'   $��
51,460,0,0q�6B   $	��Top=�6V   $	��208��6n   $��43��6z   $��16(�6�   $
 Hand��6�   .��5I      �� $2��,Список всех сотрудников��6   $
��Wrap=�5J      $ Center=�6%   5K      �� 5L   
   -   5        $ allHDD��5L      $
��Left=�6$   $��306,460,0,0q�6?   $	��Top=�6T   $	��208��6l   $��43��6x   $��16(�6�   $
 Hand��6�   .��5M      �� $7��1Список всех жёстких дисков��6   $
��Wrap=�5N      $ Center=�6%   5O      �� 5P   
   -   5        $ allTech��5P      $
��Left=�6%   $��560,460,0,0q�6@   $	��Top=�6U   $	��208��6m   $��43��6y   $��16(�6�   $
 Hand��6�   .��5Q      �� $*��$Список всёй техники��6   $
��Wrap=�5R      $ Center=�6%   5S      �� 5T   
   -   5        $ 	allCharac��5T      $
��Left=�6'   $��815,460,0,0q�6B   $	��Top=�6W   $	��208��6o   $��43��6{   $��16(�6�   $
 Hand��6�   .��5U      �� $6��0Список всех характиристик��6   $
��Wrap=�5V      $ Center=�6%   5W      �� 5X   
   $#��Простая выборка��6   $��470,403,451,0q�6+   $	��Top=�6B   $��33��6Z   $��16(�6f   5Y      5Z      