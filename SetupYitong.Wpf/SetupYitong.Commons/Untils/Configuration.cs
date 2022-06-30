using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Commons.Untils
{
    public class Configuration
    {
        public class SerivceFiguration
        {
            /// <summary>
            /// 配置文件
            /// </summary>
            public const string INI_CFG = "config\\user.ini";

            /// <summary>
            /// 保存记录
            /// </summary>
            public const string Save_Records = "data\\userSettings.ini";

            /// <summary>
            /// 版本文件
            /// </summary>
            public const string INI_VERSION = "config\\version.ini";
        }
    }
}
