; Image base = 0x00400000
%define RVA(x) (x-0x00400000)
section .text
push dword hello
call dword [printf]
push byte +0
call dword [exit]
ret

section .data
hello db "Hello world!"

section .idata
dd RVA(msvcrt_LookupTable)
dd -1
dd 0
dd RVA(msvcrt_string)
dd RVA(msvcrt_imports)
times 5 dd 0 ; ends the descriptor table

msvcrt_string dd "msvcrt.dll", 0
msvcrt_LookupTable:
dd RVA(msvcrt_printf)
dd RVA(msvcrt_exit)
dd 0

msvcrt_imports:
printf dd RVA(msvcrt_printf)
exit dd RVA(msvcrt_exit)
dd 0

msvcrt_printf:
dw 1
dw "printf", 0
msvcrt_exit:
dw 2
dw "exit", 0
dd 0