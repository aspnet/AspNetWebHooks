using System;
using Microsoft.AspNet.WebHooks;
using Microsoft.AspNet.WebHooks.Payloads;
using Newtonsoft.Json.Linq;

namespace PusherReceiver.WebHooks
{
    public class PusherWebHookHandler : PusherWebHookHandlerBase
    {
        public override void ChannelOccupied(WebHookHandlerContext context, ChannelOccupiedPayload payload)
        {
            context.RequestContext.Configuration.DependencyResolver.GetLogger().Info($"Channel {payload.Channel} is occupied");
        }

        public override void ChannelVacated(WebHookHandlerContext context, ChannelVacatedPayload payload)
        {
            context.RequestContext.Configuration.DependencyResolver.GetLogger().Info($"Channel {payload.Channel} is vacated");
        }

        public override void MemberAdded(WebHookHandlerContext context, MemberAddedPayload payload)
        {
            context.RequestContext.Configuration.DependencyResolver.GetLogger().Info($"Member {payload.UserId} added to channel {payload.Channel}");
        }

        public override void MemberRemoved(WebHookHandlerContext context, MemberRemovedPayload payload)
        {
            context.RequestContext.Configuration.DependencyResolver.GetLogger().Info($"Member {payload.UserId} removed from channel {payload.Channel}");
        }

        public override void ClientEvent(WebHookHandlerContext context, ClientEventPayload payload)
        {
            context.RequestContext.Configuration.DependencyResolver.GetLogger().Info($"Client event");
        }

        public override void UnknownEvent(WebHookHandlerContext context, JObject payload)
        {
            context.RequestContext.Configuration.DependencyResolver.GetLogger().Info($"Unknown event");
        }


        public static DateTime UnixTimeStampToDateTime(double millisecondsTimeStamp)
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(millisecondsTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}
