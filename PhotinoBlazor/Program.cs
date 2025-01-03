﻿using PhotinoBlazor.Components;
using Photino.Blazor;

namespace PhotinoBlazor
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var builder = PhotinoBlazorAppBuilder.CreateDefault(args);

            //builder.Services.AddLogging();

            // register root component and selector
            builder.RootComponents.Add<App>("app");

            var app = builder.Build();

            // customize window
            app.MainWindow
                .SetIconFile("favicon.ico")
                .SetTitle("Photino Blazor Sample");

            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
                app.MainWindow.ShowMessage("Fatal exception", error.ExceptionObject.ToString());
            };

            app.Run();

        }
    }
}
