# Basic_Network_Programming_Project
This is our project for educational purposes. 

# FTP
- File Tranfer Protocol
- Port 21 for issuing commands. For example:
```
C:\Users\PC>ftp
ftp> help
Commands may be abbreviated.  Commands are:

!               delete          literal         prompt          send
?               debug           ls              put             status
append          dir             mdelete         pwd             trace
ascii           disconnect      mdir            quit            type
bell            get             mget            quote           user
binary          glob            mkdir           recv            verbose
bye             hash            mls             remotehelp
cd              help            mput            rename
close           lcd             open            rmdir
ftp> quit

C:\Users\PC>
```

- Port 20 for tranfering files during active mode session.
For example, `get <filename>` is downloading `<filename>` from server. `put <filename>` is uploading `<filename>` to server.

Xem thêm tại: 
- https://youtu.be/GCG5zHjE9gM?si=kgYAYrjwW6d0lP3y

- https://github.com/PSukhalani-96/FTP

## FTP Client
Sử dụng socket - kết nối TCP. Giao diện gồm mấy thứ tạm tạm như này.
### 1. Sign up 
- Port 21
### 2. Sign in 
- Port 21
### 3. Upload file 
- Port 21 - Gọi hàm xử lý
- Port 20 - Truyền file
### 4. Download file 
- Port 21 - Gọi hàm xử lý
- Port 20 - Truyền file

### 5. Get list of files
- Port 21

![FTPS](/photo/image.png)


## FTP Server
Server listen Client -> nếu có yêu cầu kết nối
- Kiểm tra đăng nhập
- Gửi message cho client


## Overview

FTP có 3 phương thức truyền dữ liệu là : stream mode, block mode và compressed mode

### Mã thông điệp
![LoginStatusCode](/photo/image-1.png)

![DownloadStatusCode](/photo/image-2.png)
![UploadStatusCode](/photo/image-3.png)


Xem thêm tại: 
https://luanvan.net.vn/luan-van/do-an-tim-hieu-ve-giao-thuc-ftp-32410/


## TASK
- Chọn database (Mongo): 
    - Lưu account
    - File thì tau không chắc nhưng maybe là có đó

- Thiết kế giao diện FTP Client:
    - Viết các hàm xử lý 

- Thiết kế giao diện FTP Server





