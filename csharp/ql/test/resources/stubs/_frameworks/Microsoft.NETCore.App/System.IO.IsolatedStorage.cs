// This file contains auto-generated code.
// Generated from `System.IO.IsolatedStorage, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`.
namespace System
{
    namespace IO
    {
        namespace IsolatedStorage
        {
            public interface INormalizeForIsolatedStorage
            {
                object Normalize();
            }
            public abstract class IsolatedStorage : System.MarshalByRefObject
            {
                public object ApplicationIdentity { get => throw null; }
                public object AssemblyIdentity { get => throw null; }
                public virtual long AvailableFreeSpace { get => throw null; }
                protected IsolatedStorage() => throw null;
                public virtual ulong CurrentSize { get => throw null; }
                public object DomainIdentity { get => throw null; }
                public virtual bool IncreaseQuotaTo(long newQuotaSize) => throw null;
                protected void InitStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type appEvidenceType) => throw null;
                protected void InitStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type domainEvidenceType, System.Type assemblyEvidenceType) => throw null;
                public virtual ulong MaximumSize { get => throw null; }
                public virtual long Quota { get => throw null; }
                public abstract void Remove();
                public System.IO.IsolatedStorage.IsolatedStorageScope Scope { get => throw null; }
                protected virtual char SeparatorExternal { get => throw null; }
                protected virtual char SeparatorInternal { get => throw null; }
                public virtual long UsedSize { get => throw null; }
            }
            public class IsolatedStorageException : System.Exception
            {
                public IsolatedStorageException() => throw null;
                protected IsolatedStorageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => throw null;
                public IsolatedStorageException(string message) => throw null;
                public IsolatedStorageException(string message, System.Exception inner) => throw null;
            }
            public sealed class IsolatedStorageFile : System.IO.IsolatedStorage.IsolatedStorage, System.IDisposable
            {
                public override long AvailableFreeSpace { get => throw null; }
                public void Close() => throw null;
                public void CopyFile(string sourceFileName, string destinationFileName) => throw null;
                public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) => throw null;
                public void CreateDirectory(string dir) => throw null;
                public System.IO.IsolatedStorage.IsolatedStorageFileStream CreateFile(string path) => throw null;
                public override ulong CurrentSize { get => throw null; }
                public void DeleteDirectory(string dir) => throw null;
                public void DeleteFile(string file) => throw null;
                public bool DirectoryExists(string path) => throw null;
                public void Dispose() => throw null;
                public bool FileExists(string path) => throw null;
                public System.DateTimeOffset GetCreationTime(string path) => throw null;
                public string[] GetDirectoryNames() => throw null;
                public string[] GetDirectoryNames(string searchPattern) => throw null;
                public static System.Collections.IEnumerator GetEnumerator(System.IO.IsolatedStorage.IsolatedStorageScope scope) => throw null;
                public string[] GetFileNames() => throw null;
                public string[] GetFileNames(string searchPattern) => throw null;
                public System.DateTimeOffset GetLastAccessTime(string path) => throw null;
                public System.DateTimeOffset GetLastWriteTime(string path) => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetMachineStoreForApplication() => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetMachineStoreForAssembly() => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetMachineStoreForDomain() => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, object applicationIdentity) => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, object domainIdentity, object assemblyIdentity) => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type applicationEvidenceType) => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type domainEvidenceType, System.Type assemblyEvidenceType) => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForApplication() => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForAssembly() => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForDomain() => throw null;
                public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForSite() => throw null;
                public override bool IncreaseQuotaTo(long newQuotaSize) => throw null;
                public static bool IsEnabled { get => throw null; }
                public override ulong MaximumSize { get => throw null; }
                public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) => throw null;
                public void MoveFile(string sourceFileName, string destinationFileName) => throw null;
                public System.IO.IsolatedStorage.IsolatedStorageFileStream OpenFile(string path, System.IO.FileMode mode) => throw null;
                public System.IO.IsolatedStorage.IsolatedStorageFileStream OpenFile(string path, System.IO.FileMode mode, System.IO.FileAccess access) => throw null;
                public System.IO.IsolatedStorage.IsolatedStorageFileStream OpenFile(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) => throw null;
                public override long Quota { get => throw null; }
                public override void Remove() => throw null;
                public static void Remove(System.IO.IsolatedStorage.IsolatedStorageScope scope) => throw null;
                public override long UsedSize { get => throw null; }
            }
            public class IsolatedStorageFileStream : System.IO.FileStream
            {
                public override System.IAsyncResult BeginRead(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) => throw null;
                public override System.IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) => throw null;
                public override bool CanRead { get => throw null; }
                public override bool CanSeek { get => throw null; }
                public override bool CanWrite { get => throw null; }
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(Microsoft.Win32.SafeHandles.SafeFileHandle), default(System.IO.FileAccess)) => throw null;
                protected override void Dispose(bool disposing) => throw null;
                public override System.Threading.Tasks.ValueTask DisposeAsync() => throw null;
                public override int EndRead(System.IAsyncResult asyncResult) => throw null;
                public override void EndWrite(System.IAsyncResult asyncResult) => throw null;
                public override void Flush() => throw null;
                public override void Flush(bool flushToDisk) => throw null;
                public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) => throw null;
                public override nint Handle { get => throw null; }
                public override bool IsAsync { get => throw null; }
                public override long Length { get => throw null; }
                public override void Lock(long position, long length) => throw null;
                public override long Position { get => throw null; set { } }
                public override int Read(byte[] buffer, int offset, int count) => throw null;
                public override int Read(System.Span<byte> buffer) => throw null;
                public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) => throw null;
                public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) => throw null;
                public override int ReadByte() => throw null;
                public override Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle { get => throw null; }
                public override long Seek(long offset, System.IO.SeekOrigin origin) => throw null;
                public override void SetLength(long value) => throw null;
                public override void Unlock(long position, long length) => throw null;
                public override void Write(byte[] buffer, int offset, int count) => throw null;
                public override void Write(System.ReadOnlySpan<byte> buffer) => throw null;
                public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) => throw null;
                public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) => throw null;
                public override void WriteByte(byte value) => throw null;
            }
            [System.Flags]
            public enum IsolatedStorageScope
            {
                None = 0,
                User = 1,
                Domain = 2,
                Assembly = 4,
                Roaming = 8,
                Machine = 16,
                Application = 32,
            }
        }
    }
}
