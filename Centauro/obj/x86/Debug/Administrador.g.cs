﻿#pragma checksum "C:\Users\CSIRT\Desktop\Centauro\Centauro\Administrador.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6F76A68E64EFD9C5D4A0CBFABDC1D0F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Centauro
{
    partial class Administrador : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Split = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.HamburguerButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 94 "..\..\..\Administrador.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.HamburguerButton).Click += this.HamburguerButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.BtnTempRefri = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 98 "..\..\..\Administrador.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.BtnTempRefri).Click += this.BtnTempRefri_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.BtnTempDesh = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 100 "..\..\..\Administrador.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.BtnTempDesh).Click += this.BtnTempDesh_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.BtnHistFallas = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 102 "..\..\..\Administrador.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.BtnHistFallas).Click += this.BtnHistFallas_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.BtnTecnico = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 108 "..\..\..\Administrador.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.BtnTecnico).Click += this.BtnTecnico_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.logOut = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 111 "..\..\..\Administrador.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.logOut).Click += this.logOut_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
