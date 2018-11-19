using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Xunit;
using Services;

namespace Services.UnitTests.LoggerTests
{    
    public class LogShould
    {
        public string message = "This is test message.";
                
        public void Call_Log_with_message(string message)
        {
            //Console logger message
            IMessageLogger cl = new ConsoleLogger();
            cl.Log(message);

            //Queue logger message
            IMessageLogger ql = new QueueLogger();
            ql.Log(message);
            
        }
        
        /*[Fact]
        public void Call_Log_with_message()
        {
            throw new NotImplementedException();            
        }*/        
    }
}
