namespace Xunku.DIS.Common.Utility
{
    /// <summary>
    /// 数据工具类
    /// 用于数据格式之间的转换
    /// </summary>
    public static class DataUtility
    {
        /// <summary>
        /// 布尔值转换
        /// </summary>
        /// <param name="input"></param>
        /// <param name="defaultValue">转换失败后的默认返回值</param>
        /// <returns></returns>
        public static bool? GetBool(string input, bool? defaultValue = null)
        {
            bool ret;

            if (!bool.TryParse(input, out ret))
            {
                return defaultValue;
            }

            return ret;
        }

        /// <summary>
        /// 有符号整数转换
        /// </summary>
        /// <param name="input"></param>
        /// <param name="defaultValue">转换失败后的默认返回值</param>
        /// <returns></returns>
        public static int? GetInt(string input, int? defaultValue = null)
        {
            int ret;

            if (!int.TryParse(input, out ret))
            {
                return defaultValue;
            }

            return ret;
        }

        /// <summary>
        /// 双精度浮点数转换
        /// </summary>
        /// <param name="input"></param>
        /// <param name="defaultValue">转换失败后的默认返回值</param>
        /// <returns></returns>
        public static double? GetDouble(string input, double? defaultValue = null)
        {
            double ret;

            if (!double.TryParse(input, out ret))
            {
                return defaultValue;
            }

            return ret;
        }
    }
}