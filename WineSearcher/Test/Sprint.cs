using WineSearcher.Global;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineSearcher.Pages;
using Keys.Pages;

namespace WineSearcher.Test
{
    class Sprint 
    {
      [TestFixture]
      
       class Tenant :Base
       {
        
            

            [Test]

            public void WineSearch()
            {
                test = extent.StartTest(" user can search the product successfully");
                WineSearch obj = new WineSearch();
                obj.SearchingProduct();

            }
            [Test]

            public void Signup()
            {
                test = extent.StartTest(" ");
                Signup obj = new Signup();
                obj.SignUp();

            }

            


    }
    }
}
