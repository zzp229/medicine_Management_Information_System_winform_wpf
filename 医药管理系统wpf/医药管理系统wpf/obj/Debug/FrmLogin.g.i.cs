﻿#pragma checksum "..\..\FrmLogin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ADA259E73E8E35618A6F5437CBE012E93E38EE00D77372AA3A87B1013D36DC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using 医药管理系统wpf;


namespace 医药管理系统wpf {
    
    
    /// <summary>
    /// FrmLogin
    /// </summary>
    public partial class FrmLogin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\FrmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Login;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\FrmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Exit;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\FrmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Register;
        
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
            System.Uri resourceLocater = new System.Uri("/医药管理系统wpf;component/frmlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FrmLogin.xaml"
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
            this.btn_Login = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\FrmLogin.xaml"
            this.btn_Login.Click += new System.Windows.RoutedEventHandler(this.btn_Login_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\FrmLogin.xaml"
            this.btn_Exit.Click += new System.Windows.RoutedEventHandler(this.btn_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_Register = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\FrmLogin.xaml"
            this.btn_Register.Click += new System.Windows.RoutedEventHandler(this.btn_Register_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

