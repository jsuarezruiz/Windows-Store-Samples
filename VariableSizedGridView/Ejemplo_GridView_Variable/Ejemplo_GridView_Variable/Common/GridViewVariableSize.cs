using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo_GridView_Variable.Data;
using Windows.UI.Xaml.Controls;

namespace Ejemplo_GridView_Variable.Common
{
    class GridViewVariableSize : GridView
    {
        protected override void PrepareContainerForItemOverride(Windows.UI.Xaml.DependencyObject element, object item)
        {
            var sampleDataItem = item as SampleDataItem;

            if (sampleDataItem != null)
            {
                element.SetValue(VariableSizedWrapGrid.ColumnSpanProperty, sampleDataItem.ColumnSpan);
                element.SetValue(VariableSizedWrapGrid.RowSpanProperty, sampleDataItem.RowSpan);
            }

            base.PrepareContainerForItemOverride(element, item);
        }
    }
}
