﻿#pragma checksum "..\..\CFTema2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF61FFDC4AE03D5057D69617760CCC6BF7F8CC8AE66C121D97B183CF3237D52D"
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
    /// CFTema2
    /// </summary>
    public partial class CFTema2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\CFTema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button letras;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CFTema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button letras_Copy1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CFTema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button letras_Copy2;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\CFTema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Siguiente;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\CFTema2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Anterior;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoFinal;component/cftema2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CFTema2.xaml"
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
            this.letras = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\CFTema2.xaml"
            this.letras.Click += new System.Windows.RoutedEventHandler(this.teoria_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.letras_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\CFTema2.xaml"
            this.letras_Copy1.Click += new System.Windows.RoutedEventHandler(this.ejercicios_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.letras_Copy2 = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\CFTema2.xaml"
            this.letras_Copy2.Click += new System.Windows.RoutedEventHandler(this.puntuacion_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Siguiente = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\CFTema2.xaml"
            this.Siguiente.Click += new System.Windows.RoutedEventHandler(this.Siguiente_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Anterior = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\CFTema2.xaml"
            this.Anterior.Click += new System.Windows.RoutedEventHandler(this.Anterior_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

