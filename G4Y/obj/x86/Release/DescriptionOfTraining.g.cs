﻿#pragma checksum "C:\Users\Majkell\Desktop\G4Y\G4Y\DescriptionOfTraining.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "44663FD0A86A531C1B5D2F5DD1F32799"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace G4Y
{
    partial class DescriptionOfTraining : 
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
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.textBox1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.buttonShowPanel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\DescriptionOfTraining.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonShowPanel).Click += this.buttonShowPanel_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\DescriptionOfTraining.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Tapped += this.Back_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element7 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 27 "..\..\..\DescriptionOfTraining.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element7).Tapped += this.Back_Tapped;
                    #line default
                }
                break;
            case 8:
                {
                    this.BodyMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\DescriptionOfTraining.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BodyMenu).Tapped += this.TextBlock_Tapped;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element9 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 22 "..\..\..\DescriptionOfTraining.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element9).Tapped += this.TextBlock_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    this.TrainingMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\DescriptionOfTraining.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.TrainingMenu).Tapped += this.TrainingMenu_Tapped;
                    #line default
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

