   M S B A M L   `   `   `  ����E  ASortBF_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SortBF_WPF
SortBF_WPF  5   	       SortBF_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SortBF_WPF     5   	     � Title$?  9Внешняя сортировка двух файлов��5   	   $	��450��60   $	��800��6=   .��5	      � .+�5
   
   �� -   5        $,��&Генерация Int64 (с повт)��5
      $
��Left=�64   $��9,87,0,0q�6O   $	��Top=�6a   $	��154��6y   $��31��6�   6�   �� 5   
   $
��Left=�6   $��23��6-   $��178,326,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��120��6z   �� 5   
   $
��Left=�6   $��	9,333,0,0q�6/   $
��Wrap=�6B   $'��!Укажите maxLine (8-200000)��6V   $	��Top=�6x   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $7��1Генерация тестовых данных:��6V   $	��Top=�6x   �� 5   
   $
��Left=�6   $��
11,231,0,0q�6/   $
��Wrap=�6C   $��Сортировка:��6W   $	��Top=�6j   �� 5   
   $
��Left=�6   $��
10,260,0,0q�6/   $
��Wrap=�6C   $1��+Укажите адрес файла № 1:��6W   $	��Top=�6w   �� 5   
   $
��Left=�6   $��
10,296,0,0q�6/   $
��Wrap=�6C   $1��+Укажите адрес файла № 2:��6W   $	��Top=�6w   �� 5   
   $
��Left=�6   $��23��6-   $��178,253,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��208��6z   �� 5   
   $
��Left=�6   $��23��6-   $��178,289,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��208��6z   �� 5   
   $��
Обзор��6   $
��Left=�6!   $��403,256,0,0q�6<   $	��Top=�6Q   $��60��6i   �� 5   
   $��
Обзор��6   $
��Left=�6!   $��403,292,0,0q�6<   $	��Top=�6Q   $��60��6i   �� 5   
   $��
Старт��6   $
��Left=�6!   $��
11,365,0,0q�6<   $	��Top=�6P   $��75��6h   �� 5   
   $
��Left=�6   $��
506,14,0,0q�6/   $
��Wrap=�6C   $)��#Статус выполнения: ��6W   $	��Top=�6r   �� 5   
   $
��Left=�6   $��
627,13,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��92��6o   �� 5   
   $
��Left=�6   $��
506,37,0,0q�6/   $
��Wrap=�6C   $"��Номер итерации:��6W   $	��Top=�6n   �� 5   
   $
��Left=�6   $��
627,37,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��92��6o   �� 5   
   $
��Left=�6   $��
11,123,0,0q�6/   $
��Wrap=�6C   $'��!Статус генерации: ��6W   $	��Top=�6q   �� 5   
   -   5         ��Name$ 	GenLength��5      $
��Left=�6%   $��23��6@   $��
166,27,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   $
��Left=�6   $��	11,34,0,0q�6/   $
��Wrap=�6B   $-��'Укажите длинну файла:��6V   $	��Top=�6s   �� 5   
   -   5        $ GenPath��5      $
��Left=�6#   $��23��6>   $��
166,51,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   $
��Left=�6   $��	11,58,0,0q�6/   $
��Wrap=�6B   $+��%Укажите адрес файла:��6V   $	��Top=�6r   �� 5   
   $��
Обзор��6   $
��Left=�6!   $��
300,54,0,0q�6<   $	��Top=�6P   $��60��6h   �� 5    
   -   5         ��Name$ status��5       $
��Left=�6$   $��118,123,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $��93��6�   5"      5#      