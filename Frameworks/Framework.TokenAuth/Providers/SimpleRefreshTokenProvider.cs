using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Framework.TokenAuth.Providers
{
    public class SimpleRefreshTokenProvider : IAuthenticationTokenProvider
    {

        public async Task CreateAsync(AuthenticationTokenCreateContext context)
        {
            var clientid = context.Ticket.Properties.Dictionary["as:client_id"];

            if (string.IsNullOrEmpty(clientid))
            {
                return;
            }

            var refreshTokenId = Guid.NewGuid().ToString("n");

            using (Framework.TokenAuth.AuthRepository _repo = new Framework.TokenAuth.AuthRepository())
            {
                var refreshTokenLifeTime = context.OwinContext.Get<string>("as:clientRefreshTokenLifeTime"); 
               
                var token = new Framework.TokenAuth.Entities.RefreshToken() 
                { 
                    Id = Helper.GetHash(refreshTokenId),
                    ClientId = clientid, 
                    Subject = context.Ticket.Identity.Name,
                    IssuedUtc = DateTime.UtcNow,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(Convert.ToDouble(refreshTokenLifeTime)) 
                };

                context.Ticket.Properties.IssuedUtc = token.IssuedUtc;
                context.Ticket.Properties.ExpiresUtc = token.ExpiresUtc;
                
                token.ProtectedTicket = context.SerializeTicket();

                var result = await _repo.AddRefreshToken(token);

                if (result)
                {
                    context.SetToken(refreshTokenId);
                }
             
            }
        }

        public async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {

            var allowedOrigin = context.OwinContext.Get<string>("as:clientAllowedOrigin");
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });

            string hashedTokenId = Helper.GetHash(context.Token);

            using (Framework.TokenAuth.AuthRepository _repo = new Framework.TokenAuth.AuthRepository())
            {
                var refreshToken = await _repo.FindRefreshToken(hashedTokenId);

                if (refreshToken != null )
                {
                    //Get protectedTicket from refreshToken class
                    context.DeserializeTicket(refreshToken.ProtectedTicket);
                    var result = await _repo.RemoveRefreshToken(hashedTokenId);
                }
            }
        }

        public void Create(AuthenticationTokenCreateContext context)
        {
            throw new NotImplementedException();
        }

        public void Receive(AuthenticationTokenReceiveContext context)
        {
            throw new NotImplementedException();
        }
    }
}

