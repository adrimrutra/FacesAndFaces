namespace Messaging.InterfacesConstants.Constants
{
    public static class RabbitMqMassTransitConstants
    {
        public const string RabbitMquri = "rabbitmq://rabbitmq:15672/";
        //public const string RabbitMquri = "rabbitmq://localhost/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterOrderCommandQueue = "register.order.command";
    }
}
