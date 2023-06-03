﻿using OnlineChatV2.Domain;
using OnlineChatV2.WebApi.Models;

namespace OnlineChatV2.WebApi.Services.Base;

public interface IChatService
{
    ChatType GetChatType(long chatId);
    
    Task<bool> IsUserInChat(long userId, long chatId);
    
    Task<bool> IsChatExist(long chatId);
    Task<CreateChatResult> CreateChat(CreateChatModel model);

    Task<ChatModel[]> GetUserChats(long userId);

    Task<ChatHistoryModel[]> GetChat(long userId, long chatId);

    Task<ChatHistoryModel> SaveMessage(User user, MessageDto message);
}