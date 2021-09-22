using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Azihub.Utilities.Base.JsonConverters
{
    public class MailAddressConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            MailAddress mailAddress = value as MailAddress;
            writer.WriteValue(mailAddress == null ? string.Empty : mailAddress.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string text = reader.Value as string;
            MailAddress mailAddress;

            return IsValidMailAddress(text, out mailAddress) ? mailAddress : null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(MailAddress);
        }

        private static bool IsValidMailAddress(string text, out MailAddress value)
        {
            try
            {
                value = new MailAddress(text);
                return true;
            }
            catch
            {
                value = null;
                return false;
            }
        }
    }
}
