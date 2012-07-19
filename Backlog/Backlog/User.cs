using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// ユーザを表すクラスです。
    /// </summary>
    public class User
    {
        /// <summary>
        /// ユーザID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// ハンドルネーム
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }
    }
}
