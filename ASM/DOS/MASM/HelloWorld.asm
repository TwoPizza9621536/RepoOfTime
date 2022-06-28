.model small
.stach 100h

.data
msg db 'Hello world!$'

.code
start:
    mov ah, 09h ; Display the message
    lea dx, msg
    int 21h
    mov ax, 4C00h ; Terminate the executable
    int 21h
end start