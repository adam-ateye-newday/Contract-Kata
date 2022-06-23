namespace DatePeriods
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var contract1 = new Contract(2,4);
            var contract2 = new Contract(3,5);
            var contract3 = new Contract(8,10);
            var contract4 = new Contract(1,11);
            var contractDB = new ContractDB(contract1, contract2, contract3, contract4);
            var searchPeriod = new Period(1,6);

            //Act
            var result = contractDB.Search(searchPeriod);

            //Assert
            result.Should().Be(3);
        }
        //Gherkin (Given, When, Then)
        //Given the contractDB Has contracts [2,4] [3,5]
        //When i search the DB with values [1,2]
        //then search returns 1contract [2,4]
    }
}