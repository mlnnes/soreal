﻿#pragma checksum "..\..\UIMain.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FD1789C2AF76EDB8D6CD931090C068A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// UIMain
    /// </summary>
    public partial class UIMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\UIMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\UIMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSeen;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\UIMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonWillWatch;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\UIMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonWatching;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\UIMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\UIMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxMain;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/uimain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UIMain.xaml"
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
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\UIMain.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonSeen = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\UIMain.xaml"
            this.ButtonSeen.Click += new System.Windows.RoutedEventHandler(this.ButtonSeen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonWillWatch = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\UIMain.xaml"
            this.ButtonWillWatch.Click += new System.Windows.RoutedEventHandler(this.ButtonWillWatch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonWatching = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\UIMain.xaml"
            this.ButtonWatching.Click += new System.Windows.RoutedEventHandler(this.ButtonWatching_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\UIMain.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listBoxMain = ((System.Windows.Controls.ListBox)(target));
            
            #line 59 "..\..\UIMain.xaml"
            this.listBoxMain.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxMain_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

