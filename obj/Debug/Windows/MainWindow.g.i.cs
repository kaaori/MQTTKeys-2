﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "82ACD5589E856B1215B6F2F2900C1B7A"
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
using mqtt_hotkeys_test.Controls;


namespace mqtt_hotkeys_test.Windows {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddSubThing;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl TabControlMainWindow;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PubStackPanel;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Subscribe;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SubStackPanel;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MenuItemConfig;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MenuItemSaveConfig;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MenuItemMinimize;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MenuItemResetBinds;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MenuItemClose;
        
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
            System.Uri resourceLocater = new System.Uri("/mqtt_hotkeys_test;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 18 "..\..\..\Windows\MainWindow.xaml"
            ((mqtt_hotkeys_test.Windows.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.MainWindow_OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnAddSubThing = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Windows\MainWindow.xaml"
            this.BtnAddSubThing.Click += new System.Windows.RoutedEventHandler(this.BtnAddHotKey_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TabControlMainWindow = ((System.Windows.Controls.TabControl)(target));
            return;
            case 4:
            this.PubStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.Subscribe = ((System.Windows.Controls.TabItem)(target));
            return;
            case 6:
            this.SubStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.MenuItemConfig = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Windows\MainWindow.xaml"
            this.MenuItemConfig.Click += new System.Windows.RoutedEventHandler(this.MenuItemConfig_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MenuItemSaveConfig = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\Windows\MainWindow.xaml"
            this.MenuItemSaveConfig.Click += new System.Windows.RoutedEventHandler(this.MenuItemSaveConfig_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MenuItemMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Windows\MainWindow.xaml"
            this.MenuItemMinimize.Click += new System.Windows.RoutedEventHandler(this.MenuItemMinimize_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MenuItemResetBinds = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Windows\MainWindow.xaml"
            this.MenuItemResetBinds.Click += new System.Windows.RoutedEventHandler(this.MenuItemResetBinds_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MenuItemClose = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\Windows\MainWindow.xaml"
            this.MenuItemClose.Click += new System.Windows.RoutedEventHandler(this.MenuItemClose_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

