﻿

#pragma checksum "c:\users\jav.000\documents\visual studio 11\Projects\Ejemplo_GridView_Variable\Ejemplo_GridView_Variable\ItemDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F7BB5515638FB787F2769E9D6F36322"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Ejemplo_GridView_Variable
{
    public partial class ItemDetailPage : Ejemplo_GridView_Variable.Common.LayoutAwarePage, IComponentConnector
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 67 "..\..\ItemDetailPage.xaml"
                ((Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.StartLayoutUpdates;
                 #line default
                 #line hidden
                #line 67 "..\..\ItemDetailPage.xaml"
                ((Windows.UI.Xaml.FrameworkElement)(target)).Unloaded += this.StopLayoutUpdates;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 43 "..\..\ItemDetailPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


