﻿#pragma checksum "..\..\mainwindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B24D2EFD9EA9F89F956C36864BDD0CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BorrowingManager;
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


namespace BorrowingManager {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BorrowingManager.MainWindow MainWindow1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid windowGrid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataTerritory;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label connectLabel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataUser;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataHistory;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTerritoryButton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addUserButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BorrowingManager;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mainwindow.xaml"
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
            this.MainWindow1 = ((BorrowingManager.MainWindow)(target));
            return;
            case 2:
            this.windowGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.dataTerritory = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\mainwindow.xaml"
            this.dataTerritory.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dataTerritory_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTerritory_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.addTerritoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 31 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateTerritory_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 33 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenDetails_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.connectLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.dataUser = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 47 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItemUser_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 49 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.addUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 51 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateItemUser_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 53 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BorrowUserGrid_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.dataHistory = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 15:
            
            #line 68 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BackTerritory_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 70 "..\..\mainwindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateUserTerritory_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.addTerritoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\mainwindow.xaml"
            this.addTerritoryButton.Click += new System.Windows.RoutedEventHandler(this.addTerritoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.addUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\mainwindow.xaml"
            this.addUserButton.Click += new System.Windows.RoutedEventHandler(this.addUserButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

