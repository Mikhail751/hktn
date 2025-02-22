﻿#pragma checksum "..\..\..\Pages\StartPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65D45338F7CD04C9F722F7A99EEACB8DD0F6AB8F5673F48CF3CE189141533A2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using InvitesApp.Pages;
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


namespace InvitesApp.Pages {
    
    
    /// <summary>
    /// StartPage
    /// </summary>
    public partial class StartPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TagTB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox GetDateCB;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateDP;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Tabs;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView InvitesLW;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\StartPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView BookmardLW;
        
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
            System.Uri resourceLocater = new System.Uri("/InvitesApp;component/pages/startpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\StartPage.xaml"
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
            
            #line 19 "..\..\..\Pages\StartPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateTag);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TagTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GetDateCB = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\..\Pages\StartPage.xaml"
            this.GetDateCB.Click += new System.Windows.RoutedEventHandler(this.UpdateDate);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DateDP = ((System.Windows.Controls.DatePicker)(target));
            
            #line 24 "..\..\..\Pages\StartPage.xaml"
            this.DateDP.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.UpdateDateVal);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Tabs = ((System.Windows.Controls.TabControl)(target));
            return;
            case 6:
            this.InvitesLW = ((System.Windows.Controls.ListView)(target));
            
            #line 36 "..\..\..\Pages\StartPage.xaml"
            this.InvitesLW.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnViewInvite);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 47 "..\..\..\Pages\StartPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddMeeting);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 48 "..\..\..\Pages\StartPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBookMark);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BookmardLW = ((System.Windows.Controls.ListView)(target));
            
            #line 62 "..\..\..\Pages\StartPage.xaml"
            this.BookmardLW.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnViewInvite);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 72 "..\..\..\Pages\StartPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnRemoveBM);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

