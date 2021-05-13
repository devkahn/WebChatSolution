using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChatSolution.Hubs
{
    public class MoveShapeHub : Hub
    {

        public void UpdateModel(ShapeModel clientModel)
        {
            clientModel.LastUpdateBy = Context.ConnectionId;
            Clients.AllExcept(clientModel.LastUpdateBy).updateShape(clientModel);
        }
    }


    public class ShapeModel
    {
        [JsonProperty("left")]
        public double Left { get; set; }
        [JsonProperty("top")]
        public double Top { get; set; }
        [JsonIgnore]
        public string LastUpdateBy { get; set; }
    }
}