   M S B A M L   `   `   `  ????B  >MilcanX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MilcanXMilcanX  5   	       MilcanX.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MaterialDesignThemes.MahApps, Version=0.2.7.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   #localclr-namespace:MilcanX   5   	     ? WindowStyle$
  None=?5
   	    ? Title$ 
MainWindow??5   	   $	??600??6   $	??800??6)    ? 
ResizeMode$ NoResize=?65    ? WindowStartupLocation$ CenterScreen=?6K   .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??133 ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      $	??180 ?6   ?? 5      .+?5   
   ?? $??0??6   $??0??6   ???	#FF7DA186._?5      ?  5      ?? 5      $??35 ?6$   ?? 5      .+?5      ?? $??0??6   ._?5      ]? $??Center=?6    $??Center=?6;   .+?5      ?? $??Image/manTheWhite.png??6    $??24??6?   $??24??6K   ?? 5       $??KÜTÜPHANE PROGRAMI??6    
???????$
??Bold"?6P   $??Center=?5!       $??Center=?6=   5#      5$      ?? 5%      $??1??6   ._?5&      ]? $??Center=?6    $??Center=?6;   .+?5'      ?? ??5(      ?? 5)   "    ?? 
TargetType" ??6(   .?5*   &   ??  ?? Property ? ?? ?? Value$ image\document.jpg??6?   ?? 5+   &    ? ??$ 90??6?   ?? 5,   &    ? ??$ 90??6>   	 ?? Triggers	 5-   &   P? 5.   *   
 P? Property
 ?@J?IsMouseOver P? Value$
 True??6I   . ?5/   .   ??  ? ??$ image\document.jpg??6G   ?? 50   .    ? ??$	 100??6G   ?? 51   .    ? ??$	 100??6F   52   +   54   #   56      58      59      5:      5<      ?? 5@   
   $??0??6   $??1??6   ???	#FF7DA186._?5A      ?  5B      ?? 5C      $??27 ?6$   ?? 5D      .+?5G      ?? $??0??6   
???????._?5H      ]? $??Right=?6"   $	??166??6>   .+?5I      ?? -   5         ??Name$ btnSimge??5I   !   $??__??63   
???  ??$??0 0 0 0q?6Q      miniButonlar#???   6b   6?   ?? 5J      -   5        $ 	btnBuyult??5J   !   $	??|_|??65   
???  ??$??0 0 0 0q?6T   #???   6e   6?   ?? 5K      -   5        $ btnKapat??5K   !   $??X??63   
???  ??#???   6Q   6x   5L      5M      ?? 5O      $??1??6   
?????? ._?5P      ?? $
??Left=?6!   $??Center=?6<    ?? Orientation$ 
Horizontal=?6W   .+?5Q      ?? -   5        ???	#FFF3CCCC$??30??5Q   9   $??80??6E   $??Center=?5R   "   $??Center=?6D   $??
50 0 400 0q?5S   $   ?? 5T      -   5        $ btnAdd??5T   !   $	??ADD??61   6?   5U      5X      5[      5\      ?? 5_   
   $??1??6   $??0??6   ???	#FF7DA186._?5a      ?? .+?5b      ?? -   5        $ btnProductList??5b   L   $??60??6     menuButonlar#???  6%   .??5c      ]? $	??165??6    $??15 0 0 0q?6,   .+?5d      ?? $??/Image/reading.png??6    $??45??6<   $??45??6G   ?? 5e      $??Products??6    $??Center=?64   
???????$??14(?6b   $
??Bold"?6p   5f      5g      ?? 5i      -   5        $ btnEmployee??5i   L   $??60??6   #???  6%   .??5j      ]? $	??165??6    $??15 0 0 0q?6,   .+?5k      ?? $??/Image/books.png??6    $??45??6:   $??45??6E   ?? 5l      $??Employee??6    $??Center=?64   
???????$??14(?6b   $
??Bold"?6p   5m      5n      ?? 5p      $??60??6   #???  6%   .??5q      ]? $	??165??6    $??15 0 0 0q?6,   .+?5r      ?? $??/Image/checklist.png??6    $??45??6>   $??45??6I   ?? 5s      $??Emanet Listesi??6    $??Center=?6:   
???????$??14(?6h   $
??Bold"?6v   5t      5u      ?? 5w      $??60??6   #???  6%   .??5x      ]? $	??165??6    $??15 0 0 0q?6,   .+?5y      ?? $??/Image/calendar.png??6    $??45??6=   $??45??6H   ?? 5z      $??Zamanı Dolanlar??6    $??Center=?6;   
???????$??14(?6i   $
??Bold"?6w   5{      5|      ?? 5~      $??60??6   #???  6%   .??5      ]? $	??165??6    $??15 0 0 0q?6,   .+?5?      ?? $??/Image/setting.png??6    $??45??6<   $??45??6G   ?? 5?      $??Ayarlar??6    $??Center=?62   
???????$??14(?6`   $
??Bold"?6n   5?      5?      ?? 5?      $??60??6   #???  6%   .??5?      ]? $	??165??6    $??15 0 0 0q?6,   .+?5?      ?? $??/Image/info.png??6    $??45??69   $??45??6D   ?? 5?      $??	Hakkında??6    $??Center=?64   
???????$??14(?6b   $
??Bold"?6p   5?      5?      ?? 5?      .+?5?      ?? $??26??6   $??55??6)    ?? Left$ 58??64    ?? CornerRadius$ 10 10 10 10??6F   $??Center=?6a   $	??Top=?6~   ._?5?      ?? $??10.0.0.1??6    $
??Bold"?63   $	??Top=?6F   ??5?      ?? 5?      " ??6$   .?5?   "   ??  ? ?? ?	#7F4EA09D6?   	 5?   "   P? 5?   &   
 ?@J?IsMouseOver$
 True??6E   . ?5?   *   ??  ? ?? ?	#7F317C7A6G   5?   '   5?      5?      5?      5?      5?      ?? 5?   
   -   5         ??Name$ 
grDataPage??5?      $??1??6%   $??1??62   ???	#FF97B7B7._?5?      &   System.Windows.Controls.DataGrid  -	   5          Name$ dgProductList??5?         AlternatingRowBackground ?	#FFD2E399??6.   ??    Columns 5?      4  .System.Windows.Controls.DataGridTemplateColumn  5?         CellTemplate 5?      ?? 5?      .R?5?   "   ?? $ btnEdit??68   -
   5        $
??Edit??5?   )   6I   5?      5?        5?       5?      ?? 5?      .R?5?   "   ?? $ 	btnDelete??6:   -   5        $??Delete??5?   )   6M   5?      5?      5?      5?      5?      5?      