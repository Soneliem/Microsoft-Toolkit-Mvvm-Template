using System;
using System.IO;
using System.Threading.Tasks;
using MvvmTemplate.IServices;

namespace MvvmTemplate.Services;

public class FilesService : IFilesService
{
    public string InstallationPath => Environment.CurrentDirectory;

    public Task<Stream> OpenForReadAsync(string path)
    {
        Stream result = File.OpenRead(path);
        return Task.FromResult(result);
    }
}