using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketData
{
    public class HttpContextUnitOfWork
    {
        public HttpContextUnitOfWork(ApplicationDbContext context, IHttpContextAccessor httpAccessor) { 
        
                context.CurrentUserId = httpAccessor.HttpContext.User?.FindFirst("Subject")?.Value?.Trim();
        }
    }
}
