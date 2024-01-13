using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.CompilerServices;

internal sealed class MemoryReader<T> : IDisposable where T : unmanaged
{
    private readonly MemoryMappedFile _file;
    private readonly MemoryMappedViewAccessor _accessor;
    
    public MemoryReader(string filename)
    {
        _file = MemoryMappedFile.OpenExisting(filename, MemoryMappedFileRights.Read);
        _accessor = _file.CreateViewAccessor(0, Unsafe.SizeOf<T>(), MemoryMappedFileAccess.Read);
    }

    public void Dispose()
    {
        _accessor.Dispose();
        _file.Dispose();
    }

    public T Read()
    {
        if (_accessor.SafeMemoryMappedViewHandle.IsClosed)
            throw new ObjectDisposedException(nameof(MemoryReader<T>));
        
        _accessor.Read<T>(0, out var root);
        
        return root;
    }
}