section .text
org 0x100
    mov ah, 0x9
    mox dx, hello
    int 0x21

    mox ax, 0x4c00
    int 0x21

section .data
hello: db 'Hello World!', 13, 10, '$'

