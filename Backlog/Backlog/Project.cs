using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// プロジェクトの情報を含むクラスです。
    /// </summary>
    public class Project
    {
        /// <summary>
        /// プロジェクトID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// プロジェクト名
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }

        /// <summary>
        /// プロジェクトキー
        /// </summary>
        [XmlRpcMember("key")]
        public String Key { get; set; }

        /// <summary>
        /// プロジェクトホームURL
        /// </summary>
        [XmlRpcMember("url")]
        public String Url { get; set; }

        /// <summary>
        /// ダッシュボードに表示しないかどうか
        /// </summary>
        [XmlRpcMember("archived")]
        public Boolean Archived { get; set; }
    }
}
