global _main
extern _MessageBoxA@16
extern _ExitProcess@4

section code use32 class=code
_main:
    push    dword 0 ; UINT uType = MB_OK
	push	dword title  ; LPCSTR lpCaption
	push	dword banner ; LPCSTR lpText
	push	dword 0      ; HWND hWnd = NULL
	call	_MessageBoxA@16

	push	dword 0      ; UINT uExitCode
	call	_ExitProcess@4

section data use32 class=data
	banner:	db 'Hello, world!', 0
	title:	db 'Hello', 0