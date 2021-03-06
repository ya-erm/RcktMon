﻿namespace CoreData.Interfaces
{
    public interface INgineSettings
    {
        string TiApiKey { get; set; }
        string TgBotApiKey { get; set; }
        string TgChatId { get; set; }
        string TgChatIdRu { get; set; }
        decimal MinDayPriceChange { get; set; }
        decimal MinTenMinutesPriceChange { get; set; }
        decimal MinVolumeDeviationFromDailyAverage { get; set; }
        decimal MinTenMinutesVolPercentChange { get; set; }
        bool IsTelegramEnabled { get; set; }
        bool CheckRockets { get; set; }
        
        bool USAQuotesEnabled { get; set; }
        string USAQuotesURL { get; set; }
        string USAQuotesLogin { get; set; }
        string USAQuotesPassword { get; set; }
        string TgArbitrageLongUSAChatId { get; set; }
        string TgArbitrageShortUSAChatId { get; set; }
    }

    public interface ISettingsProvider
    {
        INgineSettings Settings { get; }
        INgineSettings ReadSettings();
        void SaveSettings(INgineSettings settings);
    }
}
