::先停止MySQL服务
net stop mysql57

::设置备份文件夹的起名格式
set "Ymd=%date:~,4%%date:~5,2%%date:~8,2%%time:~0,2%%time:~3,2%%time:~6,2%"

::使用xcopy命令进行拷贝(路径仅供参考)
xcopy /y "D:\DataBase\MySQL Server 5.7\Data\warehouse\*.*"  "D:\db_backup\%Ymd%\"


::启动MySQL服务
net start mysql57

