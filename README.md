# coreclr-pinvoke

Under linux follow https://github.com/dotnet/coreclr/blob/master/Documentation/install/get-dotnetcore-dnx-linux.md

To compile the c file : gcc -shared -o ffi_test.so ffi_test.c

dnu restore

LD_LIBRARY_PATH=.  dnx run
