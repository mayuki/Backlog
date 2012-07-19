using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// カテゴリを表すクラスです。
    /// </summary>
    public class Component
    {
        /// <summary>
        /// カテゴリID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// カテゴリ名
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }
    }
}
