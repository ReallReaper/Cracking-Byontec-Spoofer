namespace dump
{
.rdata:00000001400043A8 Name            db 'SeDebugPrivilege',0 ; DATA XREF: sub_140001000+33↑o
.rdata:00000001400043B9                 align 20h
.rdata:00000001400043C0 ; const char aEpicgameslaunc[]
.rdata:00000001400043C0 aEpicgameslaunc db 'EpicGamesLauncher.exe',0
.rdata:00000001400043C0                                         ; DATA XREF: main:loc_140001F90↑o
.rdata:00000001400043D6                 align 8
.rdata:00000001400043D8 ; const char aTaskkillFImEpi[]
.rdata:00000001400043D8 aTaskkillFImEpi db 'TASKKILL /F /IM EpicGamesLauncher.exe >NUL 2> 1',0
.rdata:00000001400043D8                                         ; DATA XREF: main+F2A↑o
.rdata:0000000140004408 ; const char aClosedEpicGame[]
.rdata:0000000140004408 aClosedEpicGame db 0Ah                  ; DATA XREF: main:loc_14000200B↑o
.rdata:0000000140004408                 db '  [-] Closed Epic Games',0Ah,0
.rdata:0000000140004422                 align 8
.rdata:0000000140004428 ; const char aUnrealcefsubpr[]
.rdata:0000000140004428 aUnrealcefsubpr db 'UnrealCEFSubProcess.exe',0
.rdata:0000000140004428                                         ; DATA XREF: main:loc_140001E50↑o
.rdata:0000000140004440 ; const char aTaskkillFImUnr[]
.rdata:0000000140004440 aTaskkillFImUnr db 'TASKKILL /F /IM UnrealCEFSubProcess.exe >NUL 2> 1',0
.rdata:0000000140004440                                         ; DATA XREF: main+DEA↑o
.rdata:0000000140004472                 align 8
.rdata:0000000140004478 ; const char aClosedUnrealce[]
.rdata:0000000140004478 aClosedUnrealce db 0Ah                  ; DATA XREF: main:loc_140001ECB↑o
.rdata:0000000140004478                 db '  [-] Closed UnrealCEFSub',0Ah,0
.rdata:0000000140004494                 align 8
.rdata:0000000140004498 ; const char String2[]
.rdata:0000000140004498 String2         db 'FortniteClient-Win64-Shipping.exe.exe',0
.rdata:0000000140004498                                         ; DATA XREF: main:loc_140001D10↑o
.rdata:00000001400044BE                 align 20h
.rdata:00000001400044C0 ; const char Command[]
.rdata:00000001400044C0 Command         db 'TASKKILL /F /IM FortniteClient-Win64-Shipping.exe >NUL 2> 1',0
.rdata:00000001400044C0                                         ; DATA XREF: main+CAA↑o
.rdata:00000001400044FC                 align 20h
.rdata:0000000140004500 ; const char aClosedFortnite[]
.rdata:0000000140004500 aClosedFortnite db 0Ah                  ; DATA XREF: main:loc_140001D8B↑o
.rdata:0000000140004500                 db '  [-] Closed FortniteClient',0Ah,0
.rdata:000000014000451E                 align 20h
.rdata:0000000140004520 qword_140004520 dq 3220313220706553h    ; DATA XREF: main+10B8↑r
.rdata:0000000140004528 word_140004528  dw 3230h                ; DATA XREF: main+10C5↑r
.rdata:000000014000452A byte_14000452A  db 32h                  ; DATA XREF: main+10D0↑r
.rdata:000000014000452B                 align 10h
.rdata:0000000140004530 aWelcomeToByont db '                                              Welcome to Byontec '
.rdata:0000000140004530                                         ; DATA XREF: main+1109↑o
.rdata:0000000140004530                 db 'Spoofer',0
.rdata:0000000140004579                 align 20h
.rdata:0000000140004580 aMadeByTrGe     db '                                                  Made By Tr.ge#3'
.rdata:0000000140004580                                         ; DATA XREF: main+1124↑o
.rdata:0000000140004580                 db '607',0
.rdata:00000001400045C5                 align 8
.rdata:00000001400045C8 ; const CHAR Caption[]
.rdata:00000001400045C8 Caption         db 'Need Permissions',0 ; DATA XREF: main+106A↑o
.rdata:00000001400045D9                 align 20h
.rdata:00000001400045E0 ; const CHAR Text[]
.rdata:00000001400045E0 Text            db 'please, run me as admin.',0
.rdata:00000001400045E0                                         ; DATA XREF: main+1071↑o
.rdata:00000001400045F9                 align 20h
.rdata:0000000140004600 ; const CHAR aHttpsCdnDiscor[]
.rdata:0000000140004600 aHttpsCdnDiscor db 'https://cdn.discordapp.com/attachments/1018150269214801930/101821'
.rdata:0000000140004600                                         ; DATA XREF: main+1253↑o
.rdata:0000000140004600                 db '6938926784583/mapper.exe',0
.rdata:000000014000465A                 align 20h
.rdata:0000000140004660 ; const CHAR FileName[]
.rdata:0000000140004660 FileName        db 'C:WindowsBootPCATcs-CZmapper.exe',0
.rdata:0000000140004660                                         ; DATA XREF: main+124C↑o
.rdata:0000000140004660                                         ; main+13C3↑o
.rdata:0000000140004681                 align 10h
.rdata:0000000140004690 ; const CHAR aHttpsCdnDiscor_0[]
.rdata:0000000140004690 aHttpsCdnDiscor_0 db 'https://cdn.discordapp.com/attachments/1018150269214801930/102063'
.rdata:0000000140004690                                         ; DATA XREF: main+1271↑o
.rdata:0000000140004690                 db '2226666385438/german_on_top_1.sys',0
.rdata:00000001400046F3                 align 8
.rdata:00000001400046F8 ; const CHAR aCWindowsbootpc_0[]
.rdata:00000001400046F8 aCWindowsbootpc_0 db 'C:WindowsBootPCATcs-CZgerman_on_top_1.sys',0
.rdata:00000001400046F8                                         ; DATA XREF: main+126A↑o
.rdata:00000001400046F8                                         ; main+13D0↑o
.rdata:0000000140004722                 align 10h
.rdata:0000000140004730 ; const char aCWindowsbootpc_1[]
.rdata:0000000140004730 aCWindowsbootpc_1 db 'C:WindowsBootPCATcs-CZmapper.exe C:WindowsBootPCATcs-CZgerman_on_'
.rdata:0000000140004730                                         ; DATA XREF: main+1280↑o
.rdata:0000000140004730                 db 'top_1.sys',0
.rdata:000000014000477B                 align 20h
.rdata:0000000140004780 ; const CHAR aHttpsCdnDiscor_1[]
.rdata:0000000140004780 aHttpsCdnDiscor_1 db 'https://cdn.discordapp.com/attachments/1017468370356011008/102036'
.rdata:0000000140004780                                         ; DATA XREF: main+131B↑o
.rdata:0000000140004780                 db '3837809119332/Byontec_checker.bat',0
.rdata:00000001400047E3                 align 8
.rdata:00000001400047E8 ; const CHAR aCWindowsbyonte[]
.rdata:00000001400047E8 aCWindowsbyonte db 'C:WindowsByontec_checker.bat',0
.rdata:00000001400047E8                                         ; DATA XREF: main+1314↑o
.rdata:00000001400047E8                                         ; main+132A↑og
}