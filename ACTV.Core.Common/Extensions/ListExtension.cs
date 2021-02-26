using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTV.Core.Common.Extensions
{
    public static class ListExtension
    {
        /// <summary>
        /// 实现泛型集合到数组对象转换的静态扩展方法
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="lines">泛型集合</param>
        /// <param name="lambdas">需要转换的泛型对象属性</param>
        /// <returns>数据对象</returns>
        public static object[,] To2DArray<T>(this List<T> lines, params Func<T, object>[] lambdas)
        {
            var array = new object[lines.Count(), lambdas.Count()];
            var lineCounter = 0;
            lines.ForEach(line =>
            {
                for (var i = 0; i < lambdas.Length; i++)
                {
                    array[lineCounter, i] = lambdas[i](line);
                }
                lineCounter++;
            });

            return array;
        }
    }
}
