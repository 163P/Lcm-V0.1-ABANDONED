   M S B A M L   `   `   `  ���� M  ILcmCallEngineN3GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LcmCallEngineN3GUILcmCallEngineN3GUI  #    LcmCallEngineN3GUI.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:LcmCallEngineN3GUI       � Title$  LcmCallEngineN3GUI��$	��350��$��604.333��.���  � RowDefinitions �� $
��Auto ��� .+��  � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -    ��Name$ SynthesizerGroup��$��Synthesizer��$��0��$
��Left=�$	��Top=�.���  �� $
��Auto ��� $��4 ��� $	��100 ��� $��4 ���  �� �� $��4 ��� �� $��4 ��� .+��� $
��Wrap=�$��VoiceSource���� -    ��Name$ VoiceSource��$��0��$��2��$	��Top=�$��3��.@� � -     �Name$ frame��$��Hengjing��$	��100��$	��100���� $��2��$��0��$
��Wrap=�$��UST Path���� -    ��Name$ UstPath��$��2��$��2���� -   $��2��$��4��$��Choose���� $��4��$��0��$
��Wrap=�$��Resampler Path���� -   $ R_Path��$��4��$��2���� -   $��4��$��4��$��Choose���� -   $ SynthesisEffectGroup��$��Synthesis Effect��$��1��$
��Left=�$	��Top=�.���  �� �� $��4 ��� �� $��4 ���  �� $
��Auto ��� $��4 ��� $	��100 �.+��� $��辅音速度��$
��Left=��� -	   $ Con_SP��$��0��$��2��$	��100���� $��范围传参��$��2��$��0��$
��Left=��� -
   $	 Par��$��2��$��2��$��e���� $��分度重叠值��$��4��$��0��$
��Left=��� -   $	 Fra��$��4��$��2��$��8���� -   $ 	MiscGroup��$
��Misc��$��2��$
��Left=�$	��Top=�.���  �� �� $��4 ��� $��17 ��� $��4 ���  �� $
��Auto ��� $��4 ��� $	��100 �.+��� $��容错发音��$��0��$��0��$
��Left=��� -   $ Err_Pro��$��0��$��2��$��a���� $��容错音高��$��2��$��0��$
��Left=��� -   $ Err_Pit��$��2��$��2��$��C4���� $��合成范围��$��4��$��0��$
��Left=��� -   $
 Time��$��4��$��2��$��20��� $��1��.+��� -    ��Name$ Compose��$��Compose��$��96(�
���  ��