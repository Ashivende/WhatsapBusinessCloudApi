using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

namespace WhatsapBusinessCloudApi.Code
{
    public static class WhatsAppSender
    {
        public static void SendMessage()
        {
            string Url = "https://graph.facebook.com/v13.0/104713102379961/messages ";
            Uri baseUrl = new Uri(Url);
            IRestClient client = new IRestClient(baseUrl);
            IRestRequest request = new IRestRequest("messages", Method.Post);

            request.AddHeader("Authorization", "Bearer" + Keys.Token);
            request.AddHeader("Content-Type", "application/json");
            Language lanObj = new Language();
            lanObj.Code = "en_US";

            List<Models.Parameter> parameterlist = new List<Models.Parameter>();
            Parameterlist.Add(NewsStyleUriParser Model.Prameter

                {
                  type = "text",
                  text = "Jaswinder"
                }
        }
      

    }
}

curl - i - X POST \
  https://graph.facebook.com/v14.0/FROM_PHONE_NUMBER_ID/messages \
-H 'Authorization: Bearer ACCESS_TOKEN' \
  -H 'Content-Type: application/json' \
  -d '{ "messaging_product": "whatsapp", "to": "TO_PHONE_NUMBER", "type": "template", "template": { "name": "hello_world", "language": { "code": "en_US" } } }'

