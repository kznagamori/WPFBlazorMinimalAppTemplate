// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace ___PROJECTNAME___
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }

}
