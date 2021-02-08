using ACTV.Core.Common.Helper;
using ACTV.Core.EventBus.EventHandling;
using ACTV.Core.IServices;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ACTV.Core.EventBus
{
    public class BlogDeletedIntegrationEventHandler : IIntegrationEventHandler<BlogDeletedIntegrationEvent>
    {
        private readonly IBlogArticleServices _blogArticleServices;
        private readonly ILogger<BlogDeletedIntegrationEventHandler> _logger;

        public BlogDeletedIntegrationEventHandler(
            IBlogArticleServices blogArticleServices,
            ILogger<BlogDeletedIntegrationEventHandler> logger)
        {
            _blogArticleServices = blogArticleServices;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Handle(BlogDeletedIntegrationEvent @event)
        {
            _logger.LogInformation("----- Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})", @event.Id, "ACTV.Core", @event);

            ConsoleHelper.WriteSuccessLine($"----- Handling integration event: {@event.Id} at ACTV.Core - ({@event})");

            await _blogArticleServices.DeleteById(@event.BlogId.ToString());
        }

    }
}
