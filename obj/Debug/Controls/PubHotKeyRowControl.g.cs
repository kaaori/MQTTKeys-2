﻿#pragma checksum "..\..\..\Controls\PubHotKeyRowControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CDAEBF40D8957C0FDD5BF4D832E8DFBA"
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
using Xceed.Wpf.Toolkit;
using mqtt_hotkeys_test.Windows;


namespace mqtt_hotkeys_test.Windows {
    
    
    /// <summary>
    /// PubHotKeyRowControl
    /// </summary>
    public partial class PubHotKeyRowControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Controls\PubHotKeyRowControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox TxtHotKey;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Controls\PubHotKeyRowControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox TxtTopic;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Controls\PubHotKeyRowControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox TxtMessage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Controls\PubHotKeyRowControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown TxtQos;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Controls\PubHotKeyRowControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRemoveHotkey;
        
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
            System.Uri resourceLocater = new System.Uri("/mqtt_hotkeys_test;component/controls/pubhotkeyrowcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\PubHotKeyRowControl.xaml"
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
            this.TxtHotKey = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            
            #line 26 "..\..\..\Controls\PubHotKeyRowControl.xaml"
            this.TxtHotKey.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TxtHotKey_OnMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtTopic = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 3:
            this.TxtMessage = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 4:
            this.TxtQos = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            
            #line 48 "..\..\..\Controls\PubHotKeyRowControl.xaml"
            this.TxtQos.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TxtQos_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\Controls\PubHotKeyRowControl.xaml"
            this.TxtQos.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TxtQos_OnMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnRemoveHotkey = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\Controls\PubHotKeyRowControl.xaml"
            this.BtnRemoveHotkey.Click += new System.Windows.RoutedEventHandler(this.BtnRemoveHotkey_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 89 "..\..\..\Controls\PubHotKeyRowControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnTest_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

