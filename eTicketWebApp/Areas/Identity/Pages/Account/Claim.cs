// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace eTicketWebApp.Areas.Identity.Pages.Account
{
    internal class Claim
    {
        private string v1;
        private string v2;

        public Claim(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}