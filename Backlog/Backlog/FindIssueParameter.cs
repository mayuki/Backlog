using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// FindIssueメソッドで指定できる検索のパラメータ
    /// </summary>
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class FindIssueParameter
    {
        /// <summary>
        /// FindIssueメソッドで指定できる検索のパラメータ
        /// </summary>
        /// <param name="projectId">プロジェクトID</param>
        public FindIssueParameter(Int32 projectId)
        {
            ProjectId = projectId;
        }

        /// <summary>
        /// プロジェクトID
        /// </summary>
        [XmlRpcMember("projectId")]
        public Int32 ProjectId { get; set; }

        /// <summary>
        /// 種別ID
        /// </summary>
        [XmlRpcMember("issueTypeId")]
        public Int32[] IssueTypeId { get; set; }

        /// <summary>
        /// カテゴリID (カテゴリが未設定のものを含める場合「-1」)
        /// </summary>
        [XmlRpcMember("componentId")]
        public Int32[] ComponentId { get; set; }

        /// <summary>
        /// 発生バージョンID (発生バージョンが未設定のものを含める場合「-1」)
        /// </summary>
        [XmlRpcMember("versionId")]
        public Int32[] VersionId { get; set; }

        /// <summary>
        /// マイルストーンID (マイルストーンが未設定のものを含める場合「-1」)
        /// </summary>
        [XmlRpcMember("milestoneId")]
        public Int32[] MilestoneId { get; set; }

        /// <summary>
        /// 状態ID
        /// </summary>
        [XmlRpcMember("statusId")]
        public Int32[] StatusId { get; set; }

        /// <summary>
        /// 優先度
        /// </summary>
        [XmlRpcMember("priorityId")]
        public Int32[] PriorityId { get; set; }

        /// <summary>
        /// 担当者ユーザID
        /// </summary>
        [XmlRpcMember("assignerId")]
        public Int32[] AssignerId { get; set; }

        /// <summary>
        /// 登録者ユーザID
        /// </summary>
        [XmlRpcMember("createdUserId")]
        public Int32[] CreatedUserId { get; set; }

        /// <summary>
        /// 完了理由ID
        /// </summary>
        [XmlRpcMember("resolutionId")]
        public Int32[] ResolutionId { get; set; }

        /// <summary>
        /// 課題の登録日 範囲開始日(YYYYMMDD)
        /// </summary>
        [XmlRpcMember("created_on_min")]
        public String CreatedOnMin { get; set; }

        /// <summary>
        /// 課題の登録日 範囲終了日(YYYYMMDD)
        /// </summary>
        [XmlRpcMember("created_on_max")]
        public String CreatedOnMax { get; set; }

        /// <summary>
        /// 課題の更新日 範囲開始日(YYYYMMDD)
        /// </summary>
        [XmlRpcMember("updated_on_min")]
        public String UpdatedOnMin { get; set; }

        /// <summary>
        /// 課題の更新日 範囲終了日(YYYYMMDD)
        /// </summary>
        [XmlRpcMember("updated_on_min")]
        public String UpdatedOnMax { get; set; }

        /// <summary>
        /// 課題の開始日 範囲開始日(YYYYMMDD)
        /// (プレミアムプラン以上で指定可)
        /// </summary>
        [XmlRpcMember("start_date_min")]
        public String StartDateMin { get; set; }

        /// <summary>
        /// 課題の開始日 範囲終了日(YYYYMMDD)
        /// (プレミアムプラン以上で指定可)
        /// </summary>
        [XmlRpcMember("start_date_max")]
        public String StartDateMax { get; set; }

        /// <summary>
        /// 課題の期限日 範囲開始日(YYYYMMDD)
        /// </summary>
        [XmlRpcMember("due_date_min")]
        public String DueDateMin { get; set; }

        /// <summary>
        /// 課題の期限日 範囲終了日(YYYYMMDD)
        /// </summary>
        [XmlRpcMember("due_date_max")]
        public String DueDateMax { get; set; }

        /// <summary>
        /// 検索キーワード
        /// </summary>
        [XmlRpcMember("query")]
        public String Query { get; set; }

        /// <summary>
        /// 並び順
        /// </summary>
        [XmlRpcMember("sort")]
        public String Sort { get; set; }

        /// <summary>
        /// 昇順かどうか(Falseの場合には降順)
        /// </summary>
        [XmlRpcMember("order")]
        public Boolean OrderByAsc { get; set; }

        /// <summary>
        /// 取得する検索結果のオフセット値 
        /// </summary>
        [XmlRpcMember("offset")]
        public Int32 Offset { get; set; }

        /// <summary>
        ///  取得する検索結果の課題数(0〜100) 
        /// </summary>
        [XmlRpcMember("limit")]
        public Int32 Limit { get; set; }

        /// <summary>
        /// 1 (添付ファイル有り)、2 (共有ファイルリンク有り)、両方を配列にて指定した場合はどちらかに該当するものが検索される
        /// </summary>
        [XmlRpcMember("file")]
        public Int32[] File { get; set; }

        /// <summary>
        /// 検索対象のカスタム属性種別によって要求するパラメータが変わります。(マックスプランで指定可)
        /// </summary>
        //[XmlRpcMember("custom_fields")]
        //public Object[] CustomFields { get; set; }

    }

    /// <summary>
    /// 並び方
    /// </summary>
    public static class FindIssueParameterSortType
    {
        /// <summary>
        /// 種別
        /// </summary>
        public const String IssueType = "ISSUE_TYPE";
        /// <summary>
        /// 件名
        /// </summary>
        public const String Summary = "SUMMARY";
        /// <summary>
        /// 状態
        /// </summary>
        public const String Status = "STATUS";
        /// <summary>
        /// 優先度
        /// </summary>
        public const String Priority = "PRIORITY";
        /// <summary>
        /// 登録日時
        /// </summary>
        public const String Created = "CREATED";
        /// <summary>
        /// 更新日時
        /// </summary>
        public const String Updated = "UPDATED";
        /// <summary>
        /// 期限日
        /// </summary>
        public const String DueDate = "DUE_DATE";
        /// <summary>
        /// カスタム属性
        /// </summary>
        /// <param name="id">カスタム属性ID</param>
        /// <returns></returns>
        public static String CustomField(Int32 id) { return "CUSTOM_FIELD_" + id; }
    }
}
