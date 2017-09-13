# HikPasswordHelper
A tool which exploits a backdoor in Hikvision camera firmwares circa 2014-2016 ([ICSA-17-124-01](http://seclists.org/fulldisclosure/2017/Sep/23)) to help the owner change a forgotten password.

## Usage

Download from [the releases tab](https://github.com/bp2008/HikPasswordHelper/releases) and run the exe.

There are 5 simple steps to reset a password, and you can even skip steps 3 and 4 in many cases.

![Screenshot](https://i.imgur.com/3uAzhaR.png)

## Requirements

.NET Framework 4.5.2 - This is included in any modern Windows installation.

A Hikvision device that is vulnerable to [ICSA-17-124-01](http://seclists.org/fulldisclosure/2017/Sep/23).

## Special Thanks

This tool was make possible thanks to the efforts of user montecrypto from the ipcamtalk forum.

https://ipcamtalk.com/threads/backdoor-found-in-hikvision-cameras.17523/

## See Also

If your firmware is too old to use this method to reset a lost password, you can try the reset code method:

https://ipcamtalk.com/threads/hikvision-camera-admin-password-reset-tool.2837/

If your firmware is too new, then I'm afraid you are out of luck because the reset code method won't work either.
