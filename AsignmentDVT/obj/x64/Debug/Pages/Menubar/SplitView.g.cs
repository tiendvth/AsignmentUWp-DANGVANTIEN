﻿#pragma checksum "C:\Users\LE DIEP\source\repos\AsignmentDVT\AsignmentDVT\Pages\Menubar\SplitView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8791359582D2E64A74317309AC156A12C2CDC159CF917F7DF7B44E3AC28A861"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsignmentDVT.Pages.Menubar
{
    partial class SplitView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Menubar\SplitView.xaml line 17
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // Pages\Menubar\SplitView.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element3 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element3).Tapped += this.SymbolIcon_Tapped;
                }
                break;
            case 4: // Pages\Menubar\SplitView.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element4 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element4).Tapped += this.StackPanel_Tapped;
                }
                break;
            case 5: // Pages\Menubar\SplitView.xaml line 26
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element5 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element5).Tapped += this.StackPanel_Tapped;
                }
                break;
            case 6: // Pages\Menubar\SplitView.xaml line 28
                {
                    this.LoginLink = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Pages\Menubar\SplitView.xaml line 34
                {
                    this.MyContent = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
