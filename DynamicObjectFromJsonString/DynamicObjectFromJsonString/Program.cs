using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Text.Json;

namespace DynamicObjectFromJsonString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://code-maze.com/csharp-deserialize-json-into-dynamic-object/

            string jsonStringFull = "{\"Type\": \"Notification\", \"MessageId\": \"d9a5ec79-ffa4-4da4-8c9c-e8a4cd7a39a9\", \"TopicArn\": \"arn:aws:sns:us-east-1:000000000000:hxp-audit-events-topic\", \"Message\": \"{\\\"specversion\\\":\\\"1.0\\\",\\\"id\\\":\\\"e1b1808b-c8f1-4943-98c2-cd505c4d432e\\\",\\\"type\\\":\\\"hxp:audit:event:v1\\\",\\\"source\\\":\\\"hxp:client:audit\\\",\\\"time\\\":\\\"2022-10-10T07:10:58.2291726Z\\\",\\\"data\\\":{\\\"appKey\\\":\\\"hxc\\\",\\\"context\\\":{\\\"id\\\":\\\"STORAGEINTEGRATIONTEST\\\",\\\"type\\\":\\\"environment\\\"},\\\"actor\\\":\\\"hxc.file.uploaded\\\",\\\"type\\\":\\\"hxc.file.uploaded\\\",\\\"subject\\\":{\\\"id\\\":\\\"94e3c3d6-ff63-47dc-b8e4-e7c8a59e57e7\\\",\\\"scope\\\":\\\"file\\\"},\\\"date\\\":\\\"2022-10-10T07:10:58.2190398Z\\\",\\\"message\\\":{\\\"general\\\":{\\\"description\\\":\\\"Uploaded file.\\\",\\\"duration\\\":7318.6465,\\\"serviceId\\\":\\\"ms_storage\\\",\\\"connectionId\\\":\\\"0HMLAHQ8AJITF\\\",\\\"type\\\":\\\"production\\\"},\\\"change\\\":[{\\\"field\\\":\\\"name\\\",\\\"value\\\":\\\"8050cc6e-ab03-468a-91e0-5bf486259e3d.txt\\\"},{\\\"field\\\":\\\"size\\\",\\\"value\\\":36},{\\\"field\\\":\\\"version\\\",\\\"value\\\":\\\"ORIGINAL\\\"},{\\\"field\\\":\\\"contentType\\\",\\\"value\\\":\\\"text/plain\\\"}]},\\\"traceId\\\":\\\"599cb9139872e5e0babe59ae4aa9f9d7\\\"}}\", \"Timestamp\": \"2022-10-10T07:11:00.451Z\", \"SignatureVersion\": \"1\", \"Signature\": \"EXAMPLEpH+..\", \"SigningCertURL\": \"https://sns.us-east-1.amazonaws.com/SimpleNotificationService-0000000000000000000000.pem\", \"MessageAttributes\": {\"content-type\": {\"Type\": \"String\", \"Value\": \"application/cloudevents+json; charset=utf-8\"}}}";
            //string jsonMessage = "{\"specversion\":\"1.0\",\"id\":\"e1b1808b-c8f1-4943-98c2-cd505c4d432e\",\"type\":\"hxp:audit:event:v1\",\"source\":\"hxp:client:audit\",\"time\":\"2022-10-10T07:10:58.2291726Z\",\"data\":{\"appKey\":\"hxc\",\"context\":{\"id\":\"STORAGEINTEGRATIONTEST\",\"type\":\"environment\"},\"actor\":\"hxc.file.uploaded\",\"type\":\"hxc.file.uploaded\",\"subject\":{\"id\":\"94e3c3d6-ff63-47dc-b8e4-e7c8a59e57e7\",\"scope\":\"file\"},\"date\":\"2022-10-10T07:10:58.2190398Z\",\"message\":{\"general\":{\"description\":\"Uploaded file.\",\"duration\":7318.6465,\"serviceId\":\"ms_storage\",\"connectionId\":\"0HMLAHQ8AJITF\",\"type\":\"production\"},\"change\":[{\"field\":\"name\",\"value\":\"8050cc6e-ab03-468a-91e0-5bf486259e3d.txt\"},{\"field\":\"size\",\"value\":36},{\"field\":\"version\",\"value\":\"ORIGINAL\"},{\"field\":\"contentType\",\"value\":\"text/plain\"}]},\"traceId\":\"599cb9139872e5e0babe59ae4aa9f9d7\"}}";
            //string jsonData = "{\"appKey\":\"hxc\",\"context\":{\"id\":\"STORAGEINTEGRATIONTEST\",\"type\":\"environment\"},\r\n\t\t\"actor\":\"hxc.file.uploaded\",\"type\":\"hxc.file.uploaded\",\r\n\t\t\"subject\":{\"id\":\"94e3c3d6-ff63-47dc-b8e4-e7c8a59e57e7\",\"scope\":\"file\"},\r\n\t\t\"date\":\"2022-10-10T07:10:58.2190398Z\",\r\n\t\t\"message\":{\r\n\t\t\t\"general\":{\"description\":\"Uploaded file.\",\"duration\":7318.6465,\"serviceId\":\"ms_storage\",\"connectionId\":\"0HMLAHQ8AJITF\",\"type\":\"production\"},\r\n\t\t\t\"change\":[{\"field\":\"name\",\"value\":\"8050cc6e-ab03-468a-91e0-5bf486259e3d.txt\"},{\"field\":\"size\",\"value\":36},\r\n\t\t\t{\"field\":\"version\",\"value\":\"ORIGINAL\"},{\"field\":\"contentType\",\"value\":\"text/plain\"}]},\"traceId\":\"599cb9139872e5e0babe59ae4aa9f9d7\"}";

            //JsonElement jsonElement = JsonSerializer.Deserialize<JsonElement>(jsonData);

            dynamic d1 = System.Text.Json.JsonSerializer.Deserialize<dynamic>(jsonStringFull, new JsonSerializerOptions()
            {
                MaxDepth = 5
            });


            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonStringFull);
            //Console.WriteLine(dynamicObject.Message.data);
            var dynamicObject1 = JsonConvert.DeserializeObject<dynamic>(dynamicObject.Message.ToString());
            Console.WriteLine(dynamicObject1.data.message.general.description);

            string keyValueJson = "{\"username\":\"aaaaaaaaa\"}";
            JsonElement jsonElementKeyValueJson = System.Text.Json.JsonSerializer.Deserialize<dynamic>(keyValueJson, new JsonSerializerOptions()
            {
                MaxDepth = 1
            });

            string userNameValue = jsonElementKeyValueJson.GetProperty("username").ToString();
            Console.WriteLine(userNameValue);

            Console.WriteLine("END");

        }
    }
}
