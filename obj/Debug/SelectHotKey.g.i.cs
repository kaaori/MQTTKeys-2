﻿#pragma checksum "..\..\SelectHotKey.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ECAD5230B785711FD8A9E6835F85649D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NHotkey.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using mqtt_hotkeys_test;


namespace mqtt_hotkeys_test {
    
    
    /// <summary>
    /// SelectHotKey
    /// </summary>
    public partial class SelectHotKey : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\SelectHotKey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkCtrl;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\SelectHotKey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkWin;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\SelectHotKey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkAlt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\SelectHotKey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkShift;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\SelectHotKey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtKey;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\SelectHotKey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\SelectHotKey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/mqtt_hotkeys_test;component/selecthotkey.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectHotKey.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\SelectHotKey.xaml"
            ((Windows.SelectHotKey)(target)).Loaded += new System.Windows.RoutedEventHandler(this.SelectHotKey_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChkCtrl = ((System.Windows.Controls.CheckBox)(target));
            
            #line 31 "..\..\SelectHotKey.xaml"
            this.ChkCtrl.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_OnChecked);
            
            #line default
            #line hidden
            
            #line 32 "..\..\SelectHotKey.xaml"
            this.ChkCtrl.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_OnUnChecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChkWin = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\SelectHotKey.xaml"
            this.ChkWin.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ChkAlt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 44 "..\..\SelectHotKey.xaml"
            this.ChkAlt.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_OnChecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ChkShift = ((System.Windows.Controls.CheckBox)(target));
            
            #line 50 "..\..\SelectHotKey.xaml"
            this.ChkShift.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxtKey = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\SelectHotKey.xaml"
            this.TxtKey.GotFocus += new System.Windows.RoutedEventHandler(this.TxtKey_OnGotFocus);
            
            #line default
            #line hidden
            
            #line 57 "..\..\SelectHotKey.xaml"
            this.TxtKey.LostFocus += new System.Windows.RoutedEventHandler(this.TxtKey_OnLostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\SelectHotKey.xaml"
            this.BtnOk.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BtnOk_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\SelectHotKey.xaml"
            this.BtnCancel.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BtnCancel_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

