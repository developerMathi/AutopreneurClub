using System;
using System.Collections.Generic;
using System.Text;

namespace AutopreneurClub
{
    public interface INotification
    {
        void CreateNotification(String title, String message,string pageName,string data);
    }
}

