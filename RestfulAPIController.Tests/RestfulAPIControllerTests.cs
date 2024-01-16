using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace RestfulAPIController.Tests
{
    public class RestfulAPIControllerTests
    {
        /// <summary>
        /// Arrange�G ���ժ��󪺪�l�ơB�w�q�ݭn�ϥΪ��ѼƸ�T
        /// Act�G �I�s�Q���ժ���k
        /// Assert�G ���ҵ��G
        /// </summary>

        #region GET ���o�������

        // GET
        // ���o�������
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

        #region GET ���o�@�����

        // GET
        // ���o�@�����
        [Fact]
        public void GetOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // ���ե�Index
            int testIndex = 1;
            // Act
            var result = controller.Get(testIndex);

            // Assert
            var actionResult = Assert.IsType<ActionResult<string>>(result);
            var model = Assert.IsType<string>(actionResult.Value);

            Assert.Equal("API", model);
        }

        #endregion

        #region POST �s�W�@�����

        // POST
        // �N�@���s���r��s�W��List
        [Fact]
        public void PostOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // ���եθ��
            string testText = "�椸���եθ��";
            // Act
            var result = controller.Post(testText);

            // Assert
            var actionResult = Assert.IsType<ActionResult<List<string>>>(result);
            var model = Assert.IsType<List<string>>(actionResult.Value);

            Assert.Equal(4, model.Count);
        }

        #endregion

        #region PUT ��s�@�����

        // PUT
        // ��s�@�����
        [Fact]
        public void PutOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // ���եί��޻P���
            int index = 2;
            string testText = "�椸���եθ��";
            // Act
            var result = controller.Put(index, testText);

            // Assert
            var actionResult = Assert.IsType<ActionResult<List<string>>>(result);
            var model = Assert.IsType<List<string>>(actionResult.Value);

            Assert.Equal(testText, model[2]);
        }

        #endregion

        #region DELETE �R���@�����

        // DELETE
        // �R���@�����
        [Fact]
        public void DeleteOneData()
        {
            // Arrange
            var controller = new MyRestfulAPIWithoutSQL.Controllers.RestfulAPIController();

            // ���եί���
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