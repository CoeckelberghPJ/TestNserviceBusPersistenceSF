using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Service
{
    public class TestSaga2 : Saga<TestData2>
    {
        protected override void ConfigureHowToFindSaga(SagaPropertyMapper<TestData2> mapper)
        {
            throw new NotImplementedException();
        }
    }
}
