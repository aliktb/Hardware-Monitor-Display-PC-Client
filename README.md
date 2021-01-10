## Hardware Monitor Display - PC Client

Read CPU and GPU temperature readings, then display them as a set of gauges on an external display.

This is the Windows Forms Application to be run on the Windows PC. For the Raspberry Pi python scripts see this repository: https://github.com/aliktb/Hardware-Display-Monitor-Pi-Server

-----

### Requirements

1. Visual Studio 2017 or 2019 with latest update
2. Windows 10 (admin account) with .Net Framework 4.6.2
3. Raspberry Pi (tested with model 3B+ but should work with any variant) with Micro SD card and monitor
4. ethernet cable and optional USB to ethernet dongle if no spare ethernet is available on PC


### Usage

1. Configure ethernet to run on subnet `190.160.1.xxx` either with the onboard motherboard LAN or with a USB to ethernet adapter. Static IPs can be assigned through Network and Sharing Center in Control Panel and configuring the IPV4 address manually for the ethernet adapter. The subnet should not interfere with existing networks typically using subnet `192.168.xxx.xxx`. Allowing custom subnets is not yet available.
2. Compile with Windows Form Application using Visual Studio using .NET Framework 4.6.2. 

### Credits

Temperature data obtained from [Open Hardware Monitor](https://github.com/openhardwaremonitor/openhardwaremonitor)'s `OpenHardwareMonitorLib`


Inspiration and original code: https://github.com/logchan/open-hardware-monitor-arduino

Forked from: https://github.com/octal-ip/open-hardware-monitor-arduino
