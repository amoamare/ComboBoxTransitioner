using System.Windows;
using System.Windows.Controls;

namespace ComboBoxTranisitioner
{
    public class ComboBoxItemTemplateSelector : DataTemplateSelector
    {
        // Can set both templates from XAML
        public DataTemplate SelectedItemTemplate { get; set; }
        public DataTemplate ItemTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var selected = false;
            var frameworkElement = container as FrameworkElement;
            var parent = frameworkElement?.TemplatedParent;
            if (parent is ComboBox)
            {
                selected = true;
            }
            //var combBox = parent as ComboBox;
            //if (cbo != null)
            //    selected = true;
            //var lb = parent as ListBox;
            //if (lb != null)
            //    selected = true;
            return selected ? SelectedItemTemplate : ItemTemplate;
        }
    }
}
