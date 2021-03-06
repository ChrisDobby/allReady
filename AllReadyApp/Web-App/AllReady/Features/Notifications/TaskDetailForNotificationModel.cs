﻿using System;
using System.Collections.Generic;
using AllReady.Models;

namespace AllReady.Features.Notifications
{
    public class TaskDetailForNotificationModel
    {
        public int EventId { get; set; }
        public string CampaignName { get; set; }
        public string EventName { get; set; }
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int NumberOfVolunteersRequired { get; set; }
        public List<CampaignContact> CampaignContacts { get; set; }
        public EventType EventType { get; set; }
        public ApplicationUser Volunteer { get; set; }
        public int NumberOfVolunteersSignedUp { get; set; }
        public DateTimeOffset TaskStartDate { get; set; }
    }
}