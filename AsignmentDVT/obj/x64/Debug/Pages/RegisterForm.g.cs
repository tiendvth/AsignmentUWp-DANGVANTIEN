#pragma checksum "C:\Users\LE DIEP\source\repos\AsignmentDVT\AsignmentDVT\Pages\RegisterForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F39BE1B133C280EE100E8B4A44485F877D3E73E288FC3D1B60CC1190038FDE4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsignmentDVT.Pages
{
    partial class RegisterForm : 
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
            case 2: // Pages\RegisterForm.xaml line 11
                {
                    this.main = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Pages\RegisterForm.xaml line 28
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Pages\RegisterForm.xaml line 30
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\RegisterForm.xaml line 50
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Pages\RegisterForm.xaml line 52
                {
                    this.dataPicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 7: // Pages\RegisterForm.xaml line 53
                {
                    this.Introduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\RegisterForm.xaml line 60
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element8 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element8).Click += this.HyperLogin;
                }
                break;
            case 9: // Pages\RegisterForm.xaml line 61
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element9 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element9).Click += this.HyperMenu;
                }
                break;
            case 10: // Pages\RegisterForm.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Btn_Save;
                }
                break;
            case 11: // Pages\RegisterForm.xaml line 46
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element11 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element11).Checked += this.RadioButton_Checked;
                }
                break;
            case 12: // Pages\RegisterForm.xaml line 47
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element12 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element12).Checked += this.RadioButton_Checked;
                }
                break;
            case 13: // Pages\RegisterForm.xaml line 48
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element13 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element13).Checked += this.RadioButton_Checked;
                }
                break;
            case 14: // Pages\RegisterForm.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.Handle_Camera;
                }
                break;
            case 15: // Pages\RegisterForm.xaml line 41
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element15 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element15).Click += this.Handle_Upload_Image;
                }
                break;
            case 16: // Pages\RegisterForm.xaml line 42
                {
                    this.ProcessRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 17: // Pages\RegisterForm.xaml line 37
                {
                    this.PreviewPhoto = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 18: // Pages\RegisterForm.xaml line 23
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 19: // Pages\RegisterForm.xaml line 25
                {
                    this.ConfirmPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 20: // Pages\RegisterForm.xaml line 17
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21: // Pages\RegisterForm.xaml line 19
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

