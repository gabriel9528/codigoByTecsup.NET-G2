﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E7C2E4D42E70364016E54D0BE2C5807D954D83C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_ComboBox_CheckBox;


namespace WPF_ComboBox_CheckBox {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Capitales;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox TodasCapitales;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Lima;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Madrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox BuenosAires;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Bogota;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Quito;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_ComboBox_CheckBox;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Capitales = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.TodasCapitales = ((System.Windows.Controls.CheckBox)(target));
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.TodasCapitales.Checked += new System.Windows.RoutedEventHandler(this.TodasCapitales_Checked);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.TodasCapitales.Unchecked += new System.Windows.RoutedEventHandler(this.TodasCapitales_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Lima = ((System.Windows.Controls.CheckBox)(target));
            
            #line 32 "..\..\..\MainWindow.xaml"
            this.Lima.Checked += new System.Windows.RoutedEventHandler(this.Individual_Checked);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\MainWindow.xaml"
            this.Lima.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_UnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Madrid = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.Madrid.Checked += new System.Windows.RoutedEventHandler(this.Individual_Checked);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.Madrid.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_UnChecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BuenosAires = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.BuenosAires.Checked += new System.Windows.RoutedEventHandler(this.Individual_Checked);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.BuenosAires.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_UnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Bogota = ((System.Windows.Controls.CheckBox)(target));
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.Bogota.Checked += new System.Windows.RoutedEventHandler(this.Individual_Checked);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.Bogota.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_UnChecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Quito = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.Quito.Checked += new System.Windows.RoutedEventHandler(this.Individual_Checked);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.Quito.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_UnChecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

