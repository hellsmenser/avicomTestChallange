#pragma checksum "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1BCD4FD137A8807D4C0E0BBF937A61918ECCDFD16A11A0EA49DDFE6AB9C9589F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using avicomTestChallange.windows.EditData.Pages;


namespace avicomTestChallange.windows.EditData.Pages {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Products;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductType;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductPrice;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductPeriod;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pick;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Change;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
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
            System.Uri resourceLocater = new System.Uri("/avicomTestChallange;component/windows/editdata/pages/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
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
            
            #line 10 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
            ((avicomTestChallange.windows.EditData.Pages.ProductPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Products = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ProductName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ProductType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
            this.ProductType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProductPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ProductPeriod = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Pick = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
            this.Pick.Click += new System.Windows.RoutedEventHandler(this.Chose);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Change = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
            this.Change.Click += new System.Windows.RoutedEventHandler(this.Change_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 30 "..\..\..\..\..\windows\EditData\Pages\ProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

