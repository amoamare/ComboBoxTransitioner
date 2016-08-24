using System.Windows;
using System.Windows.Controls;

namespace ComboBoxTranisitioner
{
    public class ComboBoxItemTemplateSelector : DataTemplateSelector
    {
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
            return selected ? SelectedItemTemplate : ItemTemplate;
        }
    }
}
