using AppDll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorPlugin
{

    public class TranslatedText
    {
        public int code { get; set; }
        public string lang { get; set; }
        public IList<string> text { get; set; }
    }

    public class Translator : IPlugin
    {
        public string Request(string input)
        {
            using (var client = new WebClient{Encoding = Encoding.UTF8 })
            {
                try
                {
                    var query = $@"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180219T084352Z.2dfc43425627c1f3.37a9001368452dec80ea343380fbd5ca94097afa&text={input}&lang=en-ru";
                    var answer = client.DownloadString(query);
                    var output = JsonConvert.DeserializeObject<TranslatedText>(answer);
                    answer = null;
                    foreach (var item in output.text)
                    {
                        answer += item;
                    }
                    return answer;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public override string ToString()
        {
            return "Translator Plugin";
        }
    }
}
