﻿#pragma checksum "..\..\..\Views\WindowAddFeed.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AFD64CE024141F0708FFBC8B5E4EDCAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CSharpProject.Views;
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


namespace CSharpProject.Views {
    
    
    /// <summary>
    /// WindowAddFeed
    /// </summary>
    public partial class WindowAddFeed : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CSharpProject.Views.WindowAddFeed WindowAddFeed1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelUrl;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxUrl;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTitle;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTitleShow;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCategory;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCategory;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\WindowAddFeed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
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
            System.Uri resourceLocater = new System.Uri("/CSharpProject;component/views/windowaddfeed.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\WindowAddFeed.xaml"
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
            this.WindowAddFeed1 = ((CSharpProject.Views.WindowAddFeed)(target));
            return;
            case 2:
            this.labelUrl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textBoxUrl = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\Views\WindowAddFeed.xaml"
            this.textBoxUrl.LostFocus += new System.Windows.RoutedEventHandler(this.textBoxUrl_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.labelTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.labelTitleShow = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.buttonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\WindowAddFeed.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.labelCategory = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.textBoxCategory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\WindowAddFeed.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

