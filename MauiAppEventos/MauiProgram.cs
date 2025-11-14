using Microsoft.Extensions.Logging;

namespace MauiAppEventos
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Orbitron-Black.ttf", "OrbitronBlack");
                    fonts.AddFont("Orbitron-Bold.ttf", "OrbitronBold");
                    fonts.AddFont("Orbitron-ExtraBold.ttf", "OrbitronExtraBold");
                    fonts.AddFont("Orbitron-Medium.ttf", "OrbitronMedium");
                    fonts.AddFont("Orbitron-Regular.ttf", "OrbitronRegular");
                    fonts.AddFont("Orbitron-SemiBold.ttf", "OrbitronSemiBold");
                    fonts.AddFont("Orbitron-VariableFont.wght.ttf", "OrbitronVariable");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
