# Fake Syskey
Scammers are well known for turning on syskey on their victim's computers. Since we know better, we don't want them to have access to this powerful tool of destruction (if a scammer is using it that is).

This little applet is a "replacement" fake version of syskey, in that it looks and acts like the real deal, with a twist!

## The Twist
Apon successful completion of setting the password through syskey, they're greated with a little message, letting them know that the scammer has been scammed!

## Building
To build the app, you need Visual Studio. This is built in 2013 Pro, but any version of VS from 2013+ will work. Just open the solution file, and select the build you want (Release|Debug) and F6 will build it.

## Planned Features
Fake syskey gives a gotcha message to the scammer, wouldn't it be nice to customize your own message? I'll add that in soon!

## Installing
To install, go to `C:\Windows\System32` and rename syskey.exe to syskey.exe.bak (so you still have the real thing, don't wannt remove it do we?) and paste the new syskey.exe in it's place.

## Uninstalling
To remove, go to `C:\Windows\System32` and delete the fake syskey, and rename syskey.exe.bak (assuming you did as I commanded....) to syskey.exe. Now, you're back in business!

## Downloads
Downloads are hosted here on [good 'ol Github](https://github.com/pazuzu156/Fake-Syskey/releases)
