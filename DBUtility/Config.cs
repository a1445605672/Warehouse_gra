using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
    public class Config
    {
        //选择连接类型 0为远程，非0为本地
        public static int connect_type = 0;

        //数据备份文件夹
        public static string Backup_folder = @"D:\db_backup";

        //Mysql数据库所在文件夹
        public static string Backup_origin = @"D:\DataBase\MySQL Server 5.7\Data\warehouse\";


        //数据备份批处理文件
        public static string Backup_bat = @"E:\0421\Warehouse_gra\Backup_And_Recovery\mysql_backup.bat";

        //数据恢复批处理文件
        public static string Recover_bat = @"E:\0421\Warehouse_gra\Backup_And_Recovery\mysql_recover.bat";

        //数据备份批处理文件 
        //public static string Backup_bat = @"C:\Users\qinrui\Documents\GitHub\Warehouse_gra\Backup_And_Recovery\mysql_backup.bat";

        ////数据恢复批处理文件
        //public static string Recover_bat = @"C:\Users\qinrui\Documents\GitHub\Warehouse_gra\Backup_And_Recovery\mysql_recover.bat";

    }
}
