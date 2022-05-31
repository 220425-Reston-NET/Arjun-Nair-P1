using Xunit;

namespace StoreTest
{

    public class CustomerModelTest
    {
        [Fact]
        public void InvID_Should_Set_ValidData()
        {
            Customer custObj = new Customer();
            int custId = 3;

            custObj.CustID = custId;

            Assert.NotNull(custObj.CustID);
            Assert.Equal(custId, custObj.CustID);

        }

        [Theory]
        [InlineData(-19)]
        [InlineData(-1290)]
        [InlineData(0)]
        [InlineData(-12983)]
        public void CustID_Should_Fail_Set_InvalidData(int c_custId)
        {

            Customer custObj = new Customer();

            Assert.Throw<System.ComponentModel.DataAnnotation,ValidationException>(() =>
                {
                    prodObj.ProdID = p_prodId;
                }
            );
        }
    }
}