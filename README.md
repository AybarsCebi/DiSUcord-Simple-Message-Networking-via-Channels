Sabanci University CS 408 - Computer Networks - Fall 2023 Course Project

DiSUcord, Simple Message Networking via Channels:

In this project, you are going to develop a message networking application called DiSUcord (SU version of Discord) by implementing Client and Server modules. (i) The Server module manages messages and channels and (ii) the Client module acts as a user who subscribes to channels, sends messages to channels, and view messages sent to the subscribed channels.

The server listens on a predefined port and accepts incoming client connections. There might be one or more clients connected to the server at the same time. Each client knows the IP address and the listening port of the server (to be entered through the Graphical User Interface (GUI)). Clients connect to the server through this port and identify themselves with their usernames. The server needs to keep the usernames of the currently connected clients in order to avoid the same name being connected more than once at a given time. Clients connect only via usernames (i.e. no password or other type of security).

In DiSUcord, there are two fixed channels, namely "IF 100" and "SPS 101". For the sake of simplicity, these channels' names will not change and you do not need to get their names as input. A client may subscribe to one or both of the channels through the client GUI at any time after the connection. A client can send messages only to the subscribed channel(s). Moreover, the clients subscribed to a particular channel will receive messages sent to that channel.
