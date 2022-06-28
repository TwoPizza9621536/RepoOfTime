.386
.model small,c
.stack 1000h

.data
msg db "Hello World!",0

.code
includelib libcmt.lib
includelib libvcruntime.lib
includelib libucrt.lib
includelib legacy_stdio_definitions.lib

extrn printf:near
extrn exit:near

public main
main proc
    push    offset msg
    call    printf
    push    0
    call    exit
main endp

end
