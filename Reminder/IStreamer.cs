﻿namespace Reminder_desktop_application
{
    public interface IStreamer<TKey, TValue>
    {
        TKey[] GetData();
    }
}
