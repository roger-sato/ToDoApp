﻿#pragma checksum "..\..\add_task_window.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD67C3A5CB0D8FDCC5BAA9290C35A725"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ToDoApp {
    
    
    /// <summary>
    /// add_task_window
    /// </summary>
    public partial class add_task_window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\add_task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox create_task_name;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\add_task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas main_canvas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\add_task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image miku;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\add_task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lavel;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDoApp;component/add_task_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\add_task_window.xaml"
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
            
            #line 5 "..\..\add_task_window.xaml"
            ((ToDoApp.add_task_window)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.create_task_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.main_canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 24 "..\..\add_task_window.xaml"
            this.main_canvas.MouseLeave += new System.Windows.Input.MouseEventHandler(this.main_canvas_MouseLeave);
            
            #line default
            #line hidden
            
            #line 25 "..\..\add_task_window.xaml"
            this.main_canvas.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.main_canvas_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\add_task_window.xaml"
            this.main_canvas.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.main_canvas_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 27 "..\..\add_task_window.xaml"
            this.main_canvas.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.main_canvas_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.miku = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            
            #line 38 "..\..\add_task_window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lavel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

