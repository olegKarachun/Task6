using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Task6
{
    public class UpdateHub : Hub
    {   public async Task CreateNew(string noteId, string posX, string posY, int height, int width, string color)
        {
            await Clients.Others.SendAsync("CreateNew", noteId, posX, posY, height, width, color);            
        }

        public async Task ChangeNote(string noteId, string posX, string posY, int height, int width, string color, string content)
        {
            await Clients.Others.SendAsync("ChangeNote", noteId, posX, posY, height, width, color, content);     
        }

        public async Task DeleteNote(string id)
        {            
            await Clients.Others.SendAsync("DeleteNote", id);
        }

        public async Task CheckOnActive()
        {
            await Clients.Others.SendAsync("CheckOnActive");
        }
    }
}
