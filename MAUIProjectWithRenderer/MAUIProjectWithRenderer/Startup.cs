using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
#if __ANDROID__
using CustomRenderer;
using CustomRenderer.Platforms.Android;
#endif

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace MAUIProjectWithRenderer
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				.ConfigureMauiHandlers(handlers =>
                {
#if __ANDROID__
					handlers.AddCompatibilityRenderer(typeof(MyButton), typeof(MyButtonRenderer));
#endif
				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});
		}
	}
}