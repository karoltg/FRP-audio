   M S B A M L   `   `   `  ����J  FFRP audioplayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FRP_audioplayerFRP_audioplayer  5   	        FRP_audioplayer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FRP_audioplayer     5   	     � Title$  
MainWindow��5   	   $	��622��6   $	��901��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ Play1��5
      $
��Play��6    $
��Left=�60   $��
272,28,0,0q�6K   $	��Top=�6_   $��61��6w   $��56��6�   6�   �� 5   
   -   5        $ Play2��5      $
��Play��6    $
��Left=�6/   $��272,109,0,0q�6J   $	��Top=�6_   $��61��6w   $��56��6�   6�   �� 5   
   -   5         ��Name$ Background_Volume��5      $
��Left=�6,    � Minimum$ 0Q�6G    � Maximum$	 100Q�6S   $��
351,49,0,0q�6a   $	��Top=�6u   $	��301��6�   6�   �� 5   
   -   5        $ Environment_Volume��5      $
��Left=�6-   $ 0Q�6H   $	 100Q�6T   $��351,129,0,0q�6b   $	��Top=�6w   $	��301��6�   6�   �� 5   
   $��Volume��6   $
��Left=�6!   $��
363,28,0,0q�6<   $	��Top=�6P   �� 5   
   $��Volume��6   $
��Left=�6!   $��363,109,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5         ��Name$ BackgroundList��5      $
��Left=�6^   $	��293��6y   $��
21,259,0,0q�6�   $	��Top=�6�   $	��238��6�    �� View 5      �� 5      .P�5      �� 5      5      �� 5   
   -   5        $ EnvironmentList��5      $
��Left=�6`   $	��295��6{   $��289,257,0,0q�6�   $	��Top=�6�   $	��240��6�    5      �� 5      .P�5      �� 5      5      �� 5   
   -   5        $��Button��5      $
��Left=�6"   $��
42,142,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   5      5       