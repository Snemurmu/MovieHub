﻿#pragma checksum "..\..\..\MovieHub.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A3ACB443DEDD8D1B2F44FC43D2429BFE52B8454"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MovieHub;
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


namespace MovieHub {
    
    
    /// <summary>
    /// MovieHub
    /// </summary>
    public partial class MovieHub : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid delete;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox title;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox year;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox genre;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button connection;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insert;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MovieHub.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MovieHub;component/moviehub.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MovieHub.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.delete = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.title = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.year = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.genre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.connection = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\MovieHub.xaml"
            this.connection.Click += new System.Windows.RoutedEventHandler(this.connection_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.insert = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\MovieHub.xaml"
            this.insert.Click += new System.Windows.RoutedEventHandler(this.insert_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\MovieHub.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.delete1 = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\MovieHub.xaml"
            this.delete1.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.search = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\MovieHub.xaml"
            this.search.Click += new System.Windows.RoutedEventHandler(this.search_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
