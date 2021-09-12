using CreatorDemo.Builders.Base.Interfaces;
using System;
using System.Linq;

namespace CreatorDemo.Builders.Base
{
    public abstract class NotificationHandler : INotificationHandler
    {
        public static EventHandler<string> ProductionEvent;

        private const string OPEN_EVENT_QUO = ">>>";
        private const string CLOSE_EVENT_QUO = "<<<";
        internal const string BUILD_STARTED = "BUILD STARTED";
        internal const string FACTORY_STARTED = "FACTORY STARTED";
        public const string ORDER_RECEIVED = "ORDER_RECEIVED";
        public const string PRODUCT_COMPLETE = "PRODUCT COMPLETE";

        public static string FormatEventMessage(string message, string description) 
            => $"{OPEN_EVENT_QUO} {message} {CLOSE_EVENT_QUO} : {description}";

        public static void Handler(object sender, string e)
        {
            Console.WriteLine($"{sender.GetType().Name} {DateTime.Now} : {e} : ");
        }
    }
}