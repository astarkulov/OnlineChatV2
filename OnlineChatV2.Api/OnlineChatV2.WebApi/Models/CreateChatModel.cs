﻿namespace OnlineChatV2.WebApi.Models;

public class CreateChatModel
{
    public long CreatedById { get; set; }
    public long[] ChatUserIds { get; set; }
    public string ChatName { get; set; }
}