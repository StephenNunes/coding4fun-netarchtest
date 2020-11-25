using System;
using MyAwesomeApplication.BusinessObjectLayer;

namespace MyAwesomeApplication.BusinessLayer
{
    public class CakeFactory
    {
        public CakeDto CreateCakeDto()
        {
            return new CakeDto();
        }
    }
}
