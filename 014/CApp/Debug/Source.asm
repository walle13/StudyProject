; Listing generated by Microsoft (R) Optimizing Compiler Version 19.24.28316.0 

	TITLE	E:\code\StudyProject\014\CApp\Source.cpp
	.686P
	.XMM
	include listing.inc
	.model	flat

INCLUDELIB MSVCRTD
INCLUDELIB OLDNAMES

msvcjmc	SEGMENT
__F66CEB67_corecrt_stdio_config@h DB 01H
__101834BA_corecrt_wstdio@h DB 01H
__AD6A91B7_stdio@h DB 01H
__2DB7E14F_Source@cpp DB 01H
msvcjmc	ENDS
PUBLIC	___local_stdio_printf_options
PUBLIC	__vfprintf_l
PUBLIC	_printf
PUBLIC	?getCylinderVolume@@YANNN@Z			; getCylinderVolume
PUBLIC	_main
PUBLIC	__JustMyCode_Default
PUBLIC	?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA ; `__local_stdio_printf_options'::`2'::_OptionsStorage
PUBLIC	??_C@_0L@LAMICECC@Volume?$DN?$CFf?6@		; `string'
PUBLIC	__real@400921ff2e48e8a7
PUBLIC	__real@4024000000000000
PUBLIC	__real@4059000000000000
EXTRN	__imp____acrt_iob_func:PROC
EXTRN	__imp____stdio_common_vfprintf:PROC
EXTRN	@__CheckForDebuggerJustMyCode@4:PROC
EXTRN	__RTC_CheckEsp:PROC
EXTRN	__RTC_InitBase:PROC
EXTRN	__RTC_Shutdown:PROC
EXTRN	__fltused:DWORD
;	COMDAT ?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA
_BSS	SEGMENT
?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA DQ 01H DUP (?) ; `__local_stdio_printf_options'::`2'::_OptionsStorage
_BSS	ENDS
;	COMDAT __real@4059000000000000
CONST	SEGMENT
__real@4059000000000000 DQ 04059000000000000r	; 100
CONST	ENDS
;	COMDAT __real@4024000000000000
CONST	SEGMENT
__real@4024000000000000 DQ 04024000000000000r	; 10
CONST	ENDS
;	COMDAT __real@400921ff2e48e8a7
CONST	SEGMENT
__real@400921ff2e48e8a7 DQ 0400921ff2e48e8a7r	; 3.1416
CONST	ENDS
;	COMDAT rtc$TMZ
rtc$TMZ	SEGMENT
__RTC_Shutdown.rtc$TMZ DD FLAT:__RTC_Shutdown
rtc$TMZ	ENDS
;	COMDAT rtc$IMZ
rtc$IMZ	SEGMENT
__RTC_InitBase.rtc$IMZ DD FLAT:__RTC_InitBase
rtc$IMZ	ENDS
;	COMDAT ??_C@_0L@LAMICECC@Volume?$DN?$CFf?6@
CONST	SEGMENT
??_C@_0L@LAMICECC@Volume?$DN?$CFf?6@ DB 'Volume=%f', 0aH, 00H ; `string'
CONST	ENDS
; Function compile flags: /Odt
;	COMDAT __JustMyCode_Default
_TEXT	SEGMENT
__JustMyCode_Default PROC				; COMDAT
	push	ebp
	mov	ebp, esp
	pop	ebp
	ret	0
__JustMyCode_Default ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File E:\code\StudyProject\014\CApp\Source.cpp
;	COMDAT _main
_TEXT	SEGMENT
_result$ = -12						; size = 8
_main	PROC						; COMDAT

; 12   : {

	push	ebp
	mov	ebp, esp
	sub	esp, 208				; 000000d0H
	push	ebx
	push	esi
	push	edi
	lea	edi, DWORD PTR [ebp-208]
	mov	ecx, 52					; 00000034H
	mov	eax, -858993460				; ccccccccH
	rep stosd
	mov	ecx, OFFSET __2DB7E14F_Source@cpp
	call	@__CheckForDebuggerJustMyCode@4

; 13   : 	double result = getCylinderVolume(10, 100);

	sub	esp, 8
	movsd	xmm0, QWORD PTR __real@4059000000000000
	movsd	QWORD PTR [esp], xmm0
	sub	esp, 8
	movsd	xmm0, QWORD PTR __real@4024000000000000
	movsd	QWORD PTR [esp], xmm0
	call	?getCylinderVolume@@YANNN@Z		; getCylinderVolume
	add	esp, 16					; 00000010H
	fstp	QWORD PTR _result$[ebp]

; 14   : 	printf("Volume=%f\n",result);

	sub	esp, 8
	movsd	xmm0, QWORD PTR _result$[ebp]
	movsd	QWORD PTR [esp], xmm0
	push	OFFSET ??_C@_0L@LAMICECC@Volume?$DN?$CFf?6@
	call	_printf
	add	esp, 12					; 0000000cH

; 15   : 	return 0;

	xor	eax, eax

; 16   : }

	pop	edi
	pop	esi
	pop	ebx
	add	esp, 208				; 000000d0H
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	0
_main	ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File E:\code\StudyProject\014\CApp\Source.cpp
;	COMDAT ?getCylinderVolume@@YANNN@Z
_TEXT	SEGMENT
_volume$ = -28						; size = 8
_area$ = -12						; size = 8
_r$ = 8							; size = 8
_h$ = 16						; size = 8
?getCylinderVolume@@YANNN@Z PROC			; getCylinderVolume, COMDAT

; 4    : {

	push	ebp
	mov	ebp, esp
	sub	esp, 224				; 000000e0H
	push	ebx
	push	esi
	push	edi
	lea	edi, DWORD PTR [ebp-224]
	mov	ecx, 56					; 00000038H
	mov	eax, -858993460				; ccccccccH
	rep stosd
	mov	ecx, OFFSET __2DB7E14F_Source@cpp
	call	@__CheckForDebuggerJustMyCode@4

; 5    : 	double area = 3.1416 * r * r;

	movsd	xmm0, QWORD PTR __real@400921ff2e48e8a7
	mulsd	xmm0, QWORD PTR _r$[ebp]
	mulsd	xmm0, QWORD PTR _r$[ebp]
	movsd	QWORD PTR _area$[ebp], xmm0

; 6    : 	double volume = area * h;

	movsd	xmm0, QWORD PTR _area$[ebp]
	mulsd	xmm0, QWORD PTR _h$[ebp]
	movsd	QWORD PTR _volume$[ebp], xmm0

; 7    : 	return volume;

	fld	QWORD PTR _volume$[ebp]

; 8    : 
; 9    : }

	pop	edi
	pop	esi
	pop	ebx
	add	esp, 224				; 000000e0H
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	0
?getCylinderVolume@@YANNN@Z ENDP			; getCylinderVolume
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File C:\Program Files (x86)\Windows Kits\10\Include\10.0.18362.0\ucrt\stdio.h
;	COMDAT _printf
_TEXT	SEGMENT
__ArgList$ = -20					; size = 4
__Result$ = -8						; size = 4
__Format$ = 8						; size = 4
_printf	PROC						; COMDAT

; 954  :     {

	push	ebp
	mov	ebp, esp
	sub	esp, 228				; 000000e4H
	push	ebx
	push	esi
	push	edi
	lea	edi, DWORD PTR [ebp-228]
	mov	ecx, 57					; 00000039H
	mov	eax, -858993460				; ccccccccH
	rep stosd
	mov	ecx, OFFSET __AD6A91B7_stdio@h
	call	@__CheckForDebuggerJustMyCode@4

; 955  :         int _Result;
; 956  :         va_list _ArgList;
; 957  :         __crt_va_start(_ArgList, _Format);

	lea	eax, DWORD PTR __Format$[ebp+4]
	mov	DWORD PTR __ArgList$[ebp], eax

; 958  :         _Result = _vfprintf_l(stdout, _Format, NULL, _ArgList);

	mov	eax, DWORD PTR __ArgList$[ebp]
	push	eax
	push	0
	mov	ecx, DWORD PTR __Format$[ebp]
	push	ecx
	mov	esi, esp
	push	1
	call	DWORD PTR __imp____acrt_iob_func
	add	esp, 4
	cmp	esi, esp
	call	__RTC_CheckEsp
	push	eax
	call	__vfprintf_l
	add	esp, 16					; 00000010H
	mov	DWORD PTR __Result$[ebp], eax

; 959  :         __crt_va_end(_ArgList);

	mov	DWORD PTR __ArgList$[ebp], 0

; 960  :         return _Result;

	mov	eax, DWORD PTR __Result$[ebp]

; 961  :     }

	pop	edi
	pop	esi
	pop	ebx
	add	esp, 228				; 000000e4H
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	0
_printf	ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File C:\Program Files (x86)\Windows Kits\10\Include\10.0.18362.0\ucrt\stdio.h
;	COMDAT __vfprintf_l
_TEXT	SEGMENT
__Stream$ = 8						; size = 4
__Format$ = 12						; size = 4
__Locale$ = 16						; size = 4
__ArgList$ = 20						; size = 4
__vfprintf_l PROC					; COMDAT

; 642  :     {

	push	ebp
	mov	ebp, esp
	sub	esp, 192				; 000000c0H
	push	ebx
	push	esi
	push	edi
	lea	edi, DWORD PTR [ebp-192]
	mov	ecx, 48					; 00000030H
	mov	eax, -858993460				; ccccccccH
	rep stosd
	mov	ecx, OFFSET __AD6A91B7_stdio@h
	call	@__CheckForDebuggerJustMyCode@4

; 643  :         return __stdio_common_vfprintf(_CRT_INTERNAL_LOCAL_PRINTF_OPTIONS, _Stream, _Format, _Locale, _ArgList);

	mov	esi, esp
	mov	eax, DWORD PTR __ArgList$[ebp]
	push	eax
	mov	ecx, DWORD PTR __Locale$[ebp]
	push	ecx
	mov	edx, DWORD PTR __Format$[ebp]
	push	edx
	mov	eax, DWORD PTR __Stream$[ebp]
	push	eax
	call	___local_stdio_printf_options
	mov	ecx, DWORD PTR [eax+4]
	push	ecx
	mov	edx, DWORD PTR [eax]
	push	edx
	call	DWORD PTR __imp____stdio_common_vfprintf
	add	esp, 24					; 00000018H
	cmp	esi, esp
	call	__RTC_CheckEsp

; 644  :     }

	pop	edi
	pop	esi
	pop	ebx
	add	esp, 192				; 000000c0H
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	0
__vfprintf_l ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File C:\Program Files (x86)\Windows Kits\10\Include\10.0.18362.0\ucrt\corecrt_stdio_config.h
;	COMDAT ___local_stdio_printf_options
_TEXT	SEGMENT
___local_stdio_printf_options PROC			; COMDAT

; 86   :     {

	push	ebp
	mov	ebp, esp
	sub	esp, 192				; 000000c0H
	push	ebx
	push	esi
	push	edi
	lea	edi, DWORD PTR [ebp-192]
	mov	ecx, 48					; 00000030H
	mov	eax, -858993460				; ccccccccH
	rep stosd
	mov	ecx, OFFSET __F66CEB67_corecrt_stdio_config@h
	call	@__CheckForDebuggerJustMyCode@4

; 87   :         static unsigned __int64 _OptionsStorage;
; 88   :         return &_OptionsStorage;

	mov	eax, OFFSET ?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA ; `__local_stdio_printf_options'::`2'::_OptionsStorage

; 89   :     }

	pop	edi
	pop	esi
	pop	ebx
	add	esp, 192				; 000000c0H
	cmp	ebp, esp
	call	__RTC_CheckEsp
	mov	esp, ebp
	pop	ebp
	ret	0
___local_stdio_printf_options ENDP
_TEXT	ENDS
END
