using MvvmTemplate.IServices;

namespace MvvmTemplate.Services;

public class SettingsService : ISettingsService
{
    public T? GetValue<T>(string key)
    {
        var property = MvvmTemplate.Services.Settings.Default.PropertyValues[key];
        if (property != null) return (T?) property.PropertyValue;

        return default;
    }

    public void SetValue<T>(string key, T value)
    {
        MvvmTemplate.Services.Settings.Default[key] = value;
        MvvmTemplate.Services.Settings.Default.Save();
    }
}