﻿#pragma checksum "..\..\..\HostingUnitUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BDDCD2FACD0462F9FBA2BBD73A059C3DA5F59B64"
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
using dotNet5780_03_1037_5201;


namespace dotNet5780_03_1037_5201 {
    
    
    /// <summary>
    /// HostingUnitUserControl
    /// </summary>
    public partial class HostingUnitUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\HostingUnitUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UserControlGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\HostingUnitUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUnitName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\HostingUnitUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRooms;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\HostingUnitUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btOrder;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\HostingUnitUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsSwimigPool;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\HostingUnitUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox vbCalendar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/dotNet5780_03_1037_5201;component/hostingunitusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HostingUnitUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserControlGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.tbUnitName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbRooms = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btOrder = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\HostingUnitUserControl.xaml"
            this.btOrder.Click += new System.Windows.RoutedEventHandler(this.btOrder_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IsSwimigPool = ((System.Windows.Controls.CheckBox)(target));
            
            #line 28 "..\..\..\HostingUnitUserControl.xaml"
            this.IsSwimigPool.Checked += new System.Windows.RoutedEventHandler(this.IsSwimigPool_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.vbCalendar = ((System.Windows.Controls.Viewbox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

