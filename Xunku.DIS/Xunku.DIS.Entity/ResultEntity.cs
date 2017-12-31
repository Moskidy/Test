using System.Collections.Generic;

namespace Xunku.DIS.Entity
{
    /// <summary>
    /// 操作结果实体类
    /// </summary>
    public class ResultEntity
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回结果代码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 返回结果文字信息
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// 带列表数据T和分页信息的结果实体类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultEntity<T> : ResultEntity
    {
        /// <summary>
        /// 数据列表
        /// /// </summary>
        public IList<T> Datas { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        public PagerInfo Pager { get; set; }
    }

    /// <summary>
    /// 分页信息实体类
    /// </summary>
    public class PagerInfo
    {
        /// <summary>
        /// 记录集合总条数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        public int Index { get; set; }
    }
}