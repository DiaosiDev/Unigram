﻿// --------------------------------------------------------------------------------------------------
// <auto-generatedInfo>
// 	This code was generated by TdParseOptions (http://github.com/UnigramDev/UnigramUtils/TdParseOptions)
// 
// 	Generated: 04/02/2020 10:54:06
// </auto-generatedInfo>
// --------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Td.Api;
using Unigram.ViewModels;

namespace Unigram.Services
{
    public interface IOptionsService : IHandle<UpdateOption>
    {
        IReadOnlyDictionary<string, OptionValue> Values { get; }

        T GetValue<T>(string key);
        bool TryGetValue<T>(string key, out T value);

        void Clear();



        /// <summary>
        /// TBD
        /// </summary>
        /// <value>storage_max_time_from_last_access</value>
        int StorageMaxTimeFromLastAccess { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>disable_pinned_message_notifications</value>
        bool DisablePinnedMessageNotifications { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>animated_dice_sticker_set_name</value>
        string AnimatedDiceStickerSetName { get; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>default_ton_blockchain_config</value>
        string DefaultTonBlockchainConfig { get; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>default_ton_blockchain_name</value>
        string DefaultTonBlockchainName { get; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>x_wallet_public_key</value>
        string WalletPublicKey { get; set; }

        /// <summary>
        /// If true, notifications about the user's contacts who have joined Telegram will be disabled. User will still receive the corresponding message in the private chat. getOption needs to be called explicitly to fetch the latest value of the option, changed from another device
        /// </summary>
        /// <value>disable_contact_registered_notifications</value>
        bool DisableContactRegisteredNotifications { get; set; }

        /// <summary>
        /// If true, support for top chats and statistics collection is disabled.
        /// </summary>
        /// <value>disable_top_chats</value>
        bool DisableTopChats { get; set; }

        /// <summary>
        /// If true, allows to skip all updates received while the TDLib instance was not running. The option does nothing if the database or secret chats are used
        /// </summary>
        /// <value>ignore_background_updates</value>
        bool IgnoreBackgroundUpdates { get; set; }

        /// <summary>
        /// If true, prevents file thumbnails sent by the server along with messages from being saved on the disk
        /// </summary>
        /// <value>ignore_inline_thumbnails</value>
        bool IgnoreInlineThumbnails { get; set; }

        /// <summary>
        /// If true, chat and message restrictions specific to the currently used operating system will be ignored
        /// </summary>
        /// <value>ignore_platform_restrictions</value>
        bool IgnorePlatformRestrictions { get; set; }

        /// <summary>
        /// If true, sensitive content will be shown on all user devices. getOption needs to be called explicitly to fetch the latest value of the option, changed from another device
        /// </summary>
        /// <value>ignore_sensitive_content_restrictions</value>
        bool IgnoreSensitiveContentRestrictions { get; set; }

        /// <summary>
        /// Path to a database for storing language pack strings, so that this database can be shared between different accounts. By default, language pack strings are stored only in memory.
        /// </summary>
        /// <value>language_pack_database_path</value>
        string LanguagePackDatabasePath { get; set; }

        /// <summary>
        /// Identifier of the currently used language pack from the current localization target
        /// </summary>
        /// <value>language_pack_id</value>
        string LanguagePackId { get; set; }

        /// <summary>
        /// Name for the current localization target (currently supported: "android", "android_x", "ios", "macos" and "tdesktop")
        /// </summary>
        /// <value>localization_target</value>
        string LocalizationTarget { get; set; }

        /// <summary>
        /// Maximum number of notification groups to be shown simultaneously, 0-25
        /// </summary>
        /// <value>notification_group_count_max</value>
        int NotificationGroupCountMax { get; set; }

        /// <summary>
        /// Maximum number of simultaneously shown notifications in a group, 1-25. Defaults to 10
        /// </summary>
        /// <value>notification_group_size_max</value>
        int NotificationGroupSizeMax { get; set; }

        /// <summary>
        /// Online status of the current user
        /// </summary>
        /// <value>online</value>
        bool Online { get; set; }

        /// <summary>
        /// If true, IPv6 addresses will be preferred over IPv4 addresses
        /// </summary>
        /// <value>prefer_ipv6</value>
        bool PreferIpv6 { get; set; }

        /// <summary>
        /// If true, Perfect Forward Secrecy will be enabled for interaction with the Telegram servers for cloud chats
        /// </summary>
        /// <value>use_pfs</value>
        bool UsePfs { get; set; }

        /// <summary>
        /// If true, quick acknowledgement will be enabled for outgoing messages
        /// </summary>
        /// <value>use_quick_ack</value>
        bool UseQuickAck { get; set; }

        /// <summary>
        /// If true, the background storage optimizer will be enabled
        /// </summary>
        /// <value>use_storage_optimizer</value>
        bool UseStorageOptimizer { get; set; }

        /// <summary>
        /// Name of a sticker set with animated emojis
        /// </summary>
        /// <value>animated_emoji_sticker_set_name</value>
        string AnimatedEmojiStickerSetName { get; }

        /// <summary>
        /// Username of a bot which can be used in inline mode for animations search
        /// </summary>
        /// <value>animation_search_bot_username</value>
        string AnimationSearchBotUsername { get; }

        /// <summary>
        /// Point in time (Unix timestamp) when authorization was received
        /// </summary>
        /// <value>authorization_date</value>
        int AuthorizationDate { get; }

        /// <summary>
        /// Maximum number of members in a basic group
        /// </summary>
        /// <value>basic_group_size_max</value>
        int BasicGroupSizeMax { get; }

        /// <summary>
        /// Maximum time to wait for call connection creation to be passed to libtgvoip
        /// </summary>
        /// <value>call_connect_timeout_ms</value>
        int CallConnectTimeoutMs { get; }

        /// <summary>
        /// Maximum time to wait for call packet delivery to be passed to libtgvoip
        /// </summary>
        /// <value>call_packet_timeout_ms</value>
        int CallPacketTimeoutMs { get; }

        /// <summary>
        /// If true, the option "ignore_sensitive_content_restrictions" can be changed
        /// </summary>
        /// <value>can_ignore_sensitive_content_restrictions</value>
        bool CanIgnoreSensitiveContentRestrictions { get; }

        /// <summary>
        /// Identifier of the enabled proxy
        /// </summary>
        /// <value>enabled_proxy_id</value>
        int EnabledProxyId { get; }

        /// <summary>
        /// If true, access to Telegram is likely blocked for the user
        /// </summary>
        /// <value>expect_blocking</value>
        bool ExpectBlocking { get; }

        /// <summary>
        /// Maximum number of favorite stickers
        /// </summary>
        /// <value>favorite_stickers_limit</value>
        int FavoriteStickersLimit { get; }

        /// <summary>
        /// Maximum number of forwarded messages per one request
        /// </summary>
        /// <value>forwarded_message_count_max</value>
        int ForwardedMessageCountMax { get; }

        /// <summary>
        /// Maximum length of a message caption
        /// </summary>
        /// <value>message_caption_length_max</value>
        int MessageCaptionLengthMax { get; }

        /// <summary>
        /// Maximum length of a message text
        /// </summary>
        /// <value>message_text_length_max</value>
        int MessageTextLengthMax { get; }

        /// <summary>
        /// Identifier of the current user
        /// </summary>
        /// <value>my_id</value>
        int MyId { get; }

        /// <summary>
        /// Maximum number of pinned cloud chats in the Archive chat list. The same amount of secret chats can be pinned locally
        /// </summary>
        /// <value>pinned_archived_chat_count_max</value>
        int PinnedArchivedChatCountMax { get; }

        /// <summary>
        /// Maximum number of pinned cloud chats in the Main chat list. The same amount of secret chats can be pinned locally
        /// </summary>
        /// <value>pinned_chat_count_max</value>
        int PinnedChatCountMax { get; }

        /// <summary>
        /// Username of a bot which can be used in inline mode for photos search
        /// </summary>
        /// <value>photo_search_bot_username</value>
        string PhotoSearchBotUsername { get; }

        /// <summary>
        /// Identifier of the language pack, suggested for the user by the server
        /// </summary>
        /// <value>suggested_language_pack_id</value>
        string SuggestedLanguagePackId { get; }

        /// <summary>
        /// Maximum number of members in a supergroup
        /// </summary>
        /// <value>supergroup_size_max</value>
        int SupergroupSizeMax { get; }

        /// <summary>
        /// Current value of t.me URL, i.e. https://t.me/
        /// </summary>
        /// <value>t_me_url</value>
        string TMeUrl { get; }

        /// <summary>
        /// If true, the test environment is being used instead of the production environment
        /// </summary>
        /// <value>test_mode</value>
        bool TestMode { get; }

        /// <summary>
        /// An estimation of the current Unix timestamp. The option will not be updated automatically unless the difference between the previous estimation and the locally available monotonic clocks changes significantly
        /// </summary>
        /// <value>unix_time</value>
        int UnixTime { get; }

        /// <summary>
        /// Username of a bot which can be used in inline mode for venues search
        /// </summary>
        /// <value>venue_search_bot_username</value>
        string VenueSearchBotUsername { get; }

        /// <summary>
        /// TDLib version. This options is guaranteed to come before all other updates since TDLib 1.4.0
        /// </summary>
        /// <value>version</value>
        string Version { get; }
    }

    public class OptionsService : IOptionsService
    {
        private readonly IProtoService _protoService;
        private readonly Dictionary<string, OptionValue> _values = new Dictionary<string, OptionValue>();

        public OptionsService(IProtoService protoService)
        {
            _protoService = protoService;
        }

        public void Handle(UpdateOption update)
        {
            switch (update.Name)
            {
                case "storage_max_time_from_last_access":
                    _storageMaxTimeFromLastAccess = GetValue<int>(update.Value);
                    break;
                case "disable_pinned_message_notifications":
                    _disablePinnedMessageNotifications = GetValue<bool>(update.Value);
                    break;
                case "animated_dice_sticker_set_name":
                    _animatedDiceStickerSetName = GetValue<string>(update.Value);
                    break;
                case "default_ton_blockchain_config":
                    _defaultTonBlockchainConfig = GetValue<string>(update.Value);
                    break;
                case "default_ton_blockchain_name":
                    _defaultTonBlockchainName = GetValue<string>(update.Value);
                    break;
                case "x_wallet_public_key":
                    _walletPublicKey = GetValue<string>(update.Value);
                    break;
                case "disable_contact_registered_notifications":
                    _disableContactRegisteredNotifications = GetValue<bool>(update.Value);
                    break;
                case "disable_top_chats":
                    _disableTopChats = GetValue<bool>(update.Value);
                    break;
                case "ignore_background_updates":
                    _ignoreBackgroundUpdates = GetValue<bool>(update.Value);
                    break;
                case "ignore_inline_thumbnails":
                    _ignoreInlineThumbnails = GetValue<bool>(update.Value);
                    break;
                case "ignore_platform_restrictions":
                    _ignorePlatformRestrictions = GetValue<bool>(update.Value);
                    break;
                case "ignore_sensitive_content_restrictions":
                    _ignoreSensitiveContentRestrictions = GetValue<bool>(update.Value);
                    break;
                case "language_pack_database_path":
                    _languagePackDatabasePath = GetValue<string>(update.Value);
                    break;
                case "language_pack_id":
                    _languagePackId = GetValue<string>(update.Value);
                    break;
                case "localization_target":
                    _localizationTarget = GetValue<string>(update.Value);
                    break;
                case "notification_group_count_max":
                    _notificationGroupCountMax = GetValue<int>(update.Value);
                    break;
                case "notification_group_size_max":
                    _notificationGroupSizeMax = GetValue<int>(update.Value);
                    break;
                case "online":
                    _online = GetValue<bool>(update.Value);
                    break;
                case "prefer_ipv6":
                    _preferIpv6 = GetValue<bool>(update.Value);
                    break;
                case "use_pfs":
                    _usePfs = GetValue<bool>(update.Value);
                    break;
                case "use_quick_ack":
                    _useQuickAck = GetValue<bool>(update.Value);
                    break;
                case "use_storage_optimizer":
                    _useStorageOptimizer = GetValue<bool>(update.Value);
                    break;
                case "animated_emoji_sticker_set_name":
                    _animatedEmojiStickerSetName = GetValue<string>(update.Value);
                    break;
                case "animation_search_bot_username":
                    _animationSearchBotUsername = GetValue<string>(update.Value);
                    break;
                case "authorization_date":
                    _authorizationDate = GetValue<int>(update.Value);
                    break;
                case "basic_group_size_max":
                    _basicGroupSizeMax = GetValue<int>(update.Value);
                    break;
                case "call_connect_timeout_ms":
                    _callConnectTimeoutMs = GetValue<int>(update.Value);
                    break;
                case "call_packet_timeout_ms":
                    _callPacketTimeoutMs = GetValue<int>(update.Value);
                    break;
                case "can_ignore_sensitive_content_restrictions":
                    _canIgnoreSensitiveContentRestrictions = GetValue<bool>(update.Value);
                    break;
                case "enabled_proxy_id":
                    _enabledProxyId = GetValue<int>(update.Value);
                    break;
                case "expect_blocking":
                    _expectBlocking = GetValue<bool>(update.Value);
                    break;
                case "favorite_stickers_limit":
                    _favoriteStickersLimit = GetValue<int>(update.Value);
                    break;
                case "forwarded_message_count_max":
                    _forwardedMessageCountMax = GetValue<int>(update.Value);
                    break;
                case "message_caption_length_max":
                    _messageCaptionLengthMax = GetValue<int>(update.Value);
                    break;
                case "message_text_length_max":
                    _messageTextLengthMax = GetValue<int>(update.Value);
                    break;
                case "my_id":
                    _myId = GetValue<int>(update.Value);
                    break;
                case "pinned_archived_chat_count_max":
                    _pinnedArchivedChatCountMax = GetValue<int>(update.Value);
                    break;
                case "pinned_chat_count_max":
                    _pinnedChatCountMax = GetValue<int>(update.Value);
                    break;
                case "photo_search_bot_username":
                    _photoSearchBotUsername = GetValue<string>(update.Value);
                    break;
                case "suggested_language_pack_id":
                    _suggestedLanguagePackId = GetValue<string>(update.Value);
                    break;
                case "supergroup_size_max":
                    _supergroupSizeMax = GetValue<int>(update.Value);
                    break;
                case "t_me_url":
                    _tMeUrl = GetValue<string>(update.Value);
                    break;
                case "test_mode":
                    _testMode = GetValue<bool>(update.Value);
                    break;
                case "unix_time":
                    _unixTime = GetValue<int>(update.Value);
                    break;
                case "venue_search_bot_username":
                    _venueSearchBotUsername = GetValue<string>(update.Value);
                    break;
                case "version":
                    _version = GetValue<string>(update.Value);
                    break;
                default:
                    _values[update.Name] = update.Value;
                    break;
            }
        }

        private T GetValue<T>(OptionValue option)
        {
            if (option is OptionValueBoolean valueBoolean && typeof(T) == typeof(bool))
            {
                return (T)(object)valueBoolean.Value;
            }
            else if (option is OptionValueInteger valueInteger && typeof(T) == typeof(int))
            {
                return (T)(object)valueInteger.Value;
            }
            else if (option is OptionValueString valueString && typeof(T) == typeof(string))
            {
                return (T)(object)valueString.Value;
            }
            else if (option is OptionValueEmpty)
            {
                return default(T);
            }

            Logs.Log.Write($"OptionsService, mismatching type, {typeof(T)} requested, {option.GetType()} received");
            return default(T);
        }

        private bool TryGetValue<T>(OptionValue option, out T value)
        {
            if (option is OptionValueBoolean valueBoolean && typeof(T) == typeof(bool))
            {
                value = (T)(object)valueBoolean.Value;
                return true;
            }
            else if (option is OptionValueInteger valueInteger && typeof(T) == typeof(int))
            {
                value = (T)(object)valueInteger.Value;
                return true;
            }
            else if (option is OptionValueString valueString && typeof(T) == typeof(string))
            {
                value = (T)(object)valueString.Value;
                return true;
            }
            else if (option is OptionValueEmpty)
            {
                value = default(T);
                return false;
            }

            Logs.Log.Write($"OptionsService, mismatching type, {typeof(T)} requested, {option.GetType()} received");
            value = default(T);
            return false;
        }



        public IReadOnlyDictionary<string, OptionValue> Values => _values;

        public T GetValue<T>(string key)
        {
            if (_values.TryGetValue(key, out OptionValue option))
            {
                return GetValue<T>(option);
            }

            return default(T);
        }

        public bool TryGetValue<T>(string key, out T value)
        {
            if (_values.TryGetValue(key, out OptionValue option))
            {
                return TryGetValue<T>(option, out value);
            }

            value = default(T);
            return false;
        }

        public void Clear()
        {
            _values.Clear();
        }

        private int _storageMaxTimeFromLastAccess;
        public int StorageMaxTimeFromLastAccess
        {
            get { return _storageMaxTimeFromLastAccess; }
            set
            {
                _storageMaxTimeFromLastAccess = value;
                _protoService.Send(new SetOption("storage_max_time_from_last_access", new OptionValueInteger(value)));
            }
        }

        private bool _disablePinnedMessageNotifications;
        public bool DisablePinnedMessageNotifications
        {
            get { return _disablePinnedMessageNotifications; }
            set
            {
                _disablePinnedMessageNotifications = value;
                _protoService.Send(new SetOption("disable_pinned_message_notifications", new OptionValueBoolean(value)));
            }
        }

        private string _animatedDiceStickerSetName;
        public string AnimatedDiceStickerSetName
        {
            get { return _animatedDiceStickerSetName; }
        }

        private string _defaultTonBlockchainConfig;
        public string DefaultTonBlockchainConfig
        {
            get { return _defaultTonBlockchainConfig; }
        }

        private string _defaultTonBlockchainName;
        public string DefaultTonBlockchainName
        {
            get { return _defaultTonBlockchainName; }
        }

        private string _walletPublicKey;
        public string WalletPublicKey
        {
            get { return _walletPublicKey; }
            set
            {
                _walletPublicKey = value;
                if (value == null)
                {
                    _protoService.Send(new SetOption("x_wallet_public_key", new OptionValueEmpty()));
                }
                else
                {
                    _protoService.Send(new SetOption("x_wallet_public_key", new OptionValueString(value)));
                }
            }
        }

        private bool _disableContactRegisteredNotifications;
        public bool DisableContactRegisteredNotifications
        {
            get { return _disableContactRegisteredNotifications; }
            set
            {
                _disableContactRegisteredNotifications = value;
                _protoService.Send(new SetOption("disable_contact_registered_notifications", new OptionValueBoolean(value)));
            }
        }

        private bool _disableTopChats;
        public bool DisableTopChats
        {
            get { return _disableTopChats; }
            set
            {
                _disableTopChats = value;
                _protoService.Send(new SetOption("disable_top_chats", new OptionValueBoolean(value)));
            }
        }

        private bool _ignoreBackgroundUpdates;
        public bool IgnoreBackgroundUpdates
        {
            get { return _ignoreBackgroundUpdates; }
            set
            {
                _ignoreBackgroundUpdates = value;
                _protoService.Send(new SetOption("ignore_background_updates", new OptionValueBoolean(value)));
            }
        }

        private bool _ignoreInlineThumbnails;
        public bool IgnoreInlineThumbnails
        {
            get { return _ignoreInlineThumbnails; }
            set
            {
                _ignoreInlineThumbnails = value;
                _protoService.Send(new SetOption("ignore_inline_thumbnails", new OptionValueBoolean(value)));
            }
        }

        private bool _ignorePlatformRestrictions;
        public bool IgnorePlatformRestrictions
        {
            get { return _ignorePlatformRestrictions; }
            set
            {
                _ignorePlatformRestrictions = value;
                _protoService.Send(new SetOption("ignore_platform_restrictions", new OptionValueBoolean(value)));
            }
        }

        private bool _ignoreSensitiveContentRestrictions;
        public bool IgnoreSensitiveContentRestrictions
        {
            get { return _ignoreSensitiveContentRestrictions; }
            set
            {
                _ignoreSensitiveContentRestrictions = value;
                _protoService.Send(new SetOption("ignore_sensitive_content_restrictions", new OptionValueBoolean(value)));
            }
        }

        private string _languagePackDatabasePath;
        public string LanguagePackDatabasePath
        {
            get { return _languagePackDatabasePath; }
            set
            {
                _languagePackDatabasePath = value;
                if (value == null)
                {
                    _protoService.Send(new SetOption("language_pack_database_path", new OptionValueEmpty()));
                }
                else
                {
                    _protoService.Send(new SetOption("language_pack_database_path", new OptionValueString(value)));
                }
            }
        }

        private string _languagePackId;
        public string LanguagePackId
        {
            get { return _languagePackId; }
            set
            {
                _languagePackId = value;
                if (value == null)
                {
                    _protoService.Send(new SetOption("language_pack_id", new OptionValueEmpty()));
                }
                else
                {
                    _protoService.Send(new SetOption("language_pack_id", new OptionValueString(value)));
                }
            }
        }

        private string _localizationTarget;
        public string LocalizationTarget
        {
            get { return _localizationTarget; }
            set
            {
                _localizationTarget = value;
                if (value == null)
                {
                    _protoService.Send(new SetOption("localization_target", new OptionValueEmpty()));
                }
                else
                {
                    _protoService.Send(new SetOption("localization_target", new OptionValueString(value)));
                }
            }
        }

        private int _notificationGroupCountMax;
        public int NotificationGroupCountMax
        {
            get { return _notificationGroupCountMax; }
            set
            {
                _notificationGroupCountMax = value;
                _protoService.Send(new SetOption("notification_group_count_max", new OptionValueInteger(value)));
            }
        }

        private int _notificationGroupSizeMax;
        public int NotificationGroupSizeMax
        {
            get { return _notificationGroupSizeMax; }
            set
            {
                _notificationGroupSizeMax = value;
                _protoService.Send(new SetOption("notification_group_size_max", new OptionValueInteger(value)));
            }
        }

        private bool _online;
        public bool Online
        {
            get { return _online; }
            set
            {
                _online = value;
                _protoService.Send(new SetOption("online", new OptionValueBoolean(value)));
            }
        }

        private bool _preferIpv6;
        public bool PreferIpv6
        {
            get { return _preferIpv6; }
            set
            {
                _preferIpv6 = value;
                _protoService.Send(new SetOption("prefer_ipv6", new OptionValueBoolean(value)));
            }
        }

        private bool _usePfs;
        public bool UsePfs
        {
            get { return _usePfs; }
            set
            {
                _usePfs = value;
                _protoService.Send(new SetOption("use_pfs", new OptionValueBoolean(value)));
            }
        }

        private bool _useQuickAck;
        public bool UseQuickAck
        {
            get { return _useQuickAck; }
            set
            {
                _useQuickAck = value;
                _protoService.Send(new SetOption("use_quick_ack", new OptionValueBoolean(value)));
            }
        }

        private bool _useStorageOptimizer;
        public bool UseStorageOptimizer
        {
            get { return _useStorageOptimizer; }
            set
            {
                _useStorageOptimizer = value;
                _protoService.Send(new SetOption("use_storage_optimizer", new OptionValueBoolean(value)));
            }
        }

        private string _animatedEmojiStickerSetName;
        public string AnimatedEmojiStickerSetName
        {
            get { return _animatedEmojiStickerSetName; }
        }

        private string _animationSearchBotUsername;
        public string AnimationSearchBotUsername
        {
            get { return _animationSearchBotUsername; }
        }

        private int _authorizationDate;
        public int AuthorizationDate
        {
            get { return _authorizationDate; }
        }

        private int _basicGroupSizeMax;
        public int BasicGroupSizeMax
        {
            get { return _basicGroupSizeMax; }
        }

        private int _callConnectTimeoutMs;
        public int CallConnectTimeoutMs
        {
            get { return _callConnectTimeoutMs; }
        }

        private int _callPacketTimeoutMs;
        public int CallPacketTimeoutMs
        {
            get { return _callPacketTimeoutMs; }
        }

        private bool _canIgnoreSensitiveContentRestrictions;
        public bool CanIgnoreSensitiveContentRestrictions
        {
            get { return _canIgnoreSensitiveContentRestrictions; }
        }

        private int _enabledProxyId;
        public int EnabledProxyId
        {
            get { return _enabledProxyId; }
        }

        private bool _expectBlocking;
        public bool ExpectBlocking
        {
            get { return _expectBlocking; }
        }

        private int _favoriteStickersLimit;
        public int FavoriteStickersLimit
        {
            get { return _favoriteStickersLimit; }
        }

        private int _forwardedMessageCountMax;
        public int ForwardedMessageCountMax
        {
            get { return _forwardedMessageCountMax; }
        }

        private int _messageCaptionLengthMax;
        public int MessageCaptionLengthMax
        {
            get { return _messageCaptionLengthMax; }
        }

        private int _messageTextLengthMax;
        public int MessageTextLengthMax
        {
            get { return _messageTextLengthMax; }
        }

        private int _myId;
        public int MyId
        {
            get { return _myId; }
        }

        private int _pinnedArchivedChatCountMax;
        public int PinnedArchivedChatCountMax
        {
            get { return _pinnedArchivedChatCountMax; }
        }

        private int _pinnedChatCountMax;
        public int PinnedChatCountMax
        {
            get { return _pinnedChatCountMax; }
        }

        private string _photoSearchBotUsername;
        public string PhotoSearchBotUsername
        {
            get { return _photoSearchBotUsername; }
        }

        private string _suggestedLanguagePackId;
        public string SuggestedLanguagePackId
        {
            get { return _suggestedLanguagePackId; }
        }

        private int _supergroupSizeMax;
        public int SupergroupSizeMax
        {
            get { return _supergroupSizeMax; }
        }

        private string _tMeUrl;
        public string TMeUrl
        {
            get { return _tMeUrl; }
        }

        private bool _testMode;
        public bool TestMode
        {
            get { return _testMode; }
        }

        private int _unixTime;
        public int UnixTime
        {
            get { return _unixTime; }
        }

        private string _venueSearchBotUsername;
        public string VenueSearchBotUsername
        {
            get { return _venueSearchBotUsername; }
        }

        private string _version;
        public string Version
        {
            get { return _version; }
        }
    }
}