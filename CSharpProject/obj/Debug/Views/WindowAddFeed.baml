   M S B A M L   `   `   `  ����H  DCSharpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CSharpProject.ViewsCSharpProject.Views  5   	   '    !CSharpProject.Views.WindowAddFeed   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CSharpProject.Views     5   	   -   5          �Name$  WindowAddFeed1��5   	    � Title$ Add Feed��5   	   $	��300��6   $��451.705��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��67* �6   �� 5      $
��225* �6   .+�5   
   �� -   5         ��Name$ labelUrl��5      $��Insert url:��6"   $
��Left=�68   $��	10,10,0,0q�6S   $	��Top=�6f    J� RenderTransformOrigin$ -0.099,0.517&�6~   �� 5   
   -   5         ��Name$ 
textBoxUrl��5      $��2��6&   $
��Left=�6:   $��23��6U   $��	10,36,0,0q�6a    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��424��6�   6�   �� 5   
   -   5        $ 
labelTitle��5      $��Title:��6$   $
��Left=�65   $��	10,64,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ labelTitleShow��5      $�� ��6(   $
��Left=�63   $��	10,90,0,0q�6N   $	��Top=�6a   $��2��6y   $	��424��6�   �� 5   
   -   5         ��Name$ 	buttonAdd��5      $	��Add��6$   $��1��62   $
��Left=�6B   $��177,238,0,0q�6]   $	��Top=�6r   $��75��6�   $ 
0.316,0.59&�6�   6�   �� 5   
   -   5        $ labelCategory��5      $��Category��6'   $
��Left=�6:   $��
10,156,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ textBoxCategory��5      $��2��6+   $
��Left=�6?   $��23��6Z   $��
10,182,0,0q�6f   $
 Wrap=�6z   $	��Top=�6�   $	��226��6�   �� 5   
   -	   5        $ buttonClose��5      $��Close��6&   $��1��66   $
��Left=�6F   $��257,238,0,0q�6a   $	��Top=�6v   $��75��6�   6�   5      5      