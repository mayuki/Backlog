using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// 課題の情報を含むクラスです。
    /// </summary>
    public class Issue
    {
        /// <summary>
        /// 課題ID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// 課題キー
        /// </summary>
        [XmlRpcMember("key")]
        public String Key { get; set; }
        
        /// <summary>
        /// 件名
        /// </summary>
        [XmlRpcMember("summary")]
        public String Summary { get; set; }
        
        /// <summary>
        /// 詳細
        /// </summary>
        [XmlRpcMember("description")]
        public String Description { get; set; }
        
        /// <summary>
        /// 課題のURL
        /// </summary>
        [XmlRpcMember("url")]
        public String Url { get; set; }

        /// <summary>
        /// 期限日(文字列)
        /// </summary>
        [XmlRpcMember("due_date")]
        public String DueDateString { get { return DueDate.HasValue ? DueDate.Value.ToString("yyyyMMdd") : null; } set { DueDate = String.IsNullOrWhiteSpace(value) ? null : (DateTime?)DateTime.ParseExact(value, "yyyyMMdd", null); } }
        /// <summary>
        /// 期限日
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// 開始日(文字列)
        /// </summary>
        [XmlRpcMember("start_date")]
        public String StartDateString { get { return StartDate.HasValue ? StartDate.Value.ToString("yyyyMMdd") : null; } set { StartDate = String.IsNullOrWhiteSpace(value) ? null : (DateTime?)DateTime.ParseExact(value, "yyyyMMdd", null); } }
        /// <summary>
        /// 開始日
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 予定時間(文字列)
        /// </summary>
        [XmlRpcMember("estimated_hours")]
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public String EstimatedHoursString { get { return (ActualHours != null) ? EstimatedHours.Value.ToString("HH:mm") : String.Empty; } set { EstimatedHours = TimeSpan.ParseExact(value, "HH:mm", null); } }
        /// <summary>
        /// 予定時間
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public TimeSpan? EstimatedHours { get; set; }

        /// <summary>
        /// 実績時間(文字列)
        /// </summary>
        [XmlRpcMember("actual_hours")]
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public String ActualHoursString { get { return (ActualHours != null) ? ActualHours.Value.ToString("HH:mm") : String.Empty; } set { ActualHours = TimeSpan.ParseExact(value, "HH:mm", null); } }
        /// <summary>
        /// 実績時間
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public TimeSpan? ActualHours { get; set; }

        /// <summary>
        /// 種別
        /// </summary>
        [XmlRpcMember("issueType")]
        public IssueType IssueType { get; set; }

        /// <summary>
        /// 優先度
        /// </summary>
        [XmlRpcMember("priority")]
        public Priority Priority { get; set; }

        /// <summary>
        /// 完了理由
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("resolution")]
        public Resolution Resolution { get; set; }

        /// <summary>
        /// 状態
        /// </summary>
        [XmlRpcMember("status")]
        public Status Status { get; set; }

        /// <summary>
        /// カテゴリ
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("components")]
        public Component[] Components { get; set; }

        /// <summary>
        /// 発生バージョン
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("versions")]
        public Version[] Versions { get; set; }

        /// <summary>
        /// マイルストーン
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("milestones")]
        public Milestone[] Milestones { get; set; }

        /// <summary>
        /// 登録者
        /// </summary>
        [XmlRpcMember("created_user")]
        public User CreatedUser { get; set; }

        /// <summary>
        /// 担当者
        /// </summary>
        [XmlRpcMember("assigner")]
        public User Assigner { get; set; }

        /// <summary>
        /// 登録日時(文字列)
        /// </summary>
        [XmlRpcMember("created_on")]
        public String CreatedOnString { get { return CreatedOn.ToString("yyyyMMddHHmmss"); } set { CreatedOn = DateTime.ParseExact(value, "yyyyMMddHHmmss", null); } }
        /// <summary>
        /// 登録日時
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 最終更新日時(文字列)
        /// </summary>
        [XmlRpcMember("updated_on")]
        public String UpdatedOnString { get { return UpdatedOn.ToString("yyyyMMddHHmmss"); } set { UpdatedOn = DateTime.ParseExact(value, "yyyyMMddHHmmss", null); } }
        /// <summary>
        /// 最終更新日時
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// カスタム属性
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("custom_fields")]
        public CustomField[] CustomFields { get; set; }

    }
}
