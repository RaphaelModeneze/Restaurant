#pragma checksum "..\..\..\..\UserControls\ItemUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F0179A834D93B375EBF3519EC4C8E173AA9DE1E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Restaurant.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Restaurant.UserControls {
    
    
    /// <summary>
    /// ItemUserControl
    /// </summary>
    public partial class ItemUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ItemGrid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ItemLbl;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemID;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ItemNameLbl;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemNameTxt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ItemPriceLbl;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemPriceTxt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ItemBtns;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\UserControls\ItemUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveItemBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/usercontrols/itemusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\ItemUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ItemGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ItemLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ItemID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ItemNameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ItemNameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ItemPriceLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.ItemPriceTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ItemBtns = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.SaveItemBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

