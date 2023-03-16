# Seconds In Tray Icon
Show current seconds in task bar.<br/>

## Download and Run
#### Download 
Download and unzip "SystemTrayApp.zip"
#### Run
Run the .exe<br/>
The program start in system tray<br/>
Open by clicking on the tray icon or right mouse buton for context menu.

## Windows 11 Update T-T
After Windows 11 Update<br/>
there were no dynamic seconds to be shown for the current system.<br/>
At least easy way to access them<br/>
So I made this simple Tray Icon app that show seconds<br/>

## Functions
Simple program that show current time and seconds
#### Form
![image](https://user-images.githubusercontent.com/34564081/225565879-8e6de389-b5e2-4f00-be11-a54db111e17f.png)<br/>
#### Auto Start
In the upper right corner there is a button<br/>
![image](https://user-images.githubusercontent.com/34564081/225568340-ea9a0c60-d5c0-45be-a599-9c5e8dff0abf.png)
Red - If not set for auto start.<br/>
![image](https://user-images.githubusercontent.com/34564081/225568272-53e5aca7-af55-4ef2-ac0d-6bc035cfd1d2.png)
Green - If it will auto start with windows.
#### Tray Icon
![image](https://user-images.githubusercontent.com/34564081/225581012-a2521ece-f355-477b-9e59-5b14d3790321.png)<br/>
Updates each 500ms and changes the icon to the coresponding seconds.<br/>
The icons can be changed in Resources folder with more beautifull ones.<br/>

## Program
1. Generates Icons for each second at start up from a default empty icon<br/>
- Generate array with 60 Icons<br/>
2. Each 500ms changes to coresponding icon<br/>
- Get the current seconds and get the Icon from Array[seconds]
