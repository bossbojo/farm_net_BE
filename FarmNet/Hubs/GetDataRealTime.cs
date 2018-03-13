using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FarmNet.Respositories;
using FarmNet.Models;
namespace FarmNet.Hubs
{
    public class GetDataRealTime : Hub
    {
        private R_Users_online _Users_Online = new R_Users_online();
        public void OnUserConnect(int user_id, string serial_number)
        {
            var connection_id = Context.ConnectionId;
            m_User_online modal = new m_User_online
            {
                user_id = user_id,
                connection_id = connection_id,
                serial_number = serial_number
            };

            if (_Users_Online.getUserById(user_id))
            {
                var res = _Users_Online.UserUpdate(modal);
                if (res != null)
                {
                    Clients.Client(connection_id).OnUserConnect("conneted....");
                }
                else
                {
                    Clients.Client(connection_id).OnUserConnect("failed connection.");
                }
            }
            else
            {
                var res = _Users_Online.UserCreate(modal);
                if (res != null)
                {
                    Clients.Client(connection_id).OnUserConnect("conneted....");
                }
                else
                {
                    Clients.Client(connection_id).OnUserConnect("failed connection.");
                }
            }

        }
        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var connection_id = Context.ConnectionId;
            _Users_Online.UserRemove(connection_id);
            return base.OnDisconnected(stopCalled);
        }
    }
}