namespace Messaging.InterfacesConstants.Constants
{
    public static class RabbitMqMassTransitConstants
    {
        public const string RabbitMquri = "rabbitmq://rabbitmq:15672/";
        //public const string RabbitMquri = "rabbitmq://localhost/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterOrderCommandQueue = "register.order.command";

        public const string NotificationServiceQueue = "notification.service.queue";

        public const string OrderDispatchedServiceQueue = "order.dispatched.service.queue";

    }
}
