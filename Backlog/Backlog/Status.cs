using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// 状態を表すクラスです。
    /// </summary>
    public class Status
    {
        /// <summary>
        /// 状態ID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// 状態
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }
    }
}
