using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace RestfulAPIController.Tests
{
    public class RestfulAPIControllerTests
    {
        /// <summary>
        /// Arrange： 測試物件的初始化、定義需要使用的參數資訊
        /// Act： 呼叫被測試的方法
        /// Assert： 驗證結果
        /// </summary>

        #region GET 取得全部資料

        // GET
        // 取得全部資料
        [Fact]
        public void GetAllData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // Act
            var result = controller.Get();

            // Assert
            var actionResult = Assert.IsType<ActionResult<List<string>>>(result);
            var model = Assert.IsType<List<string>>(actionResult.Value);

            Assert.Equal(4, model.Count);
        }

        #endregion

        #region GET 取得一筆資料

        // GET
        // 取得一筆資料
        [Fact]
        public void GetOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // 測試用Index
            int testIndex = 1;
            // Act
            var result = controller.Get(testIndex);

            // Assert
            var actionResult = Assert.IsType<ActionResult<string>>(result);
            var model = Assert.IsType<string>(actionResult.Value);

            Assert.Equal("API", model);
        }

        #endregion

        #region POST 新增一筆資料

        // POST
        // 將一筆新的字串新增到List
        [Fact]
        public void PostOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // 測試用資料
            string testText = "單元測試用資料";
            // Act
            var result = controller.Post(testText);

            // Assert
            var actionResult = Assert.IsType<ActionResult<List<string>>>(result);
            var model = Assert.IsType<List<string>>(actionResult.Value);

            Assert.Equal(4, model.Count);
        }

        #endregion

        #region PUT 更新一筆資料

        // PUT
        // 更新一筆資料
        [Fact]
        public void PutOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // 測試用索引與資料
            int index = 2;
            string testText = "單元測試用資料";
            // Act
            var result = controller.Put(index, testText);

            // Assert
            var actionResult = Assert.IsType<ActionResult<List<string>>>(result);
            var model = Assert.IsType<List<string>>(actionResult.Value);

            Assert.Equal(testText, model[2]);
        }

        #endregion

        #region DELETE 刪除一筆資料

        // DELETE
        // 刪除一筆資料
        [Fact]
        public void DeleteOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // 測試用索引
            int index = 0;
            // Act
            var result = controller.Delete(index);

            // Assert
            var actionResult = Assert.IsType<ActionResult<List<string>>>(result);
            var model = Assert.IsType<List<string>>(actionResult.Value);

            Assert.Equal(3, model.Count);
        }
        #endregion
    }
}