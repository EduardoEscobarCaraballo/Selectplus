﻿#pragma checksum "..\..\Letras.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "78D446599A5A76516FF04BCD17F1472B6FF6E5D796807F236395B3FA35BD88DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoFinal;
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


namespace ProyectoFinal {
    
    
    /// <summary>
    /// Letras
    /// </summary>
    public partial class Letras : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Letras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button matematicas_bt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Letras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fisica_bt;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Letras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button biologia_bt;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Letras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button biologia_bt_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoFinal;component/letras.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Letras.xaml"
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
            this.matematicas_bt = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Letras.xaml"
            this.matematicas_bt.Click += new System.Windows.RoutedEventHandler(this.lengua_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fisica_bt = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Letras.xaml"
            this.fisica_bt.Click += new System.Windows.RoutedEventHandler(this.historia_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.biologia_bt = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Letras.xaml"
            this.biologia_bt.Click += new System.Windows.RoutedEventHandler(this.latin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.biologia_bt_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\Letras.xaml"
            this.biologia_bt_Copy.Click += new System.Windows.RoutedEventHandler(this.griego_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

