using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice_VK.Handlers
{
    public static class Extensions
    {
        public static AliceResponse Reply(this AliceRequest req, string text, bool endSession = false, 
            ButtonModel[] buttons = null) => new AliceResponse
        {
            Response = new ResponseModel
            {
                Text = text,
                Tts = text,
                EndSession = endSession
            },
            Session = req.Session
        };
    }
}
