// file: ffi_test.c
// To compile under osx : gcc -dynamiclib -o ffi_test.dylib ffi_test.c
// To compile under linux : gcc -shared -o ffi_test.so ffi_test.c

int ffi_test()
{
    return 42;
}