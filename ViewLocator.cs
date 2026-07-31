
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using BatchProcess3.ViewModels;
using BatchProcess3.ViewModels.Pages;
using BatchProcess3.Views.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BatchProcess3;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? data)
    {
        var viewName = data!.GetType().FullName!.Replace("ViewModel", "View", StringComparison.InvariantCulture);
        var type = Type.GetType(viewName);

        if (type != null)
        {
            var control = (Control)Activator.CreateInstance(type)!;
            control.DataContext = data;
            return control;
        }

        return new TextBlock { Text = "Not Found: " + viewName };
    }

    public bool Match(object? data) => data is ViewModelBase;    
}
