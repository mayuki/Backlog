using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// 種別を表すクラスです。
    /// </summary>
    public class IssueType
    {
        /// <summary>
        /// 種別ID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// 種別色
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }

        /// <summary>
        /// 種別色
        /// </summary>
        [XmlRpcMember("color")]
        public String Color { get; set; }
    }
}
