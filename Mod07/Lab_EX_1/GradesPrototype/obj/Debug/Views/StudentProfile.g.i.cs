﻿#pragma checksum "..\..\..\Views\StudentProfile.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334276A98057155BCE760E4427FD507A7761BF3D"
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


namespace GradesPrototype.Views {
    
    
    /// <summary>
    /// StudentProfile
    /// </summary>
    public partial class StudentProfile : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel studentName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock firstName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lastName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl studentGrades;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveReport;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\StudentProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddGrade;
        
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
            System.Uri resourceLocater = new System.Uri("/GradesPrototype;component/views/studentprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\StudentProfile.xaml"
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
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\StudentProfile.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.studentName = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.firstName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.lastName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Views\StudentProfile.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.Remove_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.studentGrades = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 7:
            this.btnSaveReport = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Views\StudentProfile.xaml"
            this.btnSaveReport.Click += new System.Windows.RoutedEventHandler(this.SaveReport_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnAddGrade = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Views\StudentProfile.xaml"
            this.btnAddGrade.Click += new System.Windows.RoutedEventHandler(this.AddGrade_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

