﻿#pragma checksum "C:\Users\Carlos Mario\Documents\Visual Studio 2015\Projects\Centauro\Centauro\TemperaturaDeshidratadora.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F11923C693C603737FB88FD3979050A8"
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
    partial class TemperaturaDeshidratadora : 
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
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.comboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 89 "..\..\..\TemperaturaDeshidratadora.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.comboBox).SelectionChanged += this.comboBox_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.DatePickerToChart = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                    #line 92 "..\..\..\TemperaturaDeshidratadora.xaml"
                    ((global::Windows.UI.Xaml.Controls.DatePicker)this.DatePickerToChart).DateChanged += this.DatePickerToChart_DateChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.BtnActualizar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 93 "..\..\..\TemperaturaDeshidratadora.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnActualizar).Click += this.BtnActualizar_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.LineSeries = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 8:
                {
                    this.textBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.textBlockMarca = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.textBlock4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.textBlock5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.textBlock6 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.textBlock7 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.textBlockNoSerie = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.textBlockModelo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.textBlockTotalAlertas = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.LoadingBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
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

