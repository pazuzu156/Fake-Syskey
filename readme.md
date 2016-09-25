# Fake Syskey
Scammers are well known for turning on syskey on their victim's computers. Since we know better, we don't want them to have access to this powerful tool of destruction (if a scammer is using it that is).

This little applet is a "replacement" fake version of syskey, in that it looks and acts like the real deal, with a twist!

## The Twist
Apon successful completion of setting the password through syskey, they're greated with a little message, letting them know that the scammer has been scammed!

## Building
To build the app, you need Visual Studio. This is built in 2013 Pro, but any version of VS from 2013+ will work. Simply run `build.bat` and follow the instructions.

## Planned Features (In the works ;))
Fake Syskey now has support for custom messages. At the moment, I'm working on a tool for creating your own with ease. Please refer to the [Custom Messages](#custom-messages) section for details

## Installing
To install, go to `C:\Windows\System32` and rename syskey.exe to syskey.exe.bak (so you still have the real thing, don't wannt remove it do we?) and paste the new syskey.exe in it's place.

Keep in mind, you need your account to have full access, otherwise, you'll get an error needing the "TrustedInstaller" to allow access to it. Just change the file's permissions. (Be sure to change them back once you're done as to not leave the file open for others to screw with!)

## Message Creator
Message Creator is built in WPF, so it looks and works a bit different than WinForms. It also requires the UniversalControls.dll AND syskey.exe in the same directory to work. syskey.exe however, can operate independent of both the dll and Message Creator, so if all you want is syskey.exe, then go for it!

## Custom Messages
I'm working on building a message creation tool for adding custom messages. However, Fake Syskey already has the functionality built in to support custom messages. On first launch (after opening the password window) a settings file and a messages file are created under `C:\Users\YOU\AppData\Roaming\fake syskey`

It's easy to edit both if you know JSON, since they're done in that. The messages.json is just one big list with the following structure:

```javascript
[
  {
    "title": "MessageBox Title",
    "message": "The message to display"
  },
  {
    "title": "Message2",
    "message": "This is another message!"
  }
]
```

Message order doesn't matter, they're picked at random when called to be displayed.

## Cloning
Cloning Fake Syskey is a tad different now, since UniversalControlsXAML is included as a sub module. When cloning, you'll also need to include the sub module.

The Hard Way:

```shell
$ git clone https://github.com/pazuzu156/fake-syskey.git
$ cd UniversalControlsXAML
$ git submodule init
$ git submodule update
```

The Easy Way:

```shell
$ git clone --recursive https://github.com/pazuzu156/fake-syskey.git
```

**DISCLAIMER**
While I'm using the public URL for cloning THIS repository, it's best to fork it and clone your fork. It'll still be able to clone the sub module, but this way you can push any changes you make and easily make a pull request.

## Uninstalling
To remove, go to `C:\Windows\System32` and delete the fake syskey, and rename syskey.exe.bak (assuming you did as I commanded....) to syskey.exe. Now, you're back in business!

## Downloads
Downloads are hosted here on [good 'ol Github](https://github.com/pazuzu156/Fake-Syskey/releases)
