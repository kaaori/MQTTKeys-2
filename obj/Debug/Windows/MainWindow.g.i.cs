#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EA5CA432CCBEA16DE3B292943C36CFAC"
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
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;
using mqtt_hotkeys_test;
using mqtt_hotkeys_test.Windows;


namespace mqtt_hotkeys_test.Windows
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.BusyIndicator BusyIndicatorMainWindow;

#line default
#line hidden


#line 24 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel MainPanel;

#line default
#line hidden


#line 27 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemResetBinds;

#line default
#line hidden


#line 29 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemSaveConfig;

#line default
#line hidden


#line 31 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemClose;

#line default
#line hidden


#line 33 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemConfig;

#line default
#line hidden


#line 84 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MainStackPanel;

#line default
#line hidden


#line 113 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddThing;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
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
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 15 "..\..\..\Windows\MainWindow.xaml"
                    ((mqtt_hotkeys_test.Windows.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.MainWindow_OnClosing);

#line default
#line hidden
                    return;
                case 2:
                    this.BusyIndicatorMainWindow = ((Xceed.Wpf.Toolkit.BusyIndicator)(target));
                    return;
                case 3:
                    this.MainPanel = ((System.Windows.Controls.DockPanel)(target));
                    return;
                case 4:
                    this.MenuItemResetBinds = ((System.Windows.Controls.MenuItem)(target));

#line 28 "..\..\..\Windows\MainWindow.xaml"
                    this.MenuItemResetBinds.Click += new System.Windows.RoutedEventHandler(this.MenuItemResetBinds_OnClick);

#line default
#line hidden
                    return;
                case 5:
                    this.MenuItemSaveConfig = ((System.Windows.Controls.MenuItem)(target));

#line 30 "..\..\..\Windows\MainWindow.xaml"
                    this.MenuItemSaveConfig.Click += new System.Windows.RoutedEventHandler(this.MenuItemSaveConfig_OnClick);

#line default
#line hidden
                    return;
                case 6:
                    this.MenuItemClose = ((System.Windows.Controls.MenuItem)(target));

#line 32 "..\..\..\Windows\MainWindow.xaml"
                    this.MenuItemClose.Click += new System.Windows.RoutedEventHandler(this.MenuItemClose_OnClick);

#line default
#line hidden
                    return;
                case 7:
                    this.MenuItemConfig = ((System.Windows.Controls.MenuItem)(target));

#line 34 "..\..\..\Windows\MainWindow.xaml"
                    this.MenuItemConfig.Click += new System.Windows.RoutedEventHandler(this.MenuItemConfig_OnClick);

#line default
#line hidden
                    return;
                case 8:
                    this.MainStackPanel = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 9:
                    this.BtnAddThing = ((System.Windows.Controls.Button)(target));

#line 114 "..\..\..\Windows\MainWindow.xaml"
                    this.BtnAddThing.Click += new System.Windows.RoutedEventHandler(this.BtnAddThing_OnClick);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.MenuItem MenuItemMinimize;
    }
}

