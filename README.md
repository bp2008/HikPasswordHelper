# HikPasswordHelper
A tool which exploits a backdoor in Hikvision camera firmwares circa 2014-2016 ([ICSA-17-124-01](http://seclists.org/fulldisclosure/2017/Sep/23)) to help the owner change a forgotten password.

## Usage

Download [`HikvisionPasswordResetHelper.exe` from the releases tab](https://github.com/bp2008/HikPasswordHelper/releases) and run the exe.

There are 5 simple steps to reset a password, and you can even skip steps 3 and 4 in many cases.

![Screenshot](https://i.imgur.com/3uAzhaR.png)

## Requirements

.NET Framework 4.5.2 - This is included in any modern Windows installation.

A Hikvision device that is vulnerable to [ICSA-17-124-01](http://seclists.org/fulldisclosure/2017/Sep/23).

Here is an *incomplete* list of camera firmwares that have been reported to be vulnerable or not.  This list is compiled from various sources and the camera models are unspecified.  [Some camera models are reportedly vulnerable at different ranges of firmware versions](https://ics-cert.us-cert.gov/advisories/ICSA-17-124-01), so I would not put complete faith in the accuracy of this list for all camera models.

### Hikvision Camera Firmware Versions
```diff
- V5.1.6 build 140412 - NOT Vulnerable (to ICSA-17-124-01)  
+ V5.2.0 build 140721 - Vulnerable  
+ V5.2.0 build 141016 - Vulnerable  
+ V5.3.0 build 150513 - Vulnerable  
+ V5.3.6 build 151105 - Vulnerable  
+ V5.3.8 build 151224 - Vulnerable
+ V5.3.5 build 161112 - Vulnerable  
+ V5.4.0 build 160401 - Vulnerable  
+ V5.4.0 build 160520 - Vulnerable  
+ V5.4.3 build 160705 - Vulnerable  
+ V5.4.3 build 160808 - Vulnerable  
+ V5.4.4 build 161125 - Vulnerable  
+ V5.3.9 build 170109 - Vulnerable  
- V5.4.3 build 170123 - NOT Vulnerable  
- V5.4.5 Build 170123 - NOT Vulnerable  
- V5.4.3 build 170217 - NOT Vulnerable  
```

## Special Thanks

This tool was make possible thanks to the efforts of user montecrypto from the ipcamtalk forum.

https://ipcamtalk.com/threads/backdoor-found-in-hikvision-cameras.17523/

## See Also

If your firmware is too old to use this method to reset a lost password, you can try the reset code method:

https://ipcamtalk.com/threads/hikvision-camera-admin-password-reset-tool.2837/

If your firmware is too new, then I'm afraid you are out of luck because the reset code method won't work either.
