﻿#pragma checksum "..\..\Pobeda.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "123C3AD63CF6281DA8D3ED149CD34106"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekat2;
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


namespace Projekat2 {
    
    
    /// <summary>
    /// Pobeda
    /// </summary>
    public partial class Pobeda : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Pobeda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement klik_sound;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Pobeda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label naslov;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Pobeda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lab;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Pobeda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ime;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Pobeda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sacuvaj;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Pobeda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button try_again;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Pobeda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button skorovi;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekat2;component/pobeda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Pobeda.xaml"
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
            
            #line 9 "..\..\Pobeda.xaml"
            ((Projekat2.Pobeda)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.klik_sound = ((System.Windows.Controls.MediaElement)(target));
            
            #line 12 "..\..\Pobeda.xaml"
            this.klik_sound.MediaEnded += new System.Windows.RoutedEventHandler(this.klik_sound_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.naslov = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lab = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.sacuvaj = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Pobeda.xaml"
            this.sacuvaj.Click += new System.Windows.RoutedEventHandler(this.sacuvaj_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.try_again = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Pobeda.xaml"
            this.try_again.Click += new System.Windows.RoutedEventHandler(this.try_again_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.skorovi = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Pobeda.xaml"
            this.skorovi.Click += new System.Windows.RoutedEventHandler(this.skorovi_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
