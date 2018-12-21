using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks.Payloads;
using Newtonsoft.Json.Linq;

namespace Microsoft.AspNet.WebHooks
{
    /// <summary>
    /// Provides a base <see cref="IWebHookHandler" /> implementation which can be used to for handling Pusher WebHook using strongly-typed
    /// payloads. For details about Pusher WebHooks, see <c>https://pusher.com/docs/webhooks</c>.
    /// </summary>
    public class PusherWebHookHandlerBase : WebHookHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PusherWebHookHandlerBase"/> class.
        /// </summary>
        protected PusherWebHookHandlerBase()
        {
            Receiver = PusherWebHookReceiver.ReceiverName;
        }

        /// <inheritdoc />
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var data = context.GetDataOrDefault<JObject>();
            //check if data is available
            if (data == null)
            {
                var message = "The WebHook request must contain a valid JSON payload.";
                context.RequestContext.Configuration.DependencyResolver.GetLogger().Error(message);
                context.Response = context.Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
                return Task.FromResult(true);
            }

            //the unix timestamp in milliseconds when the webhook was created. This allows detecting delayed webhooks if necessary.
            var createdAt = data.Value<long?>(PusherConstants.EventRequestCreatedAtPropertyName);
            if (!createdAt.HasValue)
            {
                var message = string.Format(CultureInfo.CurrentCulture, "The WebHook request must contain a '{0}' JSON property containing the unix timestamp in milliseconds when the webhook was created.", PusherConstants.EventRequestCreatedAtPropertyName);
                context.RequestContext.Configuration.DependencyResolver.GetLogger().Error(message);
                context.Response = context.Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
                return Task.FromResult(true);
            }

            var events = data.Value<JArray>(PusherConstants.EventRequestPropertyContainerName);
            //check if data has events property
            if (events == null)
            {
                var message = string.Format(CultureInfo.CurrentCulture, "The WebHook request must contain a '{0}' JSON property containing the events payload.", PusherConstants.EventRequestPropertyContainerName);
                context.RequestContext.Configuration.DependencyResolver.GetLogger().Error(message);
                context.Response = context.Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
                return Task.FromResult(true);
            }

            //iterate over events, needed for batch events support, see https://blog.pusher.com/batch-webhooks/
            foreach (JObject @event in events)
            {
                var eventName = @event.Value<string>(PusherConstants.EventNamePropertyName);

                switch (eventName)
                {
                    case "channel_occupied":
                        var channelOccupiedPayload = @event.ToObject<ChannelOccupiedPayload>();
                        channelOccupiedPayload.CreatedAt = createdAt.Value;
                        ChannelOccupied(context, channelOccupiedPayload);
                        break;
                    case "channel_vacated":
                        var channelVacatedPayload = @event.ToObject<ChannelVacatedPayload>();
                        channelVacatedPayload.CreatedAt = createdAt.Value;
                        ChannelVacated(context, channelVacatedPayload);
                        break;
                    case "member_added":
                        var memberAddedPayload = @event.ToObject<MemberAddedPayload>();
                        memberAddedPayload.CreatedAt = createdAt.Value;
                        MemberAdded(context, memberAddedPayload);
                        break;
                    case "member_removed":
                        var memberRemovedPayload = @event.ToObject<MemberRemovedPayload>();
                        memberRemovedPayload.CreatedAt = createdAt.Value;
                        MemberRemoved(context, memberRemovedPayload);
                        break;
                    case "client_event":
                        var clientEventPayload = @event.ToObject<ClientEventPayload>();
                        clientEventPayload.CreatedAt = createdAt.Value;
                        ClientEvent(context, clientEventPayload);
                        break;
                    default:
                        var message = string.Format(CultureInfo.CurrentCulture, "The property 'name' contains unmapped value '{0}'.", eventName);
                        context.RequestContext.Configuration.DependencyResolver.GetLogger().Warn(message);
                        UnknownEvent(context, @event);
                        break;
                }
            }

            return Task.FromResult(true);
        }

        /// <summary>
        /// Executes the incoming WebHook request for event '<c>channel_occupied</c>'.
        /// </summary>
        /// <param name="context">Provides context for the <see cref="IWebHookHandler"/> for further processing the incoming WebHook.</param>
        /// <param name="payload">Strong-typed WebHook payload.</param>
        public virtual void ChannelOccupied(WebHookHandlerContext context, ChannelOccupiedPayload payload)
        {
        }


        /// <summary>
        /// Executes the incoming WebHook request for event '<c>channel_vacated</c>'.
        /// </summary>
        /// <param name="context">Provides context for the <see cref="IWebHookHandler"/> for further processing the incoming WebHook.</param>
        /// <param name="payload">Strong-typed WebHook payload.</param>
        public virtual void ChannelVacated(WebHookHandlerContext context, ChannelVacatedPayload payload)
        {
        }

        /// <summary>
        /// Executes the incoming WebHook request for event '<c>member_added</c>'.
        /// </summary>
        /// <param name="context">Provides context for the <see cref="IWebHookHandler"/> for further processing the incoming WebHook.</param>
        /// <param name="payload">Strong-typed WebHook payload.</param>
        public virtual void MemberAdded(WebHookHandlerContext context, MemberAddedPayload payload)
        {
        }


        /// <summary>
        /// Executes the incoming WebHook request for event '<c>member_removed</c>'.
        /// </summary>
        /// <param name="context">Provides context for the <see cref="IWebHookHandler"/> for further processing the incoming WebHook.</param>
        /// <param name="payload">Strong-typed WebHook payload.</param>
        public virtual void MemberRemoved(WebHookHandlerContext context, MemberRemovedPayload payload)
        {
        }


        /// <summary>
        /// Executes the incoming WebHook request for event '<c>client_event</c>'.
        /// </summary>
        /// <param name="context">Provides context for the <see cref="IWebHookHandler"/> for further processing the incoming WebHook.</param>
        /// <param name="payload">Strong-typed WebHook payload.</param>
        public virtual void ClientEvent(WebHookHandlerContext context, ClientEventPayload payload)
        {
        }

        /// <summary>
        /// Executes the incoming WebHook request for unknown event.
        /// </summary>
        /// <param name="context">Provides context for the <see cref="IWebHookHandler"/> for further processing the incoming WebHook.</param>
        /// <param name="payload">JSON payload.</param>
        public virtual void UnknownEvent(WebHookHandlerContext context, JObject payload)
        {
        }
    }
}
