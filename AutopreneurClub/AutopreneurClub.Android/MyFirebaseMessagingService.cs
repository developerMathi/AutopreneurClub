﻿
using Android.App;
using Android.Content;
using Firebase.Messaging;

namespace AutopreneurClub.Droid
{
    [Service(Exported = false)]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        public MyFirebaseMessagingService()
        {

        }
        public override void OnMessageReceived(RemoteMessage message)
        {
            base.OnMessageReceived(message);
            //new NotificationHelper().CreateNotification(message.GetNotification().Title, message.GetNotification().Body, null, null);
        }
    }
}