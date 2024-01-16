using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyRestfulAPIWithoutSQL.Controllers
{
    /// <summary>
    /// 包含GET、POST、PUT、DELETE的API 
    /// </summary>
    
    [Route("[controller]")]
    [ApiController]
    public class RestfulAPIController : ControllerBase
    {
        #region 測試用List

        // 測試用List
        private static List<string> myAPIList = new List<string>
        {
            "Restful","API","Hello", "World"
        };

        #endregion

        #region GET 取得全部資料

        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <returns>List的全部資料</returns>

        // GET 取得全部資料
        [HttpGet(Name = "GetRestfulAPI")]

        public ActionResult<List<string>> Get()
        {
            return myAPIList;
        }

        #endregion

        #region GET 取得一筆資料

        /// <summary>
        /// 取得一筆資料
        /// </summary>
        /// <param name="index">要檢索的資料索引</param>
        /// <returns>根據索引回傳對應的單筆List資料</returns>

        // GET 取得一筆資料
        [HttpGet("{index}")]
        public ActionResult<string> Get(int index)
        {
            return myAPIList[index];
        }

        #endregion

        #region POST 新增一筆資料

        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="newText">要新增的資料名稱</param>
        /// <returns>新增資料後的List資料</returns>

        // POST 新增一筆資料
        [HttpPost]
        public ActionResult<List<string>> Post(string newText)
        {
            myAPIList.Add(newText);
            return myAPIList;
        }

        #endregion

        #region PUT 更新一筆資料

        /// <summary>
        /// 更新一筆資料
        /// </summary>
        /// <param name="index">要更新的資料索引</param>
        /// <param name="newText">修改後的名稱</param>
        /// <returns>更新後的資料List</returns>

        // PUT 更新一筆資料
        [HttpPut]
        public ActionResult<List<string>> Put(int index, string newText)
        {
            myAPIList[index] = newText;
            return myAPIList;
        }

        #endregion

        #region DELETE 刪除一筆資料

        /// <summary>
        /// 刪除一筆資料
        /// </summary>
        /// <param name="index">要刪除的資料索引</param>
        /// <returns>刪除後的List資料</returns>

        // DELETE 刪除一筆資料
        [HttpDelete]
        public ActionResult<List<string>> Delete(int index)
        {
            myAPIList.RemoveAt(index);
            return myAPIList;
        }

        #endregion
    }
}
