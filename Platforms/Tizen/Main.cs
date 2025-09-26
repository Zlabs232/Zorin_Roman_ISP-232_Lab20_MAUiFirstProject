using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Zorin_Roman_ISP_232_Lab20_MAUiFirstProject
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
