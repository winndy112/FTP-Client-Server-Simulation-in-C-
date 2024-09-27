# FTP-Client-Server-Simulation-in-C#
This project explores the implementation of an FTP (File Transfer Protocol) protocol. It simulates how FTP clients and servers communicate over TCP, handling file transfers using active mode and passive mode over UI and Console log.

## Tools and Technologies
- C#: The project is implemented using C#, which is ideal for handling network communication due to its rich libraries and support for socket programming.
- .NET Framework: The project leverages the .NET framework, which provides robust networking classes like TcpClient and TcpListener for creating the FTP client and server.
- Socket Programming: Used for creating low-level communication between the FTP client and server over TCP. Sockets enable sending and receiving data over the network.
- FTP Protocol (File Transfer Protocol): This project simulates an FTP system, adhering to standard protocol rules for file transfer, user authentication, and connection management, particularly focusing on active mode FTP.

## Components
- FTP Client:
>- File Upload: The client connects to the FTP server and sends files for storage, using TCP connections to ensure reliable data transfer.
>- File Download: Retrieves files from the server, allowing users to access stored data locally.
>- Directory Listing: The client can request a list of files or directories available on the server, displaying them for user interaction.
>- Command Execution: The client sends commands to the server to perform actions like retrieving files or changing directories.
- FTP Server:
>- User Authentication: The server validates user credentials, ensuring secure access control.
>- Request Handling: Responds to client requests for file uploads, downloads, and directory listings. It maintains a log of sessions and actions.
>- Active Mode FTP: The server listens on one port (21) for control commands and another (20) for data transfer, coordinating with the client to manage file transfers.
>- Session Management: It ensures client-server communication persists throughout file transfers and terminates connections gracefully after use.




