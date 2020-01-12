# ShutdownAfterInput
Program that will shutdown any Windows PC after any mouse movement.


# Disclaimer
I am not responsible for any data loss due to undesired shutdown by you or someone else by the utilization of this program.


# What happens after you set a timer?
The user interface will disappear making not possible to stop the process of the program, but killing it quickly on the Task Manager.

After the given time ends, immediately, the program will save the current coordinates of your mouse and will be checking if these coordinates change every 0.5 seconds.

# What happens when the program detects the mouse coordinates changed?
The program will immediately shutdown the PC.

# How exactly the program manages to shutdown the Windows PC?
A command prompt line is executed to do so. The specific command executed is: "shutdown -s -t 0". The "0" means the PC will shutdown in 0 seconds resulting in a sudden shutdown.

# Can this program/command to shutdown damage a PC?
No. The command "shutdown -s -t 0" is an inner Windows command which emulates when you manually press the button "Shut down" on Windows.

# Is there a way to cancel the program if I set a timer by error/without intention to?
If the timer you set has not ended yet, you can kill the program on the Task Manager to prevent the shutdown. If the timer ended, you can still try to kill the program on the Task Manager by just using the keyboard.
