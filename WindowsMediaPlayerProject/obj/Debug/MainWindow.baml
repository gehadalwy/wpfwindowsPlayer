   M S B A M L   `   `   `  ����T  PWindowsMediaPlayerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WindowsMediaPlayerProjectWindowsMediaPlayerProject  5   	   *    $WindowsMediaPlayerProject.MainWindow   5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WindowsMediaPlayerProject     5   	     � Title$  windows media player��5   	   $	��350��6&   $	��675��63    � TaskbarItemInfo 5	      *  $System.Windows.Shell.TaskbarItemInfo  5
   
   -   5        prg��   ProgressValue$ 0Q�5
   '      ProgressState$ Normal=�69      ThumbButtonInfos 5      *  $System.Windows.Shell.ThumbButtonInfo  -   5           Description$
 play��5   "      ImageSource$[ UI:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/play.jpg��65   6�     5      -   5        $
 Stop��5   "   $[ UI:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/stop.png��65   6�     5      -   5        $ Pause��5   "   $\ VI:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/pause.png��66   6�   5      .��5      � .+�5   
   o� $��	0,0,0,286q�6   $��1��6"   .@�5      m� -   5        $��_Open��5      6&   5      �� 5   
   -   5        $
��Stop��5      $
��Left=�67   $	��Top=�6R   $��55��6j   $��113,204,0,0q�6u   $��43��6�   ��5      �� 5       �� 
TargetType" ��6"   .R�5      � .+�5      A� 
���   �$��2��5      5      �� 5      $��Center=�6+   $��Center=�5    #   5!      5"      5$      �� 5%   
   -   5        $��pause��5%      $
��Left=�68   $	��Top=�6S   $��52��6k   $��229,204,0,0q�6v   $��43��6�   ��5&      �� 5'      " ��6"   .R�5(      � .+�5)      A� 
���   �$��2��5*      5+      �� 5,      $��Center=�6+   $��Center=�5-   #   5.      5/      51      � 52   
   -   5        $��PB��52   >   $
��Left=�6i   $��16��6�   $��
53,262,0,0q�6�   $	��Top=�6�   $	��420��6�   r� 53   
   -	   5        $��aMedia��53      $
��Left=�6G   $	��192��6b   $	��Top=�6o   $	��471��6�   $��0,20,0,0q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�54      V� 55      .~�56      �� �� 57      	 �� AngleX$	 -1.332Q�6$   �� 58      T� 59      
 T� X$
 -1.977Q�6)   5:      5<      �� 5=   
   -
   5        $��
slider_vol��5=   E   $
��Left=�6   $	��Top=�6-   $��319,175,0,0q�6W   $	��152��6l   6x   �� 5>   
   -   5        $��backwardbtn��5>   >   $��backward��6+   $
��Left=�6Q   $��
62,205,0,0q�6l   $	��Top=�6�   $��52��6�   $��42��6�   $ 0.5,0.5&�6�   z�5?      V� 5@      .~�5A      �� �� 5B      �� 5C       �� Angle$ -0.211Q�6&   T� 5D      5E      ��5G      �� 5H      " ��6"   .R�5I      � .+�5J      A� 
���   �$��2��5K      5L      �� 5M      $��Center=�6+   $��Center=�5N   #   5O      5P      5R      �� 5S   
   -   5        $��
forwardbtn��5S   =   $��forward��6+   $
��Left=�6O   $��281,204,0,0q�6j   $	��Top=�6   $��54��6�   $��43��6�   ��5T      �� 5U      " ��6"   .R�5V      � .+�5W      A� 
���   �$��2��5X      5Y      �� 5Z      $��Center=�6+   $��Center=�5[   #   5\      5]      5_      �� 5`   
   -   5        $	��lbl��5`      $��00.00��6   $
��Left=�6,   $��488,278,0,0q�6G   $	��Top=�6\   $��45��6t   �� 5a   
   -   5        $
��lbl2��5a      $��00.00��6   $
��Left=�6-   $��
10,262,0,0q�6H   $	��Top=�6\   �� 5b   
   -   5        $��lstbx��5b   <   $
��Left=�6I   $	��207��6d   $��
476,71,0,0q�6q   $	��Top=�6�   $	��181��6�   $��0q�6�   �� 5c   
   -   5        $
��Play��5c      $
��Left=�6    $	��Top=�6Q   $��61��6i   $��59��6t   $��168,196,0,0q�6�   ��5d      �� 5e      " ��6"   .R�5f      � .+�5h      A� 
���   �$��2��5i      5j      �� 5k      $��Center=�6+   $��Center=�5l   #   $��18,22,19,21q�6>   5m      5n      5p      5v      5w      