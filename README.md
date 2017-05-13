### MEmu Image Capture

This is an example of how to capture an image of the Memu Android Emulator window.

Note: GetWindowRect only works if the process is on top i.e. not behind other windows.

You can see that Managed.ADB screenshot is a lot slower than GetWindowRect, but works when the window is hidden.


![Screenshot](/Screen.png "Screenshot")

