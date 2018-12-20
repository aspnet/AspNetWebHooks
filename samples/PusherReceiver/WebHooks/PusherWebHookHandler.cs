using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;

namespace PusherReceiver.WebHooks
{
    public class PusherWebHookHandler : WebHookHandler
    {
        public PusherWebHookHandler()
        {
            this.Receiver = PusherWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            var data = context.GetDataOrDefault<PusherNotifications>();

            var createdAtUnix = data.CreatedAt;
            var createdAt = UnixTimeStampToDateTime(createdAtUnix);

            var index = 0;
            foreach (var @event in data.Events)
            {
                if (@event.TryGetValue(PusherConstants.EventNamePropertyName, out var eventName))
                {
                    if (@event.TryGetValue(PusherConstants.ChannelNamePropertyName, out var channelName))
                    {
                        if (@event.TryGetValue(PusherConstants.UserIdPropertyName, out var userId))
                        {
                            Debug.WriteLine($"Event {index} has {@event.Count} properties, including name '{eventName}' and channel '{channelName}' for user '{userId}'.");
                        }
                        else
                        {
                            Debug.WriteLine($"Event {index} has {@event.Count} properties, including name '{eventName}' and channel '{channelName}'.");
                        }
                    }
                    else
                    {
                        Debug.WriteLine($"Event {index} has {@event.Count} properties, including name '{eventName}'.");
                    }
                }
                else
                {
                    Debug.WriteLine($"Event {index} has {@event.Count} properties but does not contain a {PusherConstants.EventNamePropertyName} property.");
                }

                index++;
            }

            return Task.FromResult(true);
        }

        public static DateTime UnixTimeStampToDateTime(double millisecondsTimeStamp)
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(millisecondsTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}
