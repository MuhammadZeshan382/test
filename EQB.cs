using System;
using System.Collections.Generic;
using RSSBus;

namespace Arc264y
{
	// Token: 0x0200136D RID: 4973
	public class EQB : EQo
	{
		// Token: 0x060129FF RID: 76287 RVA: 0x0071F5DC File Offset: 0x0071D7DC
		internal EQB(Eou eou_0)
		{
			this.tc = eou_0;
			this.OF();
		}

		// Token: 0x06012A00 RID: 76288 RVA: 0x0071F8F8 File Offset: 0x0071DAF8
		static EQB()
		{
			EQB.tM.Add(new EoX("NotifyEmailFrom", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyEmailTo", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SmtpServer", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SMTPAuthMechanism", 0, "", "Alerts", "Email Settings", "", "UserPassword", EQB.DG("")));
			EQB.tM.Add(new EoX("SmtpPort", 0, "", "Alerts", "Email Settings", "", "25", EQB.DG("")));
			EQB.tM.Add(new EoX("SmtpSSLMode", 0, "", "Alerts", "Email Settings", "", "NONE", EQB.DG("")));
			EQB.tM.Add(new EoX("SmtpUser", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SmtpPassword", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("AuthUrl", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("AccessTokenUrl", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ClientId", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ClientSecret", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("Scope", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyProxyUseGlobal", 10, "", "Alerts", "Email Settings", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyEmail", 0, "", "Alerts", "Alerts", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyEmailSubject", 0, "", "Alerts", "Alerts", "", "Arc", EQB.DG("")));
			EQB.tM.Add(new EoX("ReportEmailTo", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyStopStart", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyWindowsEvent", 0, "", "Alerts", "Alerts", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifySendToPort", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("EnableSlaNotify", 10, "", "Alerts", "General Alerts", "", "true", EQB.DG("")));
			string text = "Archive";
			if (giw.wp(ghD.j("profile", "application"), "autotasktypedefault"))
			{
				goto IL_49F8;
			}
			IL_04EB:
			EQB.tM.Add(new EoX("AutoTaskType", 0, "", "Advanced", "Cleanup Options", "", text, EQB.DG("")));
			string text2 = "30";
			if (giw.wp(ghD.j("profile", "application"), "autotaskintervaldefault"))
			{
				text2 = giw.wc(ghD.j("profile", "application"), "autotaskintervaldefault");
			}
			EQB.tM.Add(new EoX("AutoTaskInterval", 0, "", "Advanced", "Cleanup Options", "", text2, EQB.DG("")));
			EQB.tM.Add(new EoX("MaxApplicationLogs", 0, "", "", "", "", "100000", EQB.DG("")));
			EQB.tM.Add(new EoX("MaxAutomationLogs", 0, "", "", "", "", "100000", EQB.DG("")));
			EQB.tM.Add(new EoX("DBCleanupAppLogsInterval", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("DBCleanupAppRequestsInterval", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("DBCleanupAppAuditsInterval", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("DBCleanupAutomationLogsInterval", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("CleanupTransactionsChunkSize", 2, "", "", "", "", "5000", EQB.DG("")));
			EQB.tM.Add(new EoX("CleanupOrphanedLogFiles", 10, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("MigrationChunkSize", 2, "", "", "", "", "5000", EQB.DG("")));
			EQB.tM.Add(new EoX("PartitionMigrationEnabled", 10, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("PartitionIntervalDays", 0, "", "", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("PartitionWeekStartDay", 0, "", "", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("AppDbReclaimMode", 0, "", "", "", "", "AutoReclaim", EQB.DG("")));
			EQB.tM.Add(new EoX("LegacyTransactionRollbackDays", 2, "", "", "", "", "30", EQB.DG("")));
			EQB.tM.Add(new EoX("RegisterStatus", 0, "", "", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("UseCentralizedStorage", 0, "", "", "", "", "true", EQB.DG("")));
			string text3 = "60";
			if (giw.wp(ghD.j("profile", "application"), "commandtimeoutdefault"))
			{
				text3 = giw.wc(ghD.j("profile", "application"), "commandtimeoutdefault");
			}
			EQB.tM.Add(new EoX("CommandTimeout", 2, "", "", "", "", text3, EQB.DG("")));
			string text4 = "600";
			if (giw.wp(ghD.j("profile", "application"), "schemacommandtimeoutdefault"))
			{
				text4 = giw.wc(ghD.j("profile", "application"), "schemacommandtimeoutdefault");
			}
			EQB.tM.Add(new EoX("SchemaCommandTimeout", 2, "", "", "", "", text4, EQB.DG("")));
			EQB.tM.Add(new EoX("AgreedTermsVersion", 0, "", "", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("EncryptPasswords", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("AllowUnmaskedPasswords", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("CleanupSentFolder", 0, "", "Advanced", "Cleanup Options", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("CleanupSendFolder", 0, "", "Advanced", "Cleanup Options", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("CleanupReceiveFolder", 0, "", "Advanced", "Cleanup Options", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("ArchivePageSize", 0, "", "", "", "", "10000", EQB.DG("")));
			EQB.tM.Add(new EoX("ArchiveDestination", 0, "", "Advanced", "Cleanup Options", "", "LocalDisk", EQB.DG("")));
			EQB.tM.Add(new EoX("S3URL", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ResourceCacheRetentionDays", 2, "", "", "", "", "30", EQB.DG("")));
			EQB.tM.Add(new EoX("S3Prefix", 0, "", "", "", "", "/", EQB.DG("")));
			EQB.tM.Add(new EoX("S3Bucket", 0, "", "Advanced", "Cleanup Options", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("S3AccessKey", 0, "", "Advanced", "Cleanup Options", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("S3SecretKey", 1, "", "Advanced", "Cleanup Options", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("S3Region", 0, "", "Advanced", "Cleanup Options", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("S3RetryCount", 0, "", "", "", "", "5", EQB.DG("")));
			EQB.tM.Add(new EoX("S3MaxThread", 0, "", "", "", "", "5", EQB.DG("")));
			EQB.tM.Add(new EoX("RecordsPerPage", 0, "", "", "", "", "10", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("ShowParentPortOption", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("BlockedExtensions", 0, "", "", "", "", ".exe,.aspx,.jsp,.js", EQB.DG("")));
			EQB.tM.Add(new EoX("MaxUploadFileCount", 2, "", "", "", "", "256", EQB.DG("NumberMin=1")));
			EQB.tM.Add(new EoX("CleanupTransactions", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyCertificateExpire", 0, "", "Alerts", "Alerts", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("NotifyCertificateExpireDays", 0, "", "", "", "", "30", EQB.DG("")));
			EQB.tM.Add(new EoX("ProcessParallel", 0, "", "Advanced", "Performance", "", "true", EQB.DG("LicenseRestrictValue=false")));
			EQB.tM.Add(new EoX("WorkerPool", 0, "", "Advanced", "Performance", "", "20", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("MaxWorkersPerPort", 0, "", "Advanced", "Performance", "", "5", EQB.DG("")));
			EQB.tM.Add(new EoX("MaxFilesPerPort", 0, "", "Advanced", "Performance", "", "20", EQB.DG("")));
			EQB.tM.Add(new EoX("SendStatusReport", 0, "", "Alerts", "Alerts", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("SendReportInterval", 0, "", "Alerts", "Alerts", "", "Weekly", EQB.DG("")));
			EQB.tM.Add(new EoX("SyslogEnable", 0, "", "Alerts", "Syslog Settings", "Enable sending logs to the sysLog server.", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("SyslogRemoteHost", 0, "", "Alerts", "Syslog Settings", "", "255.255.255.255", EQB.DG("")));
			EQB.tM.Add(new EoX("SyslogRemotePort", 0, "", "Alerts", "Syslog Settings", "", "514", EQB.DG("")));
			EQB.tM.Add(new EoX("SyslogProtocol", 0, "", "Alerts", "Syslog Settings", "", "udp", EQB.DG("")));
			EQB.tM.Add(new EoX("SysLogEnabledLogs", 0, "", "Alerts", "Syslog Settings", "", "Application", EQB.DG("")));
			EQB.tM.Add(new EoX("SysLogSSLEnabled", 0, "", "Alerts", "Syslog Settings", "", "false", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("SysLogSSLAcceptServerCert", 0, "", "Alerts", "Syslog Settings", "", "udp", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("SysLogVersion", 0, "", "Alerts", "Syslog Settings", "", "0", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("SysLogFacility", 0, "", "Alerts", "Syslog Settings", "", "1", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("SysLogMessageFormat", 0, "", "Alerts", "Syslog Settings", "", "CEF", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("LogWorkerPool", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("DefaultMaxRequest", 0, "", "", "", "", "-1", EQB.DG("")));
			EQB.tM.Add(new EoX("DefaultMaxConcurrent", 0, "", "", "", "", "-1", EQB.DG("")));
			EQB.tM.Add(new EoX("ShowConnectorsPage", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("UseRelativePath", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("SearchableHeaders", 0, "", "Advanced", "Advanced Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("LogServiceMonitor", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("LogPagingSize", 0, "", "", "", "", "-1", EQB.DG("InitValue=5000")));
			EQB.tM.Add(new EoX("ServiceMonitorInterval", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ServiceMaxAttempts", 0, "", "", "", "", "5", EQB.DG("")));
			EQB.tM.Add(new EoX("CollectUserData", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("AllowOnlineInstallConnector", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("healthycheckinterval", 0, "", "Security", "", "", "1", EQB.DG("")));
			EQB.tM.Add(new EoX("UseMemoryLock", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("FileLockVersion", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("UseCentralizedStorage", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("UseDatabaseLock", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("ShowDeprecatedConnectors", 0, "", "Advanced", "Advanced Settings", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("IsClassicProfilesUi", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("ShowBetaConnectors", 0, "", "Advanced", "Advanced Settings", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("ShowOverlappingConnectors", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("ArchiveFolder", 0, "", "Advanced", "Cleanup Options", "", "", EQB.DG("InitValue=archive")));
			EQB.tM.Add(new EoX("SupportDailyTask", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOClientId", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOClientSecret", 1, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOIssuerIdentifier", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSODiscoveryURL", 0, "", "Security", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOIssuerCertificateRefreshInterval", 0, "", "Security", "", "", "1", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOIssuerCertificateRefreshOnFailures", 0, "", "Security", "", "", "5", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOIssuerCertificateRefreshTime", 0, "", "", "", "", "0", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("AutoTaskTime", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("healthycheckreportinterval", 0, "", "Alerts", "", "", "1440", EQB.DG("")));
			EQB.tM.Add(new EoX("healthycheckreportemailto", 0, "", "Alerts", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("checkitemsnumberinfoldersreportlimit", 0, "", "Alerts", "", "", "5000", EQB.DG("")));
			EQB.tM.Add(new EoX("checkdbrecordscntreportlimit", 0, "", "Alerts", "", "", "100000", EQB.DG("")));
			EQB.tM.Add(new EoX("checkmemoryusagereportlimit", 0, "", "Alerts", "", "", "60", EQB.DG("")));
			EQB.tM.Add(new EoX("checkdiskusagereportlimit", 0, "", "Alerts", "", "", "60", EQB.DG("")));
			EQB.tM.Add(new EoX("checkdiskinodeusage", 10, "", "Alerts", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOScopes", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOAudienceURIs", 0, "", "Security", "Single Sign On (SSO)", "", "urn:arc:sp:" + Eyf.DI(Eyf.Fm()), EQB.DG("")));
			EQB.tM.Add(new EoX("SSOAuthorizationURL", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOTokenURL", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOLogoffURL", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOIssuerCertificate", 3, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOKeyClaim", 0, "", "Security", "Single Sign On (SSO)", "", "sub", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOTokenSignatureAlgorithm", 0, "", "Security", "Single Sign On (SSO)", "", "RS256", EQB.DG("")));
			EQB.tM.Add(new EoX("StateStorageType", 0, "", "", "", "", "Database", EQB.DG("")));
			EQB.tM.Add(new EoX("AutoSSOLogin", 10, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOEnabled", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOType", 0, "", "Security", "Single Sign On (SSO)", "", "OIDC", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOEnableJITProvisioning", 10, "", "Security", "Single Sign On (SSO)", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("SSODefaultRole", 0, "", "Security", "Single Sign On (SSO)", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("SSOGroupRolesMapping", 0, "", "Security", "Mapping Group Roles", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("MFAType", 0, "", "Security", "Advanced Settings", "", "enabled", EQB.DG("")));
			EQB.tM.Add(new EoX("MFATypeReadonly", 0, "", "", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("enablecors", 0, "", "Security", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("corsallowcredentials", 10, "Security", "", "", "", "false", EQB.DG("BooleanName=Enabled")));
			EQB.tM.Add(new EoX("corsalloworigin", 0, "", "Security", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("corsallowalldomains", 10, "", "Security", "", "", "false", EQB.DG("BooleanName=Enabled")));
			EQB.tM.Add(new EoX("corsallowmethods", 0, "", "Security", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("corsallowheaders", 0, "", "Security", "", "", "*", EQB.DG("")));
			EQB.tM.Add(new EoX("corsmaxage", 0, "", "", "Security", "", "3600", EQB.DG("")));
			EQB.tM.Add(new EoX("TrustedIP", 0, "", "Security", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("BlockedIP", 0, "", "Security", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("AutoDisableInactiveAccountEnabledTime", 0, "", "Security", "Additional Settings", "", "-1", EQB.DG("")));
			EQB.tM.Add(new EoX("AutoDisableInactiveAccount", 0, "", "Security", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("MaxInactiveDays", 0, "", "Security", "", "", "-1", EQB.DG("")));
			EQB.tM.Add(new EoX("IPProtectedResources", 0, "", "Security", "", "", "AdminAPI,FlowAPI", EQB.DG("")));
			EQB.tM.Add(new EoX("PasswordReuseRestriction", 0, "", "Security", "", "", "2", EQB.DG("")));
			EQB.tM.Add(new EoX("PasswordExpireDays", 0, "", "Security", "", "", "-1", EQB.DG("")));
			EQB.tM.Add(new EoX("PasswordExpirationAlertDays", 0, "", "Security", "", "", "5", EQB.DG("")));
			EQB.tM.Add(new EoX("AllowAuthTokenInURL", 10, "Security", "", "", "", "false", EQB.DG("InternalSetting=true,BooleanName=Enabled")));
			EQB.tM.Add(new EoX("TraceSDKAPIConnectors", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("MessageBufferSize", 0, "", "Advanced", "Advanced Settings", "", "512KB", EQB.DG("")));
			EQB.tM.Add(new EoX("uitimeformat", 6, "Time Format", "Advanced", "Advanced Settings", "Select the time format display preference", "24", EQB.DG("Options=\"12,24\"")));
			EQB.tM.Add(new EoX("BackoffInterval", 0, "", "", "", "", "60", EQB.DG("")));
			EQB.tM.Add(new EoX("BackoffMaxThreshold", 0, "", "", "", "", "15", EQB.DG("")));
			EQB.tM.Add(new EoX("BackoffMinThreshold", 0, "", "", "", "", "3", EQB.DG("")));
			EQB.tM.Add(new EoX("LogLevel", 6, "Log Level", "", "Logging", "The verbosity of logs generated by the connector.", rgw.J.f(), EQB.DG("Options=\"None,Error,Warning,Info,Debug,Trace\"")));
			EQB.tM.Add(new EoX("AutomationInterval", 0, "", "", "", "", "500", EQB.DG("")));
			EQB.tM.Add(new EoX("LongMessageIdThreshold", 0, "", "", "", "", "55", EQB.DG("")));
			EQB.tM.Add(new EoX("MaxConnectorIdLength", 0, "", "", "", "", "70", EQB.DG("")));
			EQB.tM.Add(new EoX("DisableSampleFlow", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("MinimumPasswordLength", 0, "", "", "Security", "", "8", EQB.DG("")));
			EQB.tM.Add(new EoX("MaximumPasswordLength", 0, "", "", "Security", "", "128", EQB.DG("")));
			EQB.tM.Add(new EoX("MinimumPasswordSpecialCharacters", 0, "", "Security", "", "", "0", EQB.DG("")));
			EQB.tM.Add(new EoX("MinimumPasswordLowercaseCharacters", 0, "", "Security", "", "", "1", EQB.DG("")));
			EQB.tM.Add(new EoX("MinimumPasswordUppercaseCharacters", 0, "", "Security", "", "", "1", EQB.DG("")));
			EQB.tM.Add(new EoX("MinimumPasswordNumericCharacters", 0, "", "Security", "", "", "1", EQB.DG("")));
			EQB.tM.Add(new EoX("EnableFlowAPILocks", 10, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("EnableJSONPolicyEditor", 10, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("AdminAPILockingStrategy", 0, "", "", "", "", "message", EQB.DG("")));
			EQB.tM.Add(new EoX("BufferedWorkerMessageCount", 0, "", "Advanced", "Advanced Settings", "", "0", EQB.DG("")));
			EQB.tM.Add(new EoX("OpsRequireAuthToken", 0, "", "", "", "", "auto", EQB.DG("")));
			EQB.tM.Add(new EoX("ShowTransactionsTab", 10, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("FlowSnapshotConnectorThreshold", 0, "", "", "", "", "100", EQB.DG("")));
			EQB.tM.Add(new EoX("AllowCustomConnectorDirectories", 10, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("suspenddiskusagethreshold", 2, "", "Alerts", "", "", "0", EQB.DG("InitValue=95")));
			EQB.tM.Add(new EoX("automationdiskusagethreshold", 2, "", "Alerts", "", "", "0", EQB.DG("InitValue=90")));
			EQB.tM.Add(new EoX("ResourceUpdateConflictAction", 6, "", "", "", "", "Warn", EQB.DG("Options=\"Fail,Warn,Ignore\"")));
			EQB.tM.Add(new EoX("IntegrityMaxEntryLag", 0, "", "", "", "", "1000", EQB.DG("")));
			EQB.tM.Add(new EoX("DisableIntegrityWarning", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("AzureKVMetadataTTL", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("AzureKVValueBackstopTTL", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ConnectorDefaultOutputFormat", 0, "", "", "", "", "Message", EQB.DG("")));
			EQB.tM.Add(new EoX("EmailProtocol", 0, "", "Alerts", "Email Settings", "", "smtp", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("EmailSendgridURL", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("EmailSendGridApiKey", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("SendgridNotifyEmailFrom", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("AllowArcScriptInAlertsSubject", 0, "", "", "", "", "false", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("LocalHost", 0, "", "", "", "", "", EQB.DG("LicenseType=Express")));
			EQB.tM.Add(new EoX("LocalIP", 0, "", "Advanced", "Advanced Settings", "", "", EQB.DG("LicenseType=Express;Alias=LocalHost")));
			EQB.tM.Add(new EoX("BaseURL", 0, "", "Advanced", "Advanced Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("HTTPForwardedHeader", 0, "", "Advanced", "Advanced Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("PublicDomain", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("AllowNonFIPSCompliantAlgorithms", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("UseManagedSecurityAPI", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("CertUseManagedSecurityAPI", 0, "", "Advanced", "Advanced Settings", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("ProxyType", 0, "", "Security", "Proxy Settings", "", "None", EQB.DG("")));
			EQB.tM.Add(new EoX("ProxyHost", 0, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ProxyPort", 0, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ProxyUser", 0, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ProxyPassword", 0, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("ProxyAuthscheme", 0, "", "Security", "Proxy Settings", "", "None", EQB.DG("")));
			EQB.tM.Add(new EoX("aiprovider", 0, "", "Advanced", "AI", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("aiapikey", 1, "", "Advanced", "AI", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("aibaseurl", 0, "", "Advanced", "AI", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("aimodel", 0, "", "Advanced", "AI", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("aitimeout", 2, "", "", "", "", "600", EQB.DG("")));
			EQB.tM.Add(new EoX("aicontextwindow", 2, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("aitemperature", 2, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("aitopk", 2, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("aitopp", 2, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("PatternMiningEnabled", 10, "", "", "", "", "true", EQB.DG("")));
			EQB.tM.Add(new EoX("PatternDrainDepth", 2, "", "", "", "", "4", EQB.DG("")));
			EQB.tM.Add(new EoX("PatternDrainSimTh", 2, "", "", "", "", "0.4", EQB.DG("")));
			EQB.tM.Add(new EoX("PatternDrainMaxChildren", 2, "", "", "", "", "50", EQB.DG("")));
			EQB.tM.Add(new EoX("PatternDrainMaxPattern", 0, "", "", "", "", "Error=500;Warning=500;Info=500;Debug=250;Trace=250", EQB.DG("")));
			EQB.tM.Add(new EoX("EDIPartnerSyncInterval", 2, "", "", "", "", "", EQB.DG("")));
			EQB.tM.Add(new EoX("VersionControlEnabled", 10, "", "Advanced", "Version Control", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("LogGitCommands", 10, "", "", "", "", "false", EQB.DG("")));
			EQB.tM.Add(new EoX("EncryptionAtRestMode", 6, "", "Security", "Encryption at Rest", "", "-1", EQB.DG("Options=\"-1,0,1,2\",OptionNames=\"Disabled,Compatibility,Default,Strict\"")));
			EQB.tM.Add(new EoX("EncryptionAtRestModeReadonly", 0, "", "", "", "", "", EQB.DG("InternalSetting=true")));
			EQB.tM.Add(new EoX("EnableMCPServer", 10, "", "", "", "", "true", EQB.DG("")));
			EQB.tl = new EEa<EoX>();
			using (lmg<EoX> lmg = EQB.tM.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					EQB.tl.n(eoX.W(), eoX);
				}
			}
			EQB.tQ = new lmr<EoX>();
			EQB.tQ.Add(new EoX("ProxyHost", 0, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("ProxyPassword", 1, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("ProxyPort", 0, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("ProxyType", 0, "", "Security", "Proxy Settings", "", "None", EQB.DG("")));
			EQB.tQ.Add(new EoX("ProxyUser", 0, "", "Security", "Proxy Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("ProxyAuthscheme", 0, "", "Security", "Proxy Settings", "", "none", EQB.DG("")));
			EQB.tQ.Add(new EoX("SmtpSSLCert", 0, "", "Advanced", "SmtpSSLCert", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("AllowNonFIPSCompliantAlgorithms", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.tQ.Add(new EoX("PublicDomain", 0, "", "", "", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("LocalHost", 0, "", "", "", "", "", EQB.DG("LicenseType=Express")));
			EQB.tQ.Add(new EoX("LocalIP", 0, "", "Advanced", "Advanced Settings", "", "", EQB.DG("LicenseType=Express;Alias=LocalHost")));
			EQB.tQ.Add(new EoX("BaseURL", 0, "", "Advanced", "Advanced Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("UseManagedSecurityAPI", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tQ.Add(new EoX("MaskSensitive", 0, "", "", "", "", "true", EQB.DG("InternalSetting=true")));
			EQB.tQ.Add(new EoX("SmtpServer", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("SmtpPort", 0, "", "Alerts", "Email Settings", "", "25", EQB.DG("")));
			EQB.tQ.Add(new EoX("SmtpUser", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("SmtpPassword", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("SmtpSSLMode", 0, "", "Alerts", "Email Settings", "", "NONE", EQB.DG("")));
			EQB.tQ.Add(new EoX("SMTPAuthMechanism", 0, "", "Alerts", "Email Settings", "", "userpassword", EQB.DG("")));
			EQB.tQ.Add(new EoX("AuthUrl", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("AccessTokenUrl", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("ClientId", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("ClientSecret", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("Scope", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("AccessToken", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("RefreshToken", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("ExpireIn", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("oauthtokentimestamp", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("NotifyEmailFrom", 0, "", "Alerts", "Email Settings", "", "noreply@" + "CData".ToLower() + ".com", EQB.DG("")));
			EQB.tQ.Add(new EoX("SendgridNotifyEmailFrom", 0, "", "", "", "", "cloud@arc." + "CData".ToLower() + ".com", EQB.DG("InternalSetting=true")));
			EQB.tQ.Add(new EoX("NotifyEmailTo", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("HTTPForwardedHeader", 0, "", "Advanced", "Advanced Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("CertUseManagedSecurityAPI", 0, "", "Advanced", "Advanced Settings", "", "false", EQB.DG("")));
			EQB.tQ.Add(new EoX("EmailProtocol", 0, "", "Alerts", "Email Settings", "", "smtp", EQB.DG("")));
			EQB.tQ.Add(new EoX("EmailSendgridURL", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("EmailSendGridApiKey", 1, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("SmtpOtherConfigs", 0, "", "Alerts", "Email Settings", "", "", EQB.DG("")));
			EQB.tQ.Add(new EoX("AllowArcScriptInAlertsSubject", 0, "", "", "", "", "false", EQB.DG("")));
			EQB.tQ.Add(new EoX("ResourceCacheRetentionDays", 2, "", "", "", "", "30", EQB.DG("")));
			EQB.tQ.Add(new EoX("RotateIntervalReadonly", 10, "", "", "", "", "false", EQB.DG("InternalSetting=true")));
			EQB.tQ.Add(new EoX("DeleteIntervalReadonly", 10, "", "", "", "", "false", EQB.DG("InternalSetting=true")));
			EQB.tQ.Add(new EoX("TrackPendingTimeout", 0, "", "", "", "", "true", EQB.DG("")));
			EQB.ty = new EEa<EoX>();
			using (lmg<EoX> lmg = EQB.tQ.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					EQB.ty.n(eoX.W(), eoX);
				}
			}
			EQB.tP = new lmr<EoX>();
			EQB.tP.Add(new EoX("LogLevel", 6, "Log Level", "", "", "The verbosity of logs generated by the connector.", rgw.J.f(), EQB.DG("Options=\"None,Error,Warning,Info,Debug,Trace\"")));
			EQB.tP.Add(new EoX("RotateInterval", 2, "Log Rotate Interval", "", "", "The number of days to wait before creating a new log file.", "30", EQB.DG("CustomUI=compiled://~/includes/profileRotateInterval.rst" + ((!EQB.Wv()) ? "" : ",Readonly=true") + ",NumberMin=0")));
			EQB.tP.Add(new EoX("DeleteInterval", 2, "Log Delete Interval", "", "", "The number of days to wait before deleting old log files.", "90", EQB.DG("CustomUI=compiled://~/includes/profileDeleteInterval.rst" + ((!EQB.Wv()) ? "" : ",Readonly=true") + ",NumberMin=0")));
			EQB.tF = new EEa<EoX>();
			using (lmg<EoX> lmg = EQB.tP.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					EQB.tF.n(eoX.W(), eoX);
				}
			}
			EQB.tv = new lmr<EoX>();
			EQB.tv.Add(new EoX("OverrideEmailSettings", 10, "Override Global Setting", "Alerts", "Alerts", "", "false", EQB.DG("TabCustomUI=embedded/WorkspaceSettings/AlertsTab,TabIcon=bell")));
			EQB.tv.Add(new EoX("NotifyEmail", 0, "Error Alert", "Alerts", "Alerts", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("NotifyEmailTo", 0, "To", "Alerts", "Alerts", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("NotifyEmailSubject", 0, "Subject", "Alerts", "Alerts", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("NotifyEmailFrom", 0, "From", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SMTPAuthMechanism", 0, "Auth Scheme", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SmtpServer", 0, "SMTP Server", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SmtpUser", 0, "User", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SmtpPassword", 1, "Password", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SmtpPort", 0, "Port", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SmtpSSLMode", 0, "Encryption Type", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SmtpSSLCert", 0, "Server SSL Certificate", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("EmailProtocol", 0, "Email Protocol", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("EmailSendgridURL", 0, "SendGrid URL", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("EmailSendGridApiKey", 1, "API Key", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("SmtpOtherConfigs", 0, "Other Settings", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("AllowArcScriptInAlertsSubject", 0, "Allow ArcScript in Subject", "Alerts", "Alerts", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("OverridePerformanceSettings", 10, "Override Global Setting", "Performance", "Performance", "", "false", EQB.DG("TabCustomUI=embedded/WorkspaceSettings/PerformanceTab,TabIcon=arrow-trend-up")));
			EQB.tv.Add(new EoX("MaxWorkersPerPort", 0, "Max Workers", "Performance", "Performance", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("MaxFilesPerPort", 0, "Max Files", "Performance", "Performance", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("OverrideCleanupOptions", 10, "Override Global Setting", "Cleanup", "Cleanup", "", "false", EQB.DG("TabCustomUI=embedded/WorkspaceSettings/CleanupTab,TabIcon=broom-wide")));
			EQB.tv.Add(new EoX("AutoTaskType", 0, "Type", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("AutoTaskInterval", 0, "Interval (Days)", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("CleanupSentFolder", 0, "Include Files in Sent Folders", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("CleanupSendFolder", 0, "Include Files in Send Folders", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("CleanupReceiveFolder", 0, "Include Files in Receive Folders", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("CleanupTransactions", 0, "Cleanup Transactions", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("ArchiveDestination", 0, "Archive Type", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("ArchiveFolder", 0, "Local Archive Folder", "Cleanup", "Cleanup", "", "", EQB.DG("InitValue=archive")));
			EQB.tv.Add(new EoX("S3URL", 0, "S3 URL", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("S3Prefix", 0, "S3 Prefix", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("S3Bucket", 0, "S3 Bucket", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("S3AccessKey", 0, "S3 Access Key", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("S3SecretKey", 1, "S3 Secret Key", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("S3Region", 0, "S3 Region", "Cleanup", "Cleanup", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("BackoffInterval", 0, "Backoff Interval (minutes)", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("BackoffMaxThreshold", 0, "Backoff Max Threshold", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("BackoffMinThreshold", 0, "Backoff Min Threshold", "", "", "", "", EQB.DG("")));
			EQB.tv.Add(new EoX("VersionControlEnabled", 10, "VersionControlEnabled", "Git Version Control", "Git Version Control", "", "false", EQB.DG("TabCustomUI=embedded/WorkspaceSettings/VersionControlTab,TabIcon=code-branch")));
			EQB.td = new EEa<EoX>();
			using (lmg<EoX> lmg = EQB.tv.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					EQB.td.n(eoX.W(), eoX);
				}
			}
			EQB.tK = new lmr<EoX>();
			EQB.tK.Add(new EoX("Name", 0, "Name", "", "", "", "", EQB.DG("")));
			EQB.tK.Add(new EoX("CreationTimestamp", 0, "CreationTimestamp", "", "", "", "", EQB.DG("")));
			EQB.tK.Add(new EoX("Direction", 0, "Direction", "", "", "", "", EQB.DG("")));
			EQB.tK.Add(new EoX("Standard", 0, "Standard", "", "", "", "", EQB.DG("")));
			EQB.tK.Add(new EoX("Version", 0, "Version", "", "", "", "", EQB.DG("")));
			EQB.tK.Add(new EoX("Document", 0, "Document", "", "", "", "", EQB.DG("")));
			EQB.tK.Add(new EoX("Flow", 0, "Flow", "", "", "", "", EQB.DG("")));
			EQB.tK.Add(new EoX("Template", 5, "Template", "", "", "", "", EQB.DG("")));
			EQB.tb = new EEa<EoX>();
			using (lmg<EoX> lmg = EQB.tK.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					EQB.tb.n(eoX.W(), eoX);
				}
			}
			EQB.te = new lmr<EoX>();
			EQB.te.Add(new EoX("Name", 0, "Name", "", "", "", "", EQB.DG("")));
			EQB.te.Add(new EoX("CreationTimestamp", 0, "CreationTimestamp", "", "", "", "", EQB.DG("")));
			EQB.te.Add(new EoX("FileTransfer", 0, "FileTransfer", "", "", "", "", EQB.DG("")));
			EQB.te.Add(new EoX("FileTranslator", 0, "FileTranslator", "", "", "", "", EQB.DG("")));
			EQB.te.Add(new EoX("Documents", 0, "Documents", "", "", "", "", EQB.DG("")));
			EQB.tI = new EEa<EoX>();
			using (lmg<EoX> lmg = EQB.te.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					EQB.tI.n(eoX.W(), eoX);
				}
				goto IL_4A88;
			}
			goto IL_49F8;
			IL_4A88:
			EQB.tJ = new lmr<EoX>();
			EQB.tH = new EEa<EoX>();
			EQB.DJ(EQB.tv);
			EQB.DJ(EQB.tK);
			EQB.DJ(EQB.te);
			EQB.tg = "<arc:info title=\"Before Send\" desc=\"This event is fired before sending a file.\">\n  <input name=\"WorkspaceId\"   desc=\"The id of the workspace that is sending file.\" />\n  <input name=\"ConnectorId\"   desc=\"The id of the connector that is sending file.\" />\n  <input name=\"Direction\"     desc=\"The direction of transaction.\" />\n  <input name=\"MessageId\"     desc=\"The Id of the send message containing the file.\" />\n  <input name=\"Filename\"      desc=\"The name of the file to send.\" />\n  <input name=\"FilePath\"      desc=\"The path of the file to send.\" />\n  <input name=\"Attachment#\"   desc=\"The path of the attachment to send.\" />\n{0}</arc:info>\n\n";
			EQB.tt = "<arc:info title=\"After Send\"     desc=\"This event is fired after sending a file.\">\n  <input name=\"WorkspaceId\"      desc=\"The id of the workspace that sent file.\" />\n  <input name=\"ConnectorId\"      desc=\"The id of the connector that sent file.\" />\n  <input name=\"Direction\"        desc=\"The direction of transaction.\" />\n  <input name=\"Filename\"         desc=\"The name of the file that was sent.\" />\n  <input name=\"FilePath\"         desc=\"The path of the file after sending.\" />\n  <input name=\"Attachment#\"      desc=\"The path of the attachment after sending.\" />\n  <input name=\"MessageId\"        desc=\"The Id of the send message containing the file.\" />\n{0}  <input name=\"ErrorMessage\"     desc=\"If an error occurred, this will contain the error message.\" />\n  <input name=\"FinalAttempt\"     desc=\"If true, the number of transfer attempts is equal to or greater than the configured maximum number of send attempts for this connector. This file will not be sent again unless it is sent manually.\" />\n</arc:info>\n\n";
			EQB.tU = "<arc:info title=\"After Receive\"  desc=\"This event is fired after receiving a file.\">\n  <input name=\"WorkspaceId\"      desc=\"The id of the workspace that is receiving file.\" />\n  <input name=\"ConnectorId\"      desc=\"The id of the connector that is receiving file.\" />\n  <input name=\"Direction\"        desc=\"The direction of transaction.\" />\n  <input name=\"Filename\"         desc=\"The name of the file that was received.\" />\n  <input name=\"FilePath\"         desc=\"The path of the file that was received.\" />\n  <input name=\"Attachment#\"      desc=\"The path of the attachment was received.\" />\n  <input name=\"MessageId\"        desc=\"The Id of the transaction.\" />\n{0}  <input name=\"ErrorMessage\"     desc=\"If an error occurred, this will contain the error message.\" />\n</arc:info>\n\n";
			EQB.tR = "****>>>>" + lyc.G() + "<<<<****";
			return;
			IL_49F8:
			text = giw.wc(ghD.j("profile", "application"), "autotasktypedefault");
			goto IL_04EB;
		}

		// Token: 0x06012A01 RID: 76289 RVA: 0x00724448 File Offset: 0x00722648
		public string B()
		{
			return this.tx;
		}

		// Token: 0x06012A02 RID: 76290 RVA: 0x00724460 File Offset: 0x00722660
		public string s()
		{
			return this.UQ;
		}

		// Token: 0x06012A03 RID: 76291 RVA: 0x00724478 File Offset: 0x00722678
		public EQg L(glr glr_0)
		{
			return this.tc.oJR(glr_0);
		}

		// Token: 0x06012A04 RID: 76292 RVA: 0x00724494 File Offset: 0x00722694
		public EQm D(gaa gaa_0)
		{
			return this.tc.oJR(gaa_0);
		}

		// Token: 0x06012A05 RID: 76293 RVA: 0x007244B0 File Offset: 0x007226B0
		public bool W()
		{
			return this.tc.oJz();
		}

		// Token: 0x06012A06 RID: 76294 RVA: 0x007244C8 File Offset: 0x007226C8
		public string i()
		{
			return this.tA;
		}

		// Token: 0x06012A07 RID: 76295 RVA: 0x007244E0 File Offset: 0x007226E0
		public int G()
		{
			return this.tO;
		}

		// Token: 0x06012A08 RID: 76296 RVA: 0x007244F8 File Offset: 0x007226F8
		public string p()
		{
			return Eyf.UO(this.Ug, this.tx);
		}

		// Token: 0x06012A09 RID: 76297 RVA: 0x00724518 File Offset: 0x00722718
		public int Z()
		{
			return this.Ut;
		}

		// Token: 0x06012A0A RID: 76298 RVA: 0x00724530 File Offset: 0x00722730
		public bool vB()
		{
			return this.Ut == 3;
		}

		// Token: 0x06012A0B RID: 76299 RVA: 0x00724548 File Offset: 0x00722748
		public bool vs()
		{
			return this.Ut == 5;
		}

		// Token: 0x06012A0C RID: 76300 RVA: 0x00724560 File Offset: 0x00722760
		public bool vL()
		{
			return this.Ut == 4;
		}

		// Token: 0x06012A0D RID: 76301 RVA: 0x00724578 File Offset: 0x00722778
		public lmr<Eoy> vO(string string_0)
		{
			EEv eev = new EEv();
			lmr<Eoy> lmr = new lmr<Eoy>();
			if (!Eyf.lx(string_0))
			{
				goto IL_005B;
			}
			IL_0014:
			using (lmg<Eoy> lmg = this.lS.O())
			{
				while (lmg.MoveNext())
				{
					Eoy eoy = lmg.Current;
					if (!eev.Contains(eoy.n()))
					{
						lmr.Add(eoy);
					}
				}
				return lmr;
			}
			IL_005B:
			lmr<Eoy> lmr2 = this.Qg.V(string_0);
			if (lmr2 == null)
			{
				goto IL_0014;
			}
			using (lmg<Eoy> lmg = lmr2.O())
			{
				while (lmg.MoveNext())
				{
					Eoy eoy = lmg.Current;
					eev.Add(eoy.n());
					lmr.Add(eoy);
				}
				goto IL_0014;
			}
			return lmr;
		}

		// Token: 0x06012A0E RID: 76302 RVA: 0x00724658 File Offset: 0x00722858
		public Eoy vD(string string_0, string string_1)
		{
			lZh.Q(string_1, "Name", new object[0]);
			Eoy eoy = null;
			if (!Eyf.lx(string_0))
			{
				EEa<Eoy> eea = this.Qt.V(string_0);
				if (eea != null)
				{
					eoy = eea.V(string_1);
				}
			}
			if (eoy == null)
			{
				eoy = this.lc.V(string_1);
			}
			return eoy;
		}

		// Token: 0x06012A0F RID: 76303 RVA: 0x007246B8 File Offset: 0x007228B8
		public lmr<EQZ> vW(string string_0)
		{
			lmr<EQB.rF> lmr = this.LD(string_0);
			lmr<EQZ> lmr2 = new lmr<EQZ>();
			using (lmg<EQZ> lmg = this.lv.O())
			{
				while (lmg.MoveNext())
				{
					EQZ eqz = lmg.Current;
					using (lmg<EQB.rF> lmg2 = lmr.O())
					{
						while (lmg2.MoveNext())
						{
							EQB.rF rF = lmg2.Current;
							if (eqz.x(rF))
							{
								lmr2.Add(eqz);
								break;
							}
						}
					}
				}
			}
			return lmr2;
		}

		// Token: 0x06012A10 RID: 76304 RVA: 0x00724768 File Offset: 0x00722968
		public EQZ vn(string string_0)
		{
			return this.ld.V(string_0);
		}

		// Token: 0x06012A11 RID: 76305 RVA: 0x00724784 File Offset: 0x00722984
		public lmr<EoX> vy()
		{
			return this.lK;
		}

		// Token: 0x06012A12 RID: 76306 RVA: 0x0072479C File Offset: 0x0072299C
		public EoX vi(string string_0)
		{
			return this.lb.V(string_0);
		}

		// Token: 0x06012A13 RID: 76307 RVA: 0x007247B8 File Offset: 0x007229B8
		public lmr<EoX> vG()
		{
			return this.lI;
		}

		// Token: 0x06012A14 RID: 76308 RVA: 0x007247D0 File Offset: 0x007229D0
		public EoX vH(string string_0)
		{
			return this.lJ.V(string_0);
		}

		// Token: 0x06012A15 RID: 76309 RVA: 0x007247EC File Offset: 0x007229EC
		public bool vp()
		{
			using (lmg<EoX> lmg = this.lI.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					if (!EQB.tF.Q(eoX.W()))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06012A16 RID: 76310 RVA: 0x00724854 File Offset: 0x00722A54
		public lmr<EoX> vZ()
		{
			return this.lR;
		}

		// Token: 0x06012A17 RID: 76311 RVA: 0x0072486C File Offset: 0x00722A6C
		public EoX CB(string string_0)
		{
			return this.ln.V(string_0);
		}

		// Token: 0x06012A18 RID: 76312 RVA: 0x00724888 File Offset: 0x00722A88
		public bool Cv(string string_0, string string_1)
		{
			lZh.B(string_1, "Name", new object[0]);
			if (!Eyf.lx(string_0))
			{
				goto IL_0062;
			}
			IL_0019:
			using (lmg<Eom> lmg = this.lH.O())
			{
				while (lmg.MoveNext())
				{
					Eom eom = lmg.Current;
					if (Eyf.hK(eom.E(), string_1))
					{
						return true;
					}
				}
				goto IL_00C1;
			}
			IL_0062:
			lmr<Eom> lmr = this.lO.m(Eyf.Dx(string_0));
			if (lmr == null)
			{
				goto IL_0019;
			}
			using (lmg<Eom> lmg = lmr.O())
			{
				while (lmg.MoveNext())
				{
					Eom eom = lmg.Current;
					if (Eyf.hK(eom.E(), string_1))
					{
						return true;
					}
				}
				goto IL_0019;
			}
			IL_00C1:
			return false;
		}

		// Token: 0x06012A19 RID: 76313 RVA: 0x00724978 File Offset: 0x00722B78
		public lmr<string> CC(string string_0)
		{
			lmr<string> lmr = new lmr<string>();
			if (!Eyf.lx(string_0))
			{
				goto IL_004C;
			}
			IL_000E:
			using (lmg<Eom> lmg = this.lH.O())
			{
				while (lmg.MoveNext())
				{
					Eom eom = lmg.Current;
					lmr.Add(eom.E());
				}
				return lmr;
			}
			IL_004C:
			lmr<Eom> lmr2 = this.lO.m(Eyf.Dx(string_0));
			if (lmr2 == null)
			{
				goto IL_000E;
			}
			using (lmg<Eom> lmg = lmr2.O())
			{
				while (lmg.MoveNext())
				{
					Eom eom = lmg.Current;
					lmr.Add(eom.E());
				}
				goto IL_000E;
			}
			return lmr;
		}

		// Token: 0x06012A1A RID: 76314 RVA: 0x00724A44 File Offset: 0x00722C44
		public Eom Cs(string string_0, string string_1)
		{
			lZh.B(string_1, "Name", new object[0]);
			Eom eom = null;
			if (!Eyf.lx(string_0))
			{
				EEa<Eom> eea = this.lz.m(Eyf.Dx(string_0));
				if (eea != null)
				{
					eom = eea.V(string_1);
				}
			}
			if (eom == null)
			{
				eom = this.lw.V(string_1);
			}
			if (eom == null)
			{
				throw new ENP("GetResourceDef", Eyf.OS("The resource {0} does not exist.", string_1), new object[0]);
			}
			return eom;
		}

		// Token: 0x06012A1B RID: 76315 RVA: 0x00724ACC File Offset: 0x00722CCC
		public lmr<EoD> CL(string string_0)
		{
			HashSet<string> hashSet = new HashSet<string>();
			lmr<EoD> lmr = new lmr<EoD>();
			if (!Eyf.lx(string_0))
			{
				goto IL_005B;
			}
			IL_0014:
			using (lmg<EoD> lmg = this.lx.O())
			{
				while (lmg.MoveNext())
				{
					EoD eoD = lmg.Current;
					if (!hashSet.Contains(eoD.D()))
					{
						lmr.Add(eoD);
					}
				}
				return lmr;
			}
			IL_005B:
			lmr<EoD> lmr2 = this.QU.V(string_0);
			if (lmr2 == null)
			{
				goto IL_0014;
			}
			using (lmg<EoD> lmg = lmr2.O())
			{
				while (lmg.MoveNext())
				{
					EoD eoD = lmg.Current;
					hashSet.Add(eoD.D());
					lmr.Add(eoD);
				}
				goto IL_0014;
			}
			return lmr;
		}

		// Token: 0x06012A1C RID: 76316 RVA: 0x00724BAC File Offset: 0x00722DAC
		public EoD CR(string string_0, string string_1)
		{
			lZh.B(string_1, "Id", new object[0]);
			EoD eoD = null;
			if (!Eyf.lx(string_0))
			{
				lmD<string, EoD> lmD = this.QM.V(string_0);
				if (lmD != null)
				{
					eoD = lmD.m(string_1);
				}
			}
			if (eoD == null)
			{
				eoD = this.lA.m(string_1);
			}
			return eoD;
		}

		// Token: 0x06012A1D RID: 76317 RVA: 0x0009ABDC File Offset: 0x00098DDC
		public virtual bool oJY()
		{
			return false;
		}

		// Token: 0x06012A1E RID: 76318 RVA: 0x00724C0C File Offset: 0x00722E0C
		public int Ck()
		{
			return this.MM;
		}

		// Token: 0x06012A1F RID: 76319 RVA: 0x00724C24 File Offset: 0x00722E24
		public guB CO(bool bool_0)
		{
			if (this.Ml == null)
			{
				if (Eyf.hK(this.MU, "XXXXX"))
				{
					if (this.Ut == 0)
					{
						this.Ml = gPD.G(this.tx, this.p());
					}
				}
				else
				{
					this.Ml = gPD.L(this.MU, this.tx, this.p(), this.Ut == 0);
				}
			}
			guB guB;
			if (this.Ml != null)
			{
				guB = this.Ml.ovP(bool_0);
			}
			else
			{
				guB guB2 = new guB(this.tx, this.MU, this.p(), this.UQ);
				if (!bool_0)
				{
					guB2.ng("No License Handler");
				}
				else
				{
					guB2.nE(new RSBException("PortMetaInfo", "No License Handler"));
				}
				guB2.IE("[NO-LICENSE-HANDLER]");
				guB = guB2;
			}
			return guB;
		}

		// Token: 0x06012A20 RID: 76320 RVA: 0x0009ABDC File Offset: 0x00098DDC
		public bool CD()
		{
			return false;
		}

		// Token: 0x06012A21 RID: 76321 RVA: 0x00724D1C File Offset: 0x00722F1C
		public string CW()
		{
			return this.MU;
		}

		// Token: 0x06012A22 RID: 76322 RVA: 0x00724D34 File Offset: 0x00722F34
		public string CX()
		{
			string text;
			switch (this.Ut)
			{
			case 0:
				text = "Beta";
				break;
			case 1:
				text = "Full";
				break;
			case 2:
				text = "Deprecated";
				break;
			case 3:
				text = "Removed";
				break;
			case 4:
				text = "Uninstall";
				break;
			case 5:
				text = "Unavailable";
				break;
			default:
				text = "Full";
				break;
			}
			return text;
		}

		// Token: 0x06012A23 RID: 76323 RVA: 0x00724DA0 File Offset: 0x00722FA0
		public string Cq()
		{
			return this.My;
		}

		// Token: 0x06012A24 RID: 76324 RVA: 0x0007A2FD File Offset: 0x000784FD
		public void CJ(string string_0)
		{
			this.My = string_0;
		}

		// Token: 0x06012A25 RID: 76325 RVA: 0x00724DB8 File Offset: 0x00722FB8
		public string CM()
		{
			return this.lt;
		}

		// Token: 0x06012A26 RID: 76326 RVA: 0x00724DD0 File Offset: 0x00722FD0
		public string Ca()
		{
			return this.lU;
		}

		// Token: 0x06012A27 RID: 76327 RVA: 0x00724DE8 File Offset: 0x00722FE8
		public bool Cn()
		{
			return this.Uy;
		}

		// Token: 0x06012A28 RID: 76328 RVA: 0x00724DFC File Offset: 0x00722FFC
		public bool CF(string string_0)
		{
			return this.Oa(EQB.rF.j, string_0) || this.Oa(EQB.rF.e, string_0);
		}

		// Token: 0x06012A29 RID: 76329 RVA: 0x00724E20 File Offset: 0x00723020
		public bool Cy(string string_0)
		{
			return this.Oa(EQB.rF.S, string_0);
		}

		// Token: 0x06012A2A RID: 76330 RVA: 0x00724E38 File Offset: 0x00723038
		public bool Ci(string string_0)
		{
			return this.Oa(EQB.rF.g, string_0);
		}

		// Token: 0x06012A2B RID: 76331 RVA: 0x00724E50 File Offset: 0x00723050
		public bool CG(string string_0)
		{
			return this.Oa(EQB.rF.U, string_0);
		}

		// Token: 0x06012A2C RID: 76332 RVA: 0x00724E68 File Offset: 0x00723068
		public bool Ce(string string_0)
		{
			return this.Oa(EQB.rF.j, string_0);
		}

		// Token: 0x06012A2D RID: 76333 RVA: 0x00724E80 File Offset: 0x00723080
		public bool CH(string string_0)
		{
			return this.Oa(EQB.rF.d, string_0);
		}

		// Token: 0x06012A2E RID: 76334 RVA: 0x00724E98 File Offset: 0x00723098
		public bool CT(string string_0)
		{
			return this.Oa(EQB.rF.e, string_0);
		}

		// Token: 0x06012A2F RID: 76335 RVA: 0x00724EB0 File Offset: 0x007230B0
		public bool Cp()
		{
			return this.UU;
		}

		// Token: 0x06012A30 RID: 76336 RVA: 0x00724EC4 File Offset: 0x007230C4
		public bool CU()
		{
			return this.UM;
		}

		// Token: 0x06012A31 RID: 76337 RVA: 0x00724ED8 File Offset: 0x007230D8
		public bool CZ()
		{
			using (lmg<EoX> lmg = this.lK.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					if (Eyf.hK(eoX.fX(), "Settings"))
					{
						return true;
					}
				}
			}
			using (lmg<Eom> lmg2 = this.lH.O())
			{
				while (lmg2.MoveNext())
				{
					Eom eom = lmg2.Current;
					if (Eyf.hK(eom.p(), "UIResources") && Eyf.hK(eom.E(), "settings.rst"))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06012A32 RID: 76338 RVA: 0x00724FB0 File Offset: 0x007231B0
		public bool sB()
		{
			using (lmg<EoX> lmg = this.lK.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					if (Eyf.hK(eoX.fX(), "Advanced"))
					{
						return true;
					}
				}
			}
			using (lmg<Eom> lmg2 = this.lH.O())
			{
				while (lmg2.MoveNext())
				{
					Eom eom = lmg2.Current;
					if (Eyf.hK(eom.p(), "UIResources") && Eyf.hK(eom.E(), "advanced.rst"))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06012A33 RID: 76339 RVA: 0x0009ABDC File Offset: 0x00098DDC
		public bool sv()
		{
			return false;
		}

		// Token: 0x06012A34 RID: 76340 RVA: 0x00725088 File Offset: 0x00723288
		public bool sC(string string_0)
		{
			if (!this.Uv)
			{
				using (lmg<Eom> lmg = this.lH.O())
				{
					while (lmg.MoveNext())
					{
						Eom eom = lmg.Current;
						if (Eyf.hK(eom.p(), "TestData"))
						{
							return true;
						}
					}
					goto IL_0064;
				}
				goto IL_005C;
				IL_0064:
				lmr<string> lmr = new lmr<string>();
				if (Eyf.lx(string_0))
				{
					lyh lyh = Eyf.AS<string, lmr<Eom>>(this.lO);
					while (lyh.MPP())
					{
						string text = (string)lyh.MPX();
						lmr.Add(text);
					}
				}
				else
				{
					lmr.Add(string_0);
				}
				using (lmg<string> lmg2 = lmr.O())
				{
					while (lmg2.MoveNext())
					{
						string text2 = lmg2.Current;
						lmr<Eom> lmr2 = this.lO.m(Eyf.Dx(text2));
						if (lmr2 != null)
						{
							using (lmg<Eom> lmg = lmr2.O())
							{
								while (lmg.MoveNext())
								{
									Eom eom = lmg.Current;
									if (Eyf.hK(eom.p(), "TestData"))
									{
										return true;
									}
								}
							}
						}
					}
				}
				return false;
			}
			IL_005C:
			return true;
		}

		// Token: 0x06012A35 RID: 76341 RVA: 0x007251FC File Offset: 0x007233FC
		public bool ss()
		{
			return this.Un;
		}

		// Token: 0x06012A36 RID: 76342 RVA: 0x0009ABDC File Offset: 0x00098DDC
		public bool sL()
		{
			return false;
		}

		// Token: 0x06012A37 RID: 76343 RVA: 0x0009ABDC File Offset: 0x00098DDC
		public bool sR()
		{
			return false;
		}

		// Token: 0x06012A38 RID: 76344 RVA: 0x000F8BB4 File Offset: 0x000F6DB4
		public string sk()
		{
			return null;
		}

		// Token: 0x06012A39 RID: 76345 RVA: 0x00725210 File Offset: 0x00723410
		public string sO()
		{
			return this.MP;
		}

		// Token: 0x06012A3A RID: 76346 RVA: 0x00725228 File Offset: 0x00723428
		public bool sD()
		{
			return this.US;
		}

		// Token: 0x06012A3B RID: 76347 RVA: 0x0072523C File Offset: 0x0072343C
		public bool sW()
		{
			return this.Ul;
		}

		// Token: 0x06012A3C RID: 76348 RVA: 0x00725250 File Offset: 0x00723450
		public bool sX()
		{
			return this.Uc && (this.CF(EQB.tR) || this.Ci(EQB.tR));
		}

		// Token: 0x06012A3D RID: 76349 RVA: 0x00725284 File Offset: 0x00723484
		public bool sq()
		{
			return this.Ux;
		}

		// Token: 0x06012A3E RID: 76350 RVA: 0x00725298 File Offset: 0x00723498
		public string sJ()
		{
			return this.Ud;
		}

		// Token: 0x06012A3F RID: 76351 RVA: 0x007252B0 File Offset: 0x007234B0
		public lcX sM(string string_0, string string_1)
		{
			lcX lcX;
			try
			{
				if (!Eyf.UK(string_1, "res://", true))
				{
					lcX = new lcv(Eyf.IV(string_1));
				}
				else
				{
					lcX lcX2 = this.tc.obC(lcP.IG(string_1, "res://".Length));
					if (null == lcX2)
					{
						throw new ENP("GetResourceStream", Eyf.OS("The resource {0} does not exist.", string_1), new object[0]);
					}
					lcX = lcX2;
				}
			}
			catch (Egs egs)
			{
				throw new ENP("GetResourceStream", Eyf.eD(egs), egs, new object[0]);
			}
			return lcX;
		}

		// Token: 0x06012A40 RID: 76352 RVA: 0x0072534C File Offset: 0x0072354C
		public bool sa()
		{
			return this.UP;
		}

		// Token: 0x06012A41 RID: 76353 RVA: 0x00725360 File Offset: 0x00723560
		public void sn(string string_0, string string_1, string string_2, string string_3)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			lZh.B(string_1, "Name", new object[0]);
			lZh.B(string_3, "ResourceType", new object[0]);
			lmr<Eom> lmr = this.lO.m(Eyf.Dx(string_0));
			EEa<Eom> eea = this.lz.m(Eyf.Dx(string_0));
			if (lmr == null)
			{
				lmr = new lmr<Eom>();
				this.lO.H(Eyf.Dx(string_0), lmr);
				eea = null;
			}
			if (eea == null)
			{
				eea = new EEa<Eom>();
				this.lz.H(Eyf.Dx(string_0), eea);
			}
			int num = -1;
			for (int i = 0; i < lmr.G(); i++)
			{
				Eom eom = lmr.y(i);
				if (Eyf.hK(eom.E(), string_1))
				{
					num = i;
				}
			}
			if (!Eyf.lx(string_2))
			{
				Eom eom2 = new Eom(string_1, string_2, string_3);
				if (num <= -1)
				{
					lmr.Add(eom2);
					eea.n(string_1, eom2);
				}
				else
				{
					lmr.i(num, eom2);
					eea.n(string_1, eom2);
				}
			}
			else if (num > -1)
			{
				lmr.xk(num);
				eea.L(string_1);
			}
		}

		// Token: 0x06012A42 RID: 76354 RVA: 0x007254A4 File Offset: 0x007236A4
		public string sF()
		{
			return this.UK;
		}

		// Token: 0x06012A43 RID: 76355 RVA: 0x007254BC File Offset: 0x007236BC
		public bool sy()
		{
			return this.lR.G() > 0;
		}

		// Token: 0x06012A44 RID: 76356 RVA: 0x007254D8 File Offset: 0x007236D8
		public string si()
		{
			return this.Ub;
		}

		// Token: 0x06012A45 RID: 76357 RVA: 0x007254F0 File Offset: 0x007236F0
		public string sG()
		{
			return this.Ue;
		}

		// Token: 0x06012A46 RID: 76358 RVA: 0x00725508 File Offset: 0x00723708
		public string se()
		{
			return this.UI;
		}

		// Token: 0x06012A47 RID: 76359 RVA: 0x00725520 File Offset: 0x00723720
		public string sH()
		{
			return this.UJ;
		}

		// Token: 0x06012A48 RID: 76360 RVA: 0x00725538 File Offset: 0x00723738
		public string sT()
		{
			return this.UH;
		}

		// Token: 0x06012A49 RID: 76361 RVA: 0x00725550 File Offset: 0x00723750
		public string[] sp()
		{
			return Eyf.Ow(this.Uw);
		}

		// Token: 0x06012A4A RID: 76362 RVA: 0x0072556C File Offset: 0x0072376C
		public string[] sU()
		{
			return Eyf.Ow(this.UR);
		}

		// Token: 0x06012A4B RID: 76363 RVA: 0x00725588 File Offset: 0x00723788
		public int sZ()
		{
			return this.UO;
		}

		// Token: 0x06012A4C RID: 76364 RVA: 0x007255A0 File Offset: 0x007237A0
		public bool LB()
		{
			return this.MQ;
		}

		// Token: 0x06012A4D RID: 76365 RVA: 0x007255B4 File Offset: 0x007237B4
		public string Lv()
		{
			return this.Uz;
		}

		// Token: 0x06012A4E RID: 76366 RVA: 0x007255CC File Offset: 0x007237CC
		public string LC()
		{
			return this.Mg;
		}

		// Token: 0x06012A4F RID: 76367 RVA: 0x007255E4 File Offset: 0x007237E4
		public int Ls()
		{
			return this.UA;
		}

		// Token: 0x06012A50 RID: 76368 RVA: 0x007255FC File Offset: 0x007237FC
		public string LL()
		{
			string text;
			if (this.MR == null)
			{
				text = null;
			}
			else
			{
				text = this.MR.W();
			}
			return text;
		}

		// Token: 0x06012A51 RID: 76369 RVA: 0x00725628 File Offset: 0x00723828
		public string LR()
		{
			string text;
			if (this.Mn == null)
			{
				text = null;
			}
			else
			{
				text = this.Mn.W();
			}
			return text;
		}

		// Token: 0x06012A52 RID: 76370 RVA: 0x00725654 File Offset: 0x00723854
		public string[] Lk()
		{
			string[] array;
			if (this.MR == null)
			{
				array = null;
			}
			else
			{
				array = Eyf.xD(this.MR.fV("Options"), true, ',', true, true);
			}
			return array;
		}

		// Token: 0x06012A53 RID: 76371 RVA: 0x0072568C File Offset: 0x0072388C
		public string LO()
		{
			string text;
			if (this.MR == null)
			{
				text = null;
			}
			else
			{
				text = this.MR.V();
			}
			return text;
		}

		// Token: 0x06012A54 RID: 76372 RVA: 0x007256B8 File Offset: 0x007238B8
		public lmr<EQB.rF> LD(string string_0)
		{
			lmr<EQB.rF> lmr = new lmr<EQB.rF>();
			if (!EQB.tR.Equals(string_0) && this.MR != null)
			{
				if (!Eyf.lx(string_0))
				{
					if (Eyf.lx(this.MR.fV("MultiSelect")) || !bool.Parse(this.MR.fV("MultiSelect")))
					{
						lmr = this.MS.V(string_0);
					}
					else
					{
						lmr = new lmr<EQB.rF>();
						string[] array = Eyf.xD(string_0, true, ',', true, true);
						if (array != null)
						{
							foreach (string text in array)
							{
								lmr<EQB.rF> lmr2 = this.MS.V(text);
								if (lmr2 != null)
								{
									lmr.r(lmr2);
								}
							}
						}
					}
				}
			}
			else
			{
				lmr = this.tz;
			}
			return lmr;
		}

		// Token: 0x06012A55 RID: 76373 RVA: 0x007257A0 File Offset: 0x007239A0
		public lmr<EQB.rF> LW()
		{
			return this.tz;
		}

		// Token: 0x06012A56 RID: 76374 RVA: 0x007257B8 File Offset: 0x007239B8
		public string LX(string string_0)
		{
			return this.MR.fV("OptionName[" + string_0 + "]");
		}

		// Token: 0x06012A57 RID: 76375 RVA: 0x007257E4 File Offset: 0x007239E4
		public string Lq(string string_0)
		{
			return this.MR.fV("OptionDesc[" + string_0 + "]");
		}

		// Token: 0x06012A58 RID: 76376 RVA: 0x00725810 File Offset: 0x00723A10
		public bool LJ(string string_0)
		{
			string text = this.MR.fV("OptionHidden[" + string_0 + "]");
			return !Eyf.lx(text) && bool.Parse(text);
		}

		// Token: 0x06012A59 RID: 76377 RVA: 0x00725850 File Offset: 0x00723A50
		public string LM()
		{
			return this.Mt;
		}

		// Token: 0x06012A5A RID: 76378 RVA: 0x00725868 File Offset: 0x00723A68
		public void La(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			lZh.Q(string_1, "Name", new object[0]);
			EEa<Eoy> eea = this.Qt.V(string_0);
			lmr<Eoy> lmr = this.Qg.V(string_0);
			if (eea == null)
			{
				eea = new EEa<Eoy>();
				this.Qt.n(string_0, eea);
			}
			if (lmr == null)
			{
				lmr = new lmr<Eoy>();
				this.Qg.n(string_0, lmr);
			}
			if (eea.Q(string_1))
			{
				throw new ENP("ConnectorPrototype", "The output {0} already exists.", new object[] { string_1 });
			}
			if (!EQB.DU(string_4))
			{
				throw new ENP("ConnectorPrototype", "Invalid Output label: {0}.", new object[] { string_4 });
			}
			Eoy eoy = new Eoy();
			eoy.L(string_1);
			eoy.E(string_2);
			eoy.Q(string_3);
			eoy.y(string_4);
			eoy.W(EQB.DG(string_5));
			lmr.Add(eoy);
			eea.n(string_1, eoy);
		}

		// Token: 0x06012A5B RID: 76379 RVA: 0x0007A306 File Offset: 0x00078506
		public void Ln(string string_0)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			this.Qt.L(string_0);
			this.Qg.L(string_0);
		}

		// Token: 0x06012A5C RID: 76380 RVA: 0x00725984 File Offset: 0x00723B84
		public int LF(string string_0)
		{
			if (!Eyf.lx(string_0))
			{
				EQB.rC rC = this.Ql.V(string_0);
				if (rC != null)
				{
					return rC.s;
				}
			}
			return this.Me;
		}

		// Token: 0x06012A5D RID: 76381 RVA: 0x007259C0 File Offset: 0x00723BC0
		public void Ly(string string_0, string string_1, int int_0, lmD<string, string> lmD_0, string string_2)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			lmD<string, EoD> lmD = this.QM.V(string_0);
			lmr<EoD> lmr = this.QU.V(string_0);
			if (lmD == null)
			{
				lmD = new lmD<string, EoD>();
				this.QM.n(string_0, lmD);
			}
			if (lmr == null)
			{
				lmr = new lmr<EoD>();
				this.QU.n(string_0, lmr);
			}
			if (!lmD.ContainsKey(string_1))
			{
				EoD eoD = new EoD(string_1);
				eoD.A(int_0);
				if (lmD_0 != null)
				{
					lyh lyh = Eyf.AS<string, string>(lmD_0);
					while (lyh.MPP())
					{
						string text = (string)lyh.MPX();
						string text2 = lmD_0.m(text);
						eoD.V(text, text2);
					}
				}
				eoD.E(EQB.DG(string_2));
				lmr.Add(eoD);
				lmD.H(string_1, eoD);
				return;
			}
			throw new ENP("ConnectorPrototype", "The flow extension {0} already exists.", new object[] { string_1 });
		}

		// Token: 0x06012A5E RID: 76382 RVA: 0x0007A331 File Offset: 0x00078531
		public void Li(string string_0)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			this.QM.L(string_0);
			this.QU.L(string_0);
		}

		// Token: 0x06012A5F RID: 76383 RVA: 0x00725AC8 File Offset: 0x00723CC8
		public void LG(string string_0, int int_0)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			if (int_0 != 0 && int_0 != 1)
			{
				throw new ENP("SetInstanceFlowUIStyle", "Unknown FlowUiStyle {0}.", new object[] { Eyf.Dt(int_0) });
			}
			this.Ql.n(string_0, new EQB.rC(int_0));
		}

		// Token: 0x06012A60 RID: 76384 RVA: 0x0007A35C File Offset: 0x0007855C
		public void Le(string string_0)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			this.Ql.L(string_0);
		}

		// Token: 0x06012A61 RID: 76385 RVA: 0x00725B28 File Offset: 0x00723D28
		public int LH()
		{
			return this.Mc;
		}

		// Token: 0x06012A62 RID: 76386 RVA: 0x00725B40 File Offset: 0x00723D40
		public string[] LT()
		{
			return this.Mx;
		}

		// Token: 0x06012A63 RID: 76387 RVA: 0x00725B58 File Offset: 0x00723D58
		public string[] Lp()
		{
			return this.MA;
		}

		// Token: 0x06012A64 RID: 76388 RVA: 0x00725B70 File Offset: 0x00723D70
		public bool LU()
		{
			return this.MO;
		}

		// Token: 0x06012A65 RID: 76389 RVA: 0x00725B84 File Offset: 0x00723D84
		public string LZ()
		{
			return this.Mz;
		}

		// Token: 0x06012A66 RID: 76390 RVA: 0x00725B9C File Offset: 0x00723D9C
		public string RB()
		{
			return this.lg;
		}

		// Token: 0x06012A67 RID: 76391 RVA: 0x00725BB4 File Offset: 0x00723DB4
		public lmr<EQk> Rs(string string_0)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			lmr<EQk> lmr = new lmr<EQk>();
			lmr<EQk> lmr2 = this.QQ.V(string_0);
			if (lmr2 != null)
			{
				using (lmg<EQk> lmg = lmr2.O())
				{
					while (lmg.MoveNext())
					{
						EQk eqk = lmg.Current;
						EQk eqk2 = new EQk();
						eqk2.L(eqk);
						lmr.Add(eqk2);
					}
				}
			}
			return lmr;
		}

		// Token: 0x06012A68 RID: 76392 RVA: 0x00725C44 File Offset: 0x00723E44
		public void RL(string string_0, string string_1, string string_2, string string_3, string string_4)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			lmr<EQk> lmr = this.QQ.V(string_0);
			if (lmr == null)
			{
				lmr = new lmr<EQk>();
				this.QQ.n(string_0, lmr);
			}
			EQk eqk = new EQk();
			eqk.W(string_1);
			eqk.y(string_2);
			eqk.s(string_3);
			eqk.n(string_4);
			lmr.Add(eqk);
		}

		// Token: 0x06012A69 RID: 76393 RVA: 0x0007A37B File Offset: 0x0007857B
		public void RO(string string_0)
		{
			lZh.B(string_0, "ConnectorId", new object[0]);
			this.QQ.L(string_0);
		}

		// Token: 0x06012A6A RID: 76394 RVA: 0x00725CB8 File Offset: 0x00723EB8
		public int RD()
		{
			return this.lM;
		}

		// Token: 0x06012A6B RID: 76395 RVA: 0x0007A39A File Offset: 0x0007859A
		public void RW(int int_0)
		{
			this.lM = int_0;
		}

		// Token: 0x06012A6C RID: 76396 RVA: 0x00725CD0 File Offset: 0x00723ED0
		public bool Rn()
		{
			return this.lQ;
		}

		// Token: 0x06012A6D RID: 76397 RVA: 0x00725CE4 File Offset: 0x00723EE4
		public bool Ry()
		{
			return this.ll;
		}

		// Token: 0x06012A6E RID: 76398 RVA: 0x00725CF8 File Offset: 0x00723EF8
		public lmr<string> Ri()
		{
			return this.lP;
		}

		// Token: 0x06012A6F RID: 76399 RVA: 0x00725D10 File Offset: 0x00723F10
		public bool RG()
		{
			return this.ly;
		}

		// Token: 0x06012A70 RID: 76400 RVA: 0x0007A3A3 File Offset: 0x000785A3
		private void RH(int int_0)
		{
			this.tO = int_0;
		}

		// Token: 0x06012A71 RID: 76401 RVA: 0x0007A3AC File Offset: 0x000785AC
		private void Rp(string string_0)
		{
			this.tz.Clear();
			this.tz.r(EQB.DZ(string_0));
		}

		// Token: 0x06012A72 RID: 76402 RVA: 0x0007A3CA File Offset: 0x000785CA
		private void RZ(int int_0)
		{
			this.Ut = int_0;
		}

		// Token: 0x06012A73 RID: 76403 RVA: 0x0007A3D3 File Offset: 0x000785D3
		private void kB(bool bool_0)
		{
			this.UU = bool_0;
		}

		// Token: 0x06012A74 RID: 76404 RVA: 0x0007A3DC File Offset: 0x000785DC
		private void ks(bool bool_0)
		{
			this.UM = bool_0;
		}

		// Token: 0x06012A75 RID: 76405 RVA: 0x0007A3E5 File Offset: 0x000785E5
		private void kL(string string_0)
		{
			this.UQ = string_0;
		}

		// Token: 0x06012A76 RID: 76406 RVA: 0x0007A3EE File Offset: 0x000785EE
		private void kO(bool bool_0)
		{
			this.Uy = bool_0;
		}

		// Token: 0x06012A77 RID: 76407 RVA: 0x0007A3F7 File Offset: 0x000785F7
		private void kD(string string_0)
		{
			this.MU = string_0;
		}

		// Token: 0x06012A78 RID: 76408 RVA: 0x0007A400 File Offset: 0x00078600
		private void kW(int int_0)
		{
			this.MM = int_0;
		}

		// Token: 0x06012A79 RID: 76409 RVA: 0x0007A409 File Offset: 0x00078609
		private void kn(bool bool_0)
		{
			this.UP = bool_0;
		}

		// Token: 0x06012A7A RID: 76410 RVA: 0x0007A412 File Offset: 0x00078612
		private void ky(string string_0)
		{
			this.UK = string_0;
		}

		// Token: 0x06012A7B RID: 76411 RVA: 0x0007A41B File Offset: 0x0007861B
		private void ki(string string_0)
		{
			this.Ub = string_0;
		}

		// Token: 0x06012A7C RID: 76412 RVA: 0x0007A424 File Offset: 0x00078624
		private void kG(string string_0)
		{
			this.Ue = string_0;
		}

		// Token: 0x06012A7D RID: 76413 RVA: 0x0007A42D File Offset: 0x0007862D
		private void kH(string string_0)
		{
			this.UI = string_0;
		}

		// Token: 0x06012A7E RID: 76414 RVA: 0x0007A436 File Offset: 0x00078636
		private void kp(string string_0)
		{
			this.UJ = string_0;
		}

		// Token: 0x06012A7F RID: 76415 RVA: 0x0007A43F File Offset: 0x0007863F
		private void kZ(string string_0)
		{
			this.UH = string_0;
		}

		// Token: 0x06012A80 RID: 76416 RVA: 0x0007A448 File Offset: 0x00078648
		private void OB(bool bool_0)
		{
			this.Un = bool_0;
		}

		// Token: 0x06012A81 RID: 76417 RVA: 0x0007A451 File Offset: 0x00078651
		private void Ov(bool bool_0)
		{
			this.US = bool_0;
		}

		// Token: 0x06012A82 RID: 76418 RVA: 0x0007A45A File Offset: 0x0007865A
		private void OC(bool bool_0)
		{
			this.Uc = bool_0;
		}

		// Token: 0x06012A83 RID: 76419 RVA: 0x0007A463 File Offset: 0x00078663
		private void Os(bool bool_0)
		{
			this.Ux = bool_0;
		}

		// Token: 0x06012A84 RID: 76420 RVA: 0x0007A46C File Offset: 0x0007866C
		private void OL(int int_0)
		{
			this.UO = int_0;
		}

		// Token: 0x06012A85 RID: 76421 RVA: 0x00725D24 File Offset: 0x00723F24
		private void OR(string string_0, string string_1, string string_2)
		{
			lmr<EQB.ri> lmr = this.lF.V(string_0);
			if (lmr == null)
			{
				lmr = new lmr<EQB.ri>();
				this.lF.n(string_0, lmr);
			}
			lmr.Add(new EQB.ri(string_1, string_2));
		}

		// Token: 0x06012A86 RID: 76422 RVA: 0x0007A475 File Offset: 0x00078675
		public void Ok(bool bool_0)
		{
			this.MQ = bool_0;
		}

		// Token: 0x06012A87 RID: 76423 RVA: 0x0007A47E File Offset: 0x0007867E
		private void OO(string string_0)
		{
			this.Uz = string_0;
		}

		// Token: 0x06012A88 RID: 76424 RVA: 0x0007A487 File Offset: 0x00078687
		private void OD(string string_0)
		{
			this.Mg = string_0;
		}

		// Token: 0x06012A89 RID: 76425 RVA: 0x0007A490 File Offset: 0x00078690
		private void OW(int int_0)
		{
			this.UA = int_0;
		}

		// Token: 0x06012A8A RID: 76426 RVA: 0x0007A499 File Offset: 0x00078699
		private void OX(string string_0)
		{
			this.MP = string_0;
		}

		// Token: 0x06012A8B RID: 76427 RVA: 0x0007A4A2 File Offset: 0x000786A2
		private void Oq(int int_0)
		{
			this.Me = int_0;
		}

		// Token: 0x06012A8C RID: 76428 RVA: 0x0007A4AB File Offset: 0x000786AB
		private void OJ(string string_0)
		{
			this.Mx = Eyf.xV(string_0, true, ",", true);
		}

		// Token: 0x06012A8D RID: 76429 RVA: 0x0007A4C0 File Offset: 0x000786C0
		private void OM(string string_0)
		{
			this.MA = Eyf.xV(string_0, true, ",", true);
		}

		// Token: 0x06012A8E RID: 76430 RVA: 0x00725D68 File Offset: 0x00723F68
		private bool Oa(EQB.rF rF_0, string string_0)
		{
			lmr<EQB.rF> lmr = this.LD(string_0);
			bool flag;
			if (lmr != null)
			{
				using (lmg<EQB.rF> lmg = lmr.O())
				{
					while (lmg.MoveNext())
					{
						EQB.rF rF = lmg.Current;
						if (rF == rF_0)
						{
							return true;
						}
					}
					goto IL_000E;
				}
				return flag;
			}
			IL_000E:
			flag = false;
			return flag;
		}

		// Token: 0x06012A8F RID: 76431 RVA: 0x00725DD4 File Offset: 0x00723FD4
		private void On(string string_0)
		{
			this.lP.Clear();
			if (!Eyf.lx(string_0))
			{
				this.lP.r(Eyf.Ox(Eyf.xD(string_0, true, ',', true, true)));
			}
		}

		// Token: 0x06012A90 RID: 76432 RVA: 0x00725E14 File Offset: 0x00724014
		private void OF()
		{
			rga rga = rga.Fu("application", "arc.core.connector");
			rga.kr(Eyf.OS("Starting init connector type: {0}.", this.tc.oJd()), this.tc.oJd());
			EQr eqr = this.tc.oJR(this);
			string[] array = new string[1];
			string[] array2 = array;
			array = new string[1];
			string[] array3 = array;
			array = new string[1];
			string[] array4 = array;
			array = new string[1];
			string[] array5 = array;
			array = new string[1];
			string[] array6 = array;
			eqr.olk(array2, array3, array4, array5, array6);
			if (!Eyf.lx(array3[0]))
			{
				this.tx = array3[0];
				this.Ug = array2[0];
				this.tA = array4[0];
				if (!this.Rn() && !this.RG())
				{
					if (this.MR == null)
					{
						this.Rp(array5[0]);
					}
					if (this.tz.G() <= 0)
					{
						throw new ENP("ConnectorPrototype", "No operation in the type {0}.", new object[] { this.tx });
					}
					if (this.lS.G() <= 0 && !Eyf.lx(array6[0]))
					{
						foreach (string text in Eyf.xD(array6[0], true, ',', true, true))
						{
							this.Oe(text, "", "", "", "");
						}
					}
					try
					{
						EQB.DM(this);
					}
					catch (Exception ex)
					{
						rga.kQ(Eyf.OS("Unable to initial common outputs for the connector type {0}", this.tx), ex, "ConnectorPrototype");
					}
					try
					{
						EQB.Dn(this);
					}
					catch (Exception ex)
					{
						rga.kQ(Eyf.OS("Unable to initial common settings for the connector type {0}", this.tx), ex, "ConnectorPrototype");
					}
					try
					{
						EQB.DH(this);
					}
					catch (Exception ex)
					{
						rga.kQ(Eyf.OS("Unable to initial common settings for the connector type {0}", this.tx), ex, "ConnectorPrototype");
					}
					try
					{
						EQB.DT(this);
					}
					catch (Exception ex)
					{
						rga.kQ(Eyf.OS("Unable to initial common settings for the connector type {0}", this.tx), ex, "ConnectorPrototype");
					}
					rga.kr(Eyf.OS("Connector type is: {0}.", this.tx), this.tc.oJd());
					if (this.lR.G() > 0)
					{
						bool flag = false;
						using (lmg<EoX> lmg = this.lK.O())
						{
							while (lmg.MoveNext())
							{
								EoX eoX = lmg.Current;
								if (eoX.K() == 8)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							this.oJw("ConnectionName", "", 8, null, "Settings", "Configuration", null, false, "");
						}
					}
					string text2 = ghD.j(ghD.j("connector", "settingdefs"), Eyf.Dx(this.tx));
					if (giw.wr(text2))
					{
						lmr<string> lmr = giw.wm(text2);
						using (lmg<string> lmg2 = lmr.O())
						{
							while (lmg2.MoveNext())
							{
								string text3 = lmg2.Current;
								string text4 = giw.wc(text2, text3);
								try
								{
									EoX eoX2 = EoX.fg(text4);
									if (eoX2 != null)
									{
										bool flag2 = false;
										EoX eoX = this.lb.V(text3);
										if (eoX == null)
										{
											eoX = this.ln.V(text3);
											flag2 = eoX != null;
										}
										if (eoX != null)
										{
											lmr<EoX> lmr2 = ((!flag2) ? this.lK : this.lR);
											EEa<EoX> eea = ((!flag2) ? this.lb : this.ln);
											int num = lmr2.IndexOf(eoX);
											if (num < 0)
											{
												eoX = eoX2;
												lmr2.Add(eoX);
											}
											else
											{
												eoX = EoX.fj(eoX, eoX2);
												lmr2.i(num, eoX);
											}
											eea.n(eoX2.W(), eoX);
										}
									}
								}
								catch (Exception ex)
								{
									throw new ENP("ConnectorPrototype", "Unable to parse Global Setting for Connector {0}: {1}={2}.", ex, new object[] { this.tx, text3, text4 });
								}
							}
							goto IL_020E;
						}
						return;
					}
					IL_020E:
					rga.kr(Eyf.OS("Finish init connector type: {0}", this.tc.oJd()), this.tc.oJd());
				}
				return;
			}
			throw new ENP("ConnectorPrototype", "Invalid Connector type name: {0}.", new object[] { array3[0] });
		}

		// Token: 0x06012A91 RID: 76433 RVA: 0x00726388 File Offset: 0x00724588
		private void Oy(string string_0, string string_1, EQB.rF[] rF_0)
		{
			lZh.B(string_0, "Name", new object[0]);
			using (lmg<EQZ> lmg = this.lv.O())
			{
				while (lmg.MoveNext())
				{
					EQZ eqz = lmg.Current;
					if (Eyf.hK(eqz.r(), string_0))
					{
						throw new ENP("ConnectorPrototype", "The setting {0} already exists.", new object[] { string_0 });
					}
				}
			}
			EQZ eqz2 = new EQZ(string_0, string_1, rF_0);
			this.lv.Add(eqz2);
			this.ld.n(string_0, eqz2);
		}

		// Token: 0x06012A92 RID: 76434 RVA: 0x00726438 File Offset: 0x00724638
		private static EoX Oi(EoX eoX_0)
		{
			lmD<string, string> lmD = EQB.DG("CertificatePassword=true,PGPKeyPasswordConfig=true");
			using (lmg<string> lmg = eoX_0.ff().O())
			{
				while (lmg.MoveNext())
				{
					string text = lmg.Current;
					if (!Eyf.hK(text, "CustomUI") && !Eyf.hK(text, "CertPasswordConfig") && !Eyf.hK(text, "CertSubjectConfig") && !Eyf.hK(text, "PGPKeyPasswordConfig"))
					{
						lmD.H(text, eoX_0.fV(text));
					}
				}
			}
			return new EoX(Eyf.UO(eoX_0.fV("CertPasswordConfig"), eoX_0.fV("PGPKeyPasswordConfig")), 1, Eyf.OS("{0} Password", eoX_0.p()), eoX_0.fX(), eoX_0.A(), Eyf.OS("The password of {0}", eoX_0.p()), "", lmD);
		}

		// Token: 0x06012A93 RID: 76435 RVA: 0x0072652C File Offset: 0x0072472C
		public int oJP()
		{
			return this.lv.G();
		}

		// Token: 0x06012A94 RID: 76436 RVA: 0x00726548 File Offset: 0x00724748
		public EQZ oJI(int int_0)
		{
			return this.lv.y(int_0);
		}

		// Token: 0x06012A95 RID: 76437 RVA: 0x0007A4D5 File Offset: 0x000786D5
		public void oJq(string string_0, string string_1)
		{
			this.Oy(string_0, string_1, null);
		}

		// Token: 0x06012A96 RID: 76438 RVA: 0x00726564 File Offset: 0x00724764
		public void OG(string string_0, int int_0, lmD<string, string> lmD_0, string string_1)
		{
			if (!this.lA.ContainsKey(string_0))
			{
				EoD eoD = new EoD(string_0);
				eoD.A(int_0);
				if (lmD_0 != null)
				{
					lyh lyh = Eyf.AS<string, string>(lmD_0);
					while (lyh.MPP())
					{
						string text = (string)lyh.MPX();
						string text2 = lmD_0.m(text);
						eoD.V(text, text2);
					}
				}
				eoD.E(EQB.DG(string_1));
				this.lx.Add(eoD);
				this.lA.H(string_0, eoD);
				return;
			}
			throw new ENP("ConnectorPrototype", "The flow extension {0} already exists.", new object[] { string_0 });
		}

		// Token: 0x06012A97 RID: 76439 RVA: 0x0072660C File Offset: 0x0072480C
		public void Oe(string string_0, string string_1, string string_2, string string_3, string string_4)
		{
			lZh.Q(string_0, "Name", new object[0]);
			if (this.lc.Q(string_0))
			{
				throw new ENP("ConnectorPrototype", "The output {0} already exists.", new object[] { string_0 });
			}
			if (!EQB.DU(string_3))
			{
				throw new ENP("ConnectorPrototype", "Invalid Output label: {0}.", new object[] { string_3 });
			}
			Eoy eoy = new Eoy();
			eoy.L(string_0);
			eoy.E(string_1);
			eoy.Q(string_2);
			eoy.y(string_3);
			eoy.W(EQB.DG(string_4));
			this.lS.Add(eoy);
			this.lc.n(string_0, eoy);
		}

		// Token: 0x06012A98 RID: 76440 RVA: 0x007266C8 File Offset: 0x007248C8
		public void oJN(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, string string_5)
		{
			lZh.B(string_0, "Name", new object[0]);
			using (lmg<EoX> lmg = this.lI.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					if (Eyf.hK(eoX.W(), string_0))
					{
						throw new ENP("ConnectorPrototype", "The setting {0} already exists.", new object[] { string_0 });
					}
				}
			}
			lmD<string, string> lmD = EQB.DG(string_5);
			string text = ghD.j(ghD.j("profile", "settingdefs"), "*");
			if (giw.wr(text))
			{
				string text2 = Eyf.Dx(string_0);
				if (giw.wp(text, text2))
				{
					string text3 = giw.wc(text, text2);
					try
					{
						EoX eoX2 = EoX.fg(text3);
						if (eoX2 != null)
						{
							int_0 = eoX2.K();
							if (!Eyf.lx(eoX2.V()))
							{
								string_2 = eoX2.V();
							}
							lmD<string, string> lmD2 = eoX2.fc();
							lyh lyh = Eyf.AS<string, string>(lmD2);
							while (lyh.MPP())
							{
								string text4 = (string)lyh.MPX();
								lmD.H(text4, lmD2.m(text4));
							}
						}
						goto IL_00A2;
					}
					catch (Exception ex)
					{
						throw new ENP("ConnectorPrototype", "Unable to parse Global Setting for Connector: {0}={1}.", ex, new object[] { text2, text3 });
					}
					goto IL_01AC;
				}
			}
			IL_00A2:
			EoX eoX3 = new EoX(string_0, int_0, string_4, null, string_3, string_1, string_2, lmD);
			this.lI.Add(eoX3);
			this.lJ.n(string_0, eoX3);
			if (int_0 == 4)
			{
				goto IL_01AC;
			}
			IL_00D8:
			bool flag = int_0 != 15 || Eyf.lx(eoX3.fV("PGPKeyPasswordConfig"));
			IL_00E3:
			if (!flag)
			{
				EoX eoX4 = EQB.Oi(eoX3);
				this.lI.Add(eoX4);
				this.lJ.n(eoX4.W(), eoX4);
			}
			return;
			IL_01AC:
			if (!Eyf.lx(eoX3.fV("CertPasswordConfig")))
			{
				flag = false;
				goto IL_00E3;
			}
			goto IL_00D8;
		}

		// Token: 0x06012A99 RID: 76441 RVA: 0x007268FC File Offset: 0x00724AFC
		public void oJw(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, string string_5, bool bool_0, string string_6)
		{
			lZh.B(string_0, "Name", new object[0]);
			using (lmg<EoX> lmg = this.lK.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					if (Eyf.hK(eoX.W(), string_0))
					{
						throw new ENP("ConnectorPrototype", "The setting {0} already exists.", new object[] { string_0 });
					}
					if (int_0 == 8 && eoX.K() == 8)
					{
						throw new ENP("ConnectorPrototype", "There is a SharedConnectionName setting {0} exists already.", new object[] { string_0 });
					}
					if (int_0 == 12 && eoX.K() == 12)
					{
						throw new ENP("ConnectorPrototype", "There is a Action setting {0} exists already.", new object[] { string_0 });
					}
				}
			}
			using (lmg<EoX> lmg = this.lR.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					if (Eyf.hK(eoX.W(), string_0))
					{
						throw new ENP("ConnectorPrototype", "The setting {0} already exists.", new object[] { string_0 });
					}
				}
			}
			if ((Eyf.hK(string_0, "SaveToSentFolder") || Eyf.hK(string_0, "SentFolderScheme")) && giw.wp(ghD.j("profile", "application"), "disablesavetosentfolder") && Eyf.CZ(giw.wc(ghD.j("profile", "application"), "disablesavetosentfolder"), true))
			{
				string_3 = null;
				string_4 = null;
			}
			lmD<string, string> lmD = EQB.DG(string_6);
			string text = ghD.j(ghD.j("connector", "settingdefs"), "*");
			if (giw.wr(text))
			{
				if (lmD.ContainsKey("CertIncludeAny"))
				{
					goto IL_0351;
				}
				bool flag = true;
				IL_028A:
				if (!flag && Eyf.CZ(giw.wc(text, "certdisallowacceptany"), false))
				{
					lmD.H("CertIncludeAny", "Strict");
				}
				string text2 = Eyf.Dx(string_0);
				if (!giw.wp(text, text2))
				{
					goto IL_0190;
				}
				string text3 = giw.wc(text, text2);
				try
				{
					EoX eoX2 = EoX.fg(text3);
					if (eoX2 != null)
					{
						int_0 = eoX2.K();
						if (!Eyf.lx(eoX2.V()))
						{
							string_2 = eoX2.V();
						}
						lmD<string, string> lmD2 = eoX2.fc();
						lyh lyh = Eyf.AS<string, string>(lmD2);
						while (lyh.MPP())
						{
							string text4 = (string)lyh.MPX();
							lmD.H(text4, lmD2.m(text4));
						}
					}
					goto IL_0190;
				}
				catch (Exception ex)
				{
					throw new ENP("ConnectorPrototype", "Unable to parse Global Setting for Connector: {0}={1}.", ex, new object[] { text2, text3 });
				}
				IL_0351:
				flag = !giw.wp(text, "certdisallowacceptany");
				goto IL_028A;
			}
			IL_0190:
			EoX eoX3 = new EoX(string_0, int_0, string_5, string_3, string_4, string_1, string_2, lmD);
			if (!bool_0 && !Eyf.CZ(eoX3.fV("Connection"), false))
			{
				if (!Eyf.CZ(eoX3.fV("Override"), false))
				{
					this.lK.Add(eoX3);
					this.lb.n(string_0, eoX3);
					if (int_0 != 8)
					{
						if (int_0 != 12)
						{
							if (int_0 == 4 && !Eyf.lx(eoX3.fV("CertPasswordConfig")))
							{
								EoX eoX4 = EQB.Oi(eoX3);
								this.lK.Add(eoX4);
								this.lb.n(eoX4.W(), eoX4);
							}
						}
						else
						{
							this.MR = eoX3;
							this.tz.Clear();
							string[] array = Eyf.xD(this.MR.fV("Options"), true, ',', true, true);
							if (array != null)
							{
								foreach (string text5 in array)
								{
									string text6 = Eyf.Dx("OptionOperation[" + text5 + "]");
									string text7 = this.MR.fV(text6);
									if (!Eyf.lx(text7))
									{
										lmr<EQB.rF> lmr = EQB.DZ(text7);
										this.MS.n(text5, lmr);
										this.tz.r(lmr);
									}
								}
							}
						}
					}
					else
					{
						this.Mn = eoX3;
					}
				}
				else
				{
					eoX3.fy("Override");
					this.le.n(string_0, eoX3);
				}
			}
			else
			{
				this.lR.Add(eoX3);
				this.ln.n(string_0, eoX3);
				if (int_0 == 4 && !Eyf.lx(eoX3.fV("CertPasswordConfig")))
				{
					EoX eoX4 = EQB.Oi(eoX3);
					this.lR.Add(eoX4);
					this.ln.n(eoX4.W(), eoX4);
				}
			}
		}

		// Token: 0x06012A9A RID: 76442 RVA: 0x00726E68 File Offset: 0x00725068
		public string oJe(string string_0)
		{
			gik gik = new gik(string_0);
			if (!gik.s())
			{
				bool flag = false;
				string text = gik.n();
				try
				{
					if (!gik.D("ConnectorInterfaceVersion"))
					{
						if (!gik.D("ConnectorReleaseStatus"))
						{
							if (!gik.D("ConnectorSupportCheckPending"))
							{
								if (!gik.D("ConnectorSupportOutputCheckPending"))
								{
									if (!gik.D("AddOutputName"))
									{
										if (!gik.D("AddOutputDescription"))
										{
											if (!gik.D("AddOutputCategory"))
											{
												if (!gik.D("AddOutputLabel"))
												{
													if (!gik.D("AddOutputOther"))
													{
														if (!gik.D("AddOutput"))
														{
															if (!gik.D("AddFlowExtensionId"))
															{
																if (!gik.D("AddFlowExtensionType"))
																{
																	if (!gik.D("AddFlowExtensionParameter"))
																	{
																		if (!gik.D("AddFlowExtensionOther"))
																		{
																			if (!gik.D("AddFlowExtension"))
																			{
																				if (!gik.D("ConnectorVersion"))
																				{
																					if (!gik.D("ConnectorPROD"))
																					{
																						if (!gik.D("ConnectorLicenseTier"))
																						{
																							if (!gik.D("ConnectorPassThroughSchema"))
																							{
																								if (!gik.D("HideLocalFolders"))
																								{
																									if (!gik.D("QueryOp"))
																									{
																										if (!gik.D("UploadTestFileOp"))
																										{
																											if (!gik.D("HasTestFile"))
																											{
																												if (!gik.D("AuthTokenOp"))
																												{
																													if (!gik.D("OAuthTokenOp"))
																													{
																														if (!gik.D("AuthenticateOp"))
																														{
																															if (!gik.D("AuthorizeOp"))
																															{
																																if (!gik.D("CorsOp"))
																																{
																																	if (!gik.D("ValidateScript"))
																																	{
																																		if (!gik.D("DocumentIntelligenceOp") || gik.s())
																																		{
																																			if (!gik.D("SupportRequeue"))
																																			{
																																				if (!gik.D("ConnectorTrappable"))
																																				{
																																					if (!gik.D("SupportSuccessPath"))
																																					{
																																						if (!gik.D("NoOutputAction"))
																																						{
																																							if (guB.pO(gik.y()))
																																							{
																																								return guB.pf(gik.y());
																																							}
																																							if (!gik.D("ConnectorSupportProxy"))
																																							{
																																								if (!gik.D("AfterReceiveEventInput") && !gik.D("AfterSendEventInput"))
																																								{
																																									if (!gik.D("IgnoreInvalidLocalDirectories"))
																																									{
																																										if (!gik.D("Alias"))
																																										{
																																											if (!gik.D("ConnectorReleaseMessage"))
																																											{
																																												if (!gik.D("HelpLocation"))
																																												{
																																													if (!gik.D("ServiceMode"))
																																													{
																																														if (!gik.D("NoDefaultOutput"))
																																														{
																																															if (!gik.D("FlowUiStyle"))
																																															{
																																																if (!gik.D("PassiveReceiveTriggerText"))
																																																{
																																																	if (!gik.D("BackoffMode"))
																																																	{
																																																		if (!gik.D("ResettableStateNames"))
																																																		{
																																																			if (!gik.D("SharedConnectionStatePrefixes"))
																																																			{
																																																				if (!gik.D("RetriableTransform"))
																																																				{
																																																					if (!gik.D("EnableInputTransform"))
																																																					{
																																																						if (!gik.D("EnableOutputTransform"))
																																																						{
																																																							if (!gik.D("ReplacementType"))
																																																							{
																																																								if (!gik.D("ReplacementIdLabels"))
																																																								{
																																																									if (!gik.D("UIVersion"))
																																																									{
																																																										if (!gik.D("TemplateConnector"))
																																																										{
																																																											if (!gik.D("CDataApplicationConnector"))
																																																											{
																																																												if (!gik.D("Implementations"))
																																																												{
																																																													if (!gik.D("Abort"))
																																																													{
																																																														flag = true;
																																																													}
																																																													else
																																																													{
																																																														this.ly = bool.Parse(text);
																																																													}
																																																												}
																																																												else
																																																												{
																																																													this.On(text);
																																																												}
																																																											}
																																																											else
																																																											{
																																																												this.ll = bool.Parse(text);
																																																											}
																																																										}
																																																										else
																																																										{
																																																											this.lQ = bool.Parse(text);
																																																										}
																																																									}
																																																									else if (!Eyf.hK(text, "Classic"))
																																																									{
																																																										if (!Eyf.hK(text, "cdata-ui"))
																																																										{
																																																											throw new ENP("Config", "Unknown UIVersion {0}.", new object[] { text });
																																																										}
																																																										this.RW(1);
																																																									}
																																																									else
																																																									{
																																																										this.RW(0);
																																																									}
																																																								}
																																																								else
																																																								{
																																																									this.lU = text;
																																																								}
																																																							}
																																																							else
																																																							{
																																																								this.lt = text;
																																																							}
																																																						}
																																																						else
																																																						{
																																																							this.lg = text;
																																																						}
																																																					}
																																																					else
																																																					{
																																																						this.Mz = text;
																																																					}
																																																				}
																																																				else
																																																				{
																																																					this.MO = bool.Parse(text);
																																																				}
																																																			}
																																																			else
																																																			{
																																																				this.OM(text);
																																																			}
																																																		}
																																																		else
																																																		{
																																																			this.OJ(text);
																																																		}
																																																	}
																																																	else
																																																	{
																																																		this.Mc = int.Parse(text);
																																																	}
																																																}
																																																else
																																																{
																																																	this.Mt = text;
																																																}
																																															}
																																															else
																																															{
																																																if (!Eyf.CV(text))
																																																{
																																																	throw new ENP("Config", "Unknown FlowUiStyle {0}.", new object[] { text });
																																																}
																																																int num = int.Parse(text);
																																																if (num != 0 && num != 1)
																																																{
																																																	throw new ENP("Config", "Unknown FlowUiStyle {0}.", new object[] { text });
																																																}
																																																this.Oq(num);
																																															}
																																														}
																																														else
																																														{
																																															this.Ul = bool.Parse(text);
																																														}
																																													}
																																													else
																																													{
																																														this.OW(int.Parse(text));
																																													}
																																												}
																																												else
																																												{
																																													this.OX(text);
																																												}
																																											}
																																											else
																																											{
																																												this.CJ(text);
																																											}
																																										}
																																										else
																																										{
																																											this.OD(text);
																																										}
																																									}
																																									else
																																									{
																																										this.Ok(bool.Parse(text));
																																									}
																																								}
																																								else
																																								{
																																									this.OR(gik.y().Replace("EventInput", ""), gik.t(), gik.n());
																																								}
																																							}
																																							else
																																							{
																																								this.Os(bool.Parse(text));
																																							}
																																						}
																																						else
																																						{
																																							int num2 = int.Parse(text);
																																							if (num2 != 0 && num2 != 1)
																																							{
																																								throw new ENP("Config", "Unknown NoOutputAction {0}.", new object[] { text });
																																							}
																																							this.OL(num2);
																																						}
																																					}
																																					else
																																					{
																																						this.OC(bool.Parse(text));
																																					}
																																				}
																																				else
																																				{
																																					this.Ov(bool.Parse(text));
																																				}
																																			}
																																			else
																																			{
																																				this.OB(bool.Parse(text));
																																			}
																																		}
																																		else
																																		{
																																			string text2 = Eyf.Dx(gik.t());
																																			if (!Eyf.lx(text2))
																																			{
																																				this.Uw.Add(text2);
																																				this.UR.Add(text);
																																			}
																																		}
																																	}
																																	else
																																	{
																																		this.OO(text);
																																	}
																																}
																																else
																																{
																																	this.kZ(text);
																																}
																															}
																															else
																															{
																																this.kp(text);
																															}
																														}
																														else
																														{
																															this.kH(text);
																														}
																													}
																													else
																													{
																														this.kG(text);
																													}
																												}
																												else
																												{
																													this.ki(text);
																												}
																											}
																											else
																											{
																												this.Uv = bool.Parse(text);
																											}
																										}
																										else
																										{
																											this.ky(text);
																										}
																									}
																									else
																									{
																										this.Ud = text;
																									}
																								}
																								else
																								{
																									this.kn(Eyf.UB(text, false));
																								}
																							}
																							else
																							{
																								this.kO(Eyf.UB(text, false));
																							}
																						}
																						else if (!Eyf.tn(text))
																						{
																							if (!Eyf.hK(text, "Core"))
																							{
																								if (!Eyf.hK(text, "MFT"))
																								{
																									if (!Eyf.hK(text, "EDI"))
																									{
																										if (!Eyf.hK(text, "Database"))
																										{
																											if (!Eyf.hK(text, "Single"))
																											{
																												if (!Eyf.hK(text, "Invalid"))
																												{
																													throw new ENP("Config", "Invalid license tier {0}.", new object[] { text });
																												}
																												this.kW(-1);
																											}
																											else
																											{
																												this.kW(999);
																											}
																										}
																										else
																										{
																											this.kW(30);
																										}
																									}
																									else
																									{
																										this.kW(20);
																									}
																								}
																								else
																								{
																									this.kW(10);
																								}
																							}
																							else
																							{
																								this.kW(0);
																							}
																						}
																						else
																						{
																							this.kW(Eyf.CF(text, -1));
																						}
																					}
																					else
																					{
																						this.kD(text);
																					}
																				}
																				else
																				{
																					this.kL(text);
																				}
																			}
																			else
																			{
																				this.OG(this.MI, this.MJ, this.MH, this.Mw);
																				this.MI = (this.Mw = null);
																				this.MJ = -1;
																				this.MH = null;
																			}
																		}
																		else
																		{
																			this.Mw = text;
																		}
																	}
																	else
																	{
																		if (this.MH == null)
																		{
																			this.MH = new lmD<string, string>();
																		}
																		this.MH.H(gik.t(), text);
																	}
																}
																else
																{
																	this.MJ = EoD.t(text);
																}
															}
															else
															{
																this.MI = text;
															}
														}
														else
														{
															this.Oe(this.MF, this.Mv, this.Md, this.MK, this.Mb);
															this.MF = (this.Mv = (this.Md = (this.MK = (this.Mb = null))));
														}
													}
													else
													{
														this.Mb = text;
													}
												}
												else
												{
													this.MK = text;
												}
											}
											else
											{
												this.Md = text;
											}
										}
										else
										{
											this.Mv = text;
										}
									}
									else
									{
										this.MF = text;
									}
								}
								else
								{
									this.ks(Eyf.UB(text, false));
								}
							}
							else
							{
								this.kB(Eyf.UB(text, false));
							}
						}
						else
						{
							this.RZ(Eyf.CF(text, 1));
						}
					}
					else
					{
						this.RH(Eyf.CF(text, 6));
					}
					goto IL_0AF9;
				}
				catch (RSBException ex)
				{
					throw new ENP("Config", "Config value failed.", ex, new object[0]);
				}
				goto IL_0A83;
				IL_0AF9:
				if (!flag)
				{
					return null;
				}
				throw new ENP("Config", "Unknown config property name \"{0}\".", new object[] { gik.y() });
			}
			IL_0A83:
			string text3;
			if (!gik.D("IsCloudMode"))
			{
				if (!gik.D("ShowOverlappingConnectors"))
				{
					if (!gik.D("DocsBaseUrl"))
					{
						return null;
					}
				}
				else
				{
					if (!lZh.E(2))
					{
						return "False";
					}
					try
					{
						return Eao.Z().u("ShowOverlappingConnectors");
					}
					catch (lwZ)
					{
						throw;
					}
				}
				text3 = giw.wi();
			}
			else
			{
				text3 = Eyf.Dw(EQB.Wv());
			}
			return text3;
		}

		// Token: 0x06012A9B RID: 76443 RVA: 0x007279D4 File Offset: 0x00725BD4
		public void oJT(int int_0, string string_0)
		{
			rga rga = rga.Fu("application", "arc.core.connector");
			rga.Fr(EQB.Dq(int_0), string_0, this.tx);
		}

		// Token: 0x06012A9C RID: 76444 RVA: 0x00727A04 File Offset: 0x00725C04
		public void oJk(string string_0, string string_1, string string_2)
		{
			lZh.B(string_0, "Name", new object[0]);
			lZh.B(string_2, "ResourceType", new object[0]);
			int num = -1;
			for (int i = 0; i < this.lH.G(); i++)
			{
				Eom eom = this.lH.y(i);
				if (Eyf.hK(eom.E(), string_0))
				{
					num = i;
					IL_005E:
					if (!Eyf.lx(string_1))
					{
						Eom eom2 = new Eom(string_0, string_1, string_2);
						if (num <= -1)
						{
							this.lH.Add(eom2);
							this.lw.n(string_0, eom2);
						}
						else
						{
							this.lH.i(num, eom2);
							this.lw.n(string_0, eom2);
						}
					}
					else if (num > -1)
					{
						this.lH.xk(num);
						this.lw.L(string_0);
					}
					return;
				}
			}
			goto IL_005E;
		}

		// Token: 0x06012A9D RID: 76445 RVA: 0x00727AE4 File Offset: 0x00725CE4
		public static EoE OH()
		{
			if (EQB.tS == null)
			{
				throw new ENP("ConnectorPrototypeMgr", "Connector prototype manager is not initialized.", new object[0]);
			}
			return EQB.tS;
		}

		// Token: 0x06012A9E RID: 76446 RVA: 0x00727B1C File Offset: 0x00725D1C
		public static void OT(string string_0)
		{
			lmr<string> lmr = null;
			if (giw.wp("connector", "excludeconnectors"))
			{
				string[] array = Eyf.xD(giw.wc("connector", "excludeconnectors"), true, ',', false, true);
				if (array != null && array.Length > 0)
				{
					lmr = Eyf.Ox(array);
				}
			}
			EQB.tS = new Eoc(string_0, lmr);
		}

		// Token: 0x06012A9F RID: 76447 RVA: 0x00727B80 File Offset: 0x00725D80
		public static void Op(Eog eog_0)
		{
			EoE eoE = EQB.OH();
			if (eoE is Eoc)
			{
				((Eoc)eoE).A(eog_0);
			}
		}

		// Token: 0x06012AA0 RID: 76448 RVA: 0x00727BB0 File Offset: 0x00725DB0
		public static lmr<EoX> OU()
		{
			return EQB.tM;
		}

		// Token: 0x06012AA1 RID: 76449 RVA: 0x00727BC4 File Offset: 0x00725DC4
		public static EoX OZ(string string_0)
		{
			return EQB.tl.V(string_0);
		}

		// Token: 0x06012AA2 RID: 76450 RVA: 0x00727BE0 File Offset: 0x00725DE0
		public static lmr<EoX> DB()
		{
			return EQB.tQ;
		}

		// Token: 0x06012AA3 RID: 76451 RVA: 0x00727BF4 File Offset: 0x00725DF4
		public static EoX Dv(string string_0)
		{
			return EQB.ty.V(string_0);
		}

		// Token: 0x06012AA4 RID: 76452 RVA: 0x00727C10 File Offset: 0x00725E10
		public static lmr<EoX> DC()
		{
			return EQB.tv;
		}

		// Token: 0x06012AA5 RID: 76453 RVA: 0x00727C24 File Offset: 0x00725E24
		public static EoX Ds(string string_0)
		{
			return EQB.td.V(string_0);
		}

		// Token: 0x06012AA6 RID: 76454 RVA: 0x00727C40 File Offset: 0x00725E40
		public static lmr<EoX> DL()
		{
			return EQB.tK;
		}

		// Token: 0x06012AA7 RID: 76455 RVA: 0x00727C54 File Offset: 0x00725E54
		public static EoX DR(string string_0)
		{
			return EQB.tb.V(string_0);
		}

		// Token: 0x06012AA8 RID: 76456 RVA: 0x00727C70 File Offset: 0x00725E70
		public static lmr<EoX> Dk()
		{
			return EQB.te;
		}

		// Token: 0x06012AA9 RID: 76457 RVA: 0x00727C84 File Offset: 0x00725E84
		public static EoX DO(string string_0)
		{
			return EQB.tI.V(string_0);
		}

		// Token: 0x06012AAA RID: 76458 RVA: 0x00727CA0 File Offset: 0x00725EA0
		public static lmr<EoX> DD()
		{
			return EQB.tJ;
		}

		// Token: 0x06012AAB RID: 76459 RVA: 0x00727CB4 File Offset: 0x00725EB4
		public static EoX DW(string string_0)
		{
			return EQB.tH.V(string_0);
		}

		// Token: 0x06012AAC RID: 76460 RVA: 0x00727CD0 File Offset: 0x00725ED0
		public static EQB DX(string string_0)
		{
			EQB eqb = EQB.tn.O(Eyf.Dx(string_0));
			if (eqb == null)
			{
				eqb = new EQB(new Eor(string_0));
				eqb.RZ(4);
				EQB.tn.x(Eyf.Dx(string_0), eqb);
			}
			return eqb;
		}

		// Token: 0x06012AAD RID: 76461 RVA: 0x00727D20 File Offset: 0x00725F20
		private static rgw Dq(int int_0)
		{
			rgw rgw;
			if (int_0 > rgw.a.p())
			{
				if (int_0 != rgw.l.p())
				{
					if (int_0 != rgw.J.p())
					{
						rgw = rgw.b;
					}
					else
					{
						rgw = rgw.J;
					}
				}
				else
				{
					rgw = rgw.l;
				}
			}
			else
			{
				rgw = rgw.a;
			}
			return rgw;
		}

		// Token: 0x06012AAE RID: 76462 RVA: 0x00727D80 File Offset: 0x00725F80
		private static void DJ(lmr<EoX> lmr_0)
		{
			using (lmg<EoX> lmg = lmr_0.O())
			{
				while (lmg.MoveNext())
				{
					EoX eoX = lmg.Current;
					if (!EQB.tH.Q(eoX.W()))
					{
						EQB.tJ.Add(eoX);
						EQB.tH.n(eoX.W(), eoX);
					}
				}
			}
		}

		// Token: 0x06012AAF RID: 76463 RVA: 0x00727DF4 File Offset: 0x00725FF4
		private static void DM(EQB eqb_0)
		{
			if (!eqb_0.sW())
			{
				EQB.Da(eqb_0, "", "", "", "Output", "");
			}
			if (eqb_0.sD())
			{
				EQB.Da(eqb_0, "trap", "", "", "<span class=\"text-danger\">Error Path</span>", "ConnectionStyle=RedDashed");
			}
			EQB.Da(eqb_0, "success", "", "", "<span class=\"text-success\">Success Path</span>", "ConnectionStyle=Green");
		}

		// Token: 0x06012AB0 RID: 76464 RVA: 0x00727E78 File Offset: 0x00726078
		private static void Da(EQB eqb_0, string string_0, string string_1, string string_2, string string_3, string string_4)
		{
			if (!eqb_0.lc.Q(string_0))
			{
				eqb_0.Oe(string_0, string_1, string_2, string_3, string_4);
			}
		}

		// Token: 0x06012AB1 RID: 76465 RVA: 0x00727EA0 File Offset: 0x007260A0
		private static void Dn(EQB eqb_0)
		{
			lmD<string, EoX> lmD = new lmD<string, EoX>();
			bool flag = false;
			if (eqb_0.vy().G() > 0)
			{
				using (lmg<EoX> lmg = eqb_0.vy().O())
				{
					while (lmg.MoveNext())
					{
						EoX eoX = lmg.Current;
						if (Eyf.hK(eoX.fX(), "Advanced") && Eyf.hK(eoX.A(), "Advanced Settings"))
						{
							flag = true;
						}
						lmD.H(Eyf.Dx(eoX.W()), eoX);
					}
					goto IL_001E;
				}
				goto IL_0F27;
			}
			IL_001E:
			lmD<string, EoX> lmD2 = lmD;
			string text = "SafeInterval";
			string text2 = "The amount of time (in seconds) that the processing of files placed in the Send folder is delayed by. This is useful when outside processes write files directly to the Send folder.";
			int num = 2;
			string text3 = "0";
			string text4 = "Advanced";
			if (!flag)
			{
				goto IL_0F27;
			}
			string text5 = "Advanced Settings";
			IL_0040:
			EQB.Dy(lmD2, eqb_0, text, text2, num, text3, text4, text5, "Processing Delay", "", eqb_0.CF(EQB.tR));
			if (eqb_0.sq())
			{
				EQB.Dy(lmD, eqb_0, "proxyuseglobal", "When checked, the connector will use the proxy settings from the Advanced tab of the Settings page.", 10, "true", "Advanced", "Proxy Settings", "Use Global", "BooleanEnableSettings[false]=\"ProxyType,ProxyHost,ProxyPort,ProxyUser,ProxyPassword,ProxyAuthscheme\",BooleanName=Use global proxy settings from the Settings page", true);
				EQB.Dy(lmD, eqb_0, "ProxyType", "", 6, "None", "Advanced", "Proxy Settings", "Proxy Type", "Options=\"None,Tunnel,SOCKS4,SOCKS5,HTTP\",HiddenWhen=[proxyuseglobal] == 'true'", true);
				EQB.Dy(lmD, eqb_0, "ProxyHost", "", 0, "", "Advanced", "Proxy Settings", "Proxy Host", "HiddenWhen=[proxyuseglobal] == 'true'", true);
				EQB.Dy(lmD, eqb_0, "ProxyPort", "", 2, "", "Advanced", "Proxy Settings", "Proxy Port", "NumberMin=0,NumberMax=65535,HiddenWhen=[proxyuseglobal] == 'true'", true);
				EQB.Dy(lmD, eqb_0, "ProxyUser", "", 0, "", "Advanced", "Proxy Settings", "Proxy User", "HiddenWhen=[proxyuseglobal] == 'true'", true);
				EQB.Dy(lmD, eqb_0, "ProxyPassword", "", 1, "", "Advanced", "Proxy Settings", "Proxy Password", "HiddenWhen=[proxyuseglobal] == 'true'", true);
				EQB.Dy(lmD, eqb_0, "ProxyAuthscheme", "", 6, "None", "Advanced", "Proxy Settings", "Authentication Scheme", "Options=\"None,Basic,Digest,Proprietary,NTLM\",HiddenWhen=[proxyuseglobal] == 'true'", true);
			}
			bool flag2 = true;
			if (giw.wp(ghD.j("profile", "application"), "hidepath"))
			{
				flag2 = Eyf.CZ(giw.wc(ghD.j("profile", "application"), "hidepath"), flag2);
			}
			if (flag2 || eqb_0.sa())
			{
				EQB.Dy(lmD, eqb_0, "SendFolder", "This is the folder where the connector will pick up files to be processed.", 0, "", null, null, "Input Folder (Send)", "LicenseType=Express,Copyable=false", true);
				EQB.Dy(lmD, eqb_0, "ReceiveFolder", "This is the folder where the connector will place processed files.", 0, "", null, null, "Output Folder (Receive)", "LicenseType=Express,Copyable=false", true);
				EQB.Dy(lmD, eqb_0, "SentFolder", "This is the folder where the connector will place files after they have been processed.", 0, "", null, null, "Processed Folder (Sent) (Deprecated)", "LicenseType=Express,Copyable=false,HiddenWhen=[SentFolder] == '' && [SaveToSentFolder] == 'false'", true);
			}
			else
			{
				EQB.Dy(lmD, eqb_0, "SendFolder", "This is the folder where the connector will pick up files to be processed.", 0, "", "Advanced", "Message", "Input Folder (Send)", "LicenseType=Express,Copyable=false", true);
				EQB.Dy(lmD, eqb_0, "ReceiveFolder", "This is the folder where the connector will place processed files.", 0, "", "Advanced", "Message", "Output Folder (Receive)", "LicenseType=Express,Copyable=false", true);
				EQB.Dy(lmD, eqb_0, "SentFolder", "This is the folder where the connector will place files after they have been processed.", 0, "", "Advanced", "Message", "Processed Folder (Sent) (Deprecated)", "LicenseType=Express,Copyable=false,HiddenWhen=[SentFolder] == '' && [SaveToSentFolder] == 'false'", true);
			}
			bool flag3 = false;
			if (giw.wp(ghD.j("profile", "application"), "disablesavetosentfolder"))
			{
				flag3 = Eyf.CZ(giw.wc(ghD.j("profile", "application"), "disablesavetosentfolder"), flag3);
			}
			if (!flag3)
			{
				if (eqb_0.RD() != 0)
				{
					EQB.Dy(lmD, eqb_0, "SaveToSentFolder", "When checked, the connector will keep a copy of sent messages in the Sent folder.", 10, "true", "Advanced", "Message", "Save to Sent Folder (Deprecated)", "InitValue=false,TabIcon=gears,CustomUI=\"embedded/shared/SaveToSentFolder\"", true);
				}
				else
				{
					EQB.Dy(lmD, eqb_0, "SaveToSentFolder", "When checked, the connector will keep a copy of sent messages in the Sent folder.", 10, "true", "Advanced", "Message", "Save to Sent Folder (Deprecated)", "InitValue=false,TabIcon=gears,BooleanName=Enabled", true);
				}
				EQB.Dy(lmD, eqb_0, "SentFolderScheme", "This setting governs the subfolder structure that is used within the Sent folder. By default, all sent files will be saved to the Sent folder directly. For performance reasons, this setting may be used to divide Sent files into separate folders based on the date of the transaction, so as to avoid accumulating a large number of files and folders within a single folder, which may lead to slowdowns in disk IO.", 6, "", "Advanced", "Message", "Sent Folder Scheme (Deprecated)", "Options=\",yyyy-MM-dd,@weekly,yyyy-MM,yyyy\",OptionNames=\",Daily,Weekly,Monthly,Yearly\",InitValue=@weekly,HiddenWhen=[SaveToSentFolder] == 'false'", true);
			}
			else
			{
				EQB.Dy(lmD, eqb_0, "SaveToSentFolder", "When checked, the connector will keep a copy of sent messages in the Sent folder.", 10, "true", null, null, "Save to Sent Folder (Deprecated)", "InitValue=false", true);
				EQB.Dy(lmD, eqb_0, "SentFolderScheme", "This setting governs the subfolder structure that is used within the Sent folder. By default, all sent files will be saved to the Sent folder directly. For performance reasons, this setting may be used to divide Sent files into separate folders based on the date of the transaction, so as to avoid accumulating a large number of files and folders within a single folder, which may lead to slowdowns in disk IO.", 6, "", null, null, "Sent Folder Scheme (Deprecated)", "Options=\",yyyy-MM-dd,@weekly,yyyy-MM,yyyy\",OptionNames=\",Daily,Weekly,Monthly,Yearly\",InitValue=@weekly", true);
			}
			if (eqb_0.CF(null))
			{
				EQB.Dy(lmD, eqb_0, "SendFilter", "A glob pattern filter to be applied on files in the Send folder before they are sent. The pattern may be positive or negative:<br><br>*.edi (only files with the .edi extension are sent)<br>-*.tmp (files with the .tmp extension will not be sent)<br><br>Multiple patterns may be used, comma separated, with later filters taking priority except where an exact match is used.", 0, "", "", "", "Send Filter", "", true);
			}
			EQB.Dy(lmD, eqb_0, "CleanupSendFolder", "", 10, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "CleanupSentFolder", "", 10, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "CleanupReceiveFolder", "", 10, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "LogLevel", "The verbosity of logs generated by the connector. When you request support, set this to Debug.", 6, "Info", "Advanced", "Logging", "Log Level", "Options=\"None,Error,Warning,Info,Debug,Trace\",TabIcon=gears", true);
			EQB.Dy(lmD, eqb_0, "LogSubFolderScheme", "This setting governs the subfolder structure that is used within the Logs folder. By default, all logs will be saved to the Logs/Sent or Logs/Received folder directly. For performance reasons, this setting may be used to divide Logs into separate folders based on the date of the transaction, so as to avoid accumulating a large number of files and folders within a single folder, which may lead to slowdowns in disk IO.", 6, "", "Advanced", "Logging", "Log Subfolder Scheme", "Options=\",yyyy-MM-dd,@weekly,yyyy-MM,yyyy\",OptionNames=\",Daily,Weekly,Monthly,Yearly\",InitValue=@weekly", true);
			EQB.Dy(lmD, eqb_0, "LogMessages", "When checked, the connector will keep a copy of the message next to the logs for the message in the Logs directory. Note that when this setting is disabled, downloading a copy of the file from the Input or Output tabs may no longer be possible.", 10, "true", "Advanced", "Logging", "Log Messages", "BooleanName=Enabled", true);
			EQB.Dy(lmD, eqb_0, "ParentPort", "When Parent Connector is set to the Connector Id of an existing connector of the same type, that connector's settings are used, except where overridden in the child connector configuration. Settings not explicitly overridden are highlighted, and are automatically updated with changes to the Parent Connector.", 0, "", "Advanced", "Inheritance", "Parent Connector", "CustomUI" + ((eqb_0.RD() != 0) ? "=embedded/shared/AdvancedParentConnector" : "=compiled://includes/inheritanceSection.rst") + ",RSBCustomUI=compiled://includes/inheritanceSection.rst", true);
			EQB.Dy(lmD, eqb_0, "AutomationSend", "When checked, the connector will automatically process unsent files.", 10, "true", "Automation", "Settings", "Send Automation", string.Concat(new string[]
			{
				"TabIcon=folder-gear,SectionDescription=\"Settings related to the automatic processing of files by the connector.\",BooleanName=Enabled,CustomUI=\"embedded/shared/AutomationSendEnable?scheduledSend=",
				(!eqb_0.CH(EQB.tR)) ? "false" : "true",
				"\",HiddenWhen=\"!(",
				EQB.DF(eqb_0, EQB.rF.e),
				") && !(",
				EQB.DF(eqb_0, EQB.rF.j),
				") && !(",
				EQB.DF(eqb_0, EQB.rF.d),
				")\""
			}), eqb_0.CF(EQB.tR) || eqb_0.CH(EQB.tR));
			string text6 = string.Concat(new string[]
			{
				"TabIcon=folder-gear,SectionDescription=\"Settings related to the automatic processing of files by the connector.\",InitValue=",
				(eqb_0.CF(EQB.tR) || !eqb_0.CH(EQB.tR)) ? "Send" : "Scheduled",
				",DisplayType=radio,Options=\"Send,Scheduled,Legacy\",OptionNames=\"Send,Scheduled Send\",OptionDescs=\"The connector will process files as they arrive in the send folder.,The connector will wait to process files or folders in the send folder until the defined interval has been reached.\",OptionHiddenWhen[Legacy]=true,HiddenWhen=\"!((",
				EQB.DF(eqb_0, EQB.rF.e),
				") || (",
				EQB.DF(eqb_0, EQB.rF.j),
				")) || !(",
				EQB.DF(eqb_0, EQB.rF.d),
				") || [AutomationSend] == 'false'\",CustomUI=\"embedded/shared/AutomationSendType\""
			});
			EQB.Dy(lmD, eqb_0, "AutomationSendType", "", 6, "Legacy", "Automation", "Settings", "Automation Type", text6, eqb_0.CH(EQB.tR));
			text6 = "TabIcon=folder-gear,CustomUI=embedded/shared/AutomationScheduledSendInterval,HiddenWhen=\"([AutomationSendType] == 'Send' || !(" + EQB.DF(eqb_0, EQB.rF.d) + ")) || ([AutomationSendType] == 'Send' && [AutomationSend] == 'false') || ([AutomationSendType] == 'Scheduled' && [AutomationSend] == 'false') || ([AutomationSendType] == 'Legacy' && [AutomationReceive] == 'false')\"";
			EQB.Dy(lmD, eqb_0, "ScheduledSendInterval", "", 0, "0 * * * ?", "Automation", "Settings", "Interval", text6, eqb_0.CH(EQB.tR));
			text6 = "TabIcon=folder-gear,CustomUI=embedded/shared/AutomationScheduledSendStartTime,HiddenWhen=\"([AutomationSendType] == 'Send' || !(" + EQB.DF(eqb_0, EQB.rF.d) + ")) || ([AutomationSendType] == 'Send' && [AutomationSend] == 'false') || ([AutomationSendType] == 'Scheduled' && [AutomationSend] == 'false') || ([AutomationSendType] == 'Legacy' && [AutomationReceive] == 'false')\"";
			EQB.Dy(lmD, eqb_0, "ScheduledSendStartTime", "The date and time to use as the starting point for calculating scheduled send intervals. If not set, automation starts using the existing scheduling behavior.", 0, "", "Automation", "Settings", "Start Date and Time", text6, eqb_0.CH(EQB.tR));
			EQB.Dy(lmD, eqb_0, "AutomationRetryInterval", "The length of time that the application will wait after an error, in minutes, before attempting to send the file again. If set to 0, the connector will attempt to retry the file every interval.", 2, "60", (!eqb_0.CT(EQB.tR)) ? "" : "Automation", (!eqb_0.CT(EQB.tR)) ? "" : "Settings", "Retry Interval (minutes)", string.Concat(new string[]
			{
				"TabIcon=folder-gear,NumberMin=0,HiddenWhen=\"[AutomationSend] == 'false' || (!(",
				EQB.DF(eqb_0, EQB.rF.e),
				") && (!(",
				EQB.DF(eqb_0, EQB.rF.j),
				") || !",
				Eyf.Dx(Eyf.Dw(eqb_0.LU())),
				"))\""
			}), eqb_0.Oa(EQB.rF.e, EQB.tR) || (eqb_0.Oa(EQB.rF.j, EQB.tR) && eqb_0.LU()));
			EQB.Dy(lmD, eqb_0, "AutomationMaxAttempts", "The maximum number of times the connector will process the input file. Success is based on a successful server acknowledgement and validation of the receipt (when requested synchronously). If this is set to 0, the connector will retry the file indefinitely.", 2, (!eqb_0.CT(EQB.tR)) ? "1" : "5", (!eqb_0.CT(EQB.tR)) ? "" : "Automation", (!eqb_0.CT(EQB.tR)) ? "" : "Settings", "Max Attempts", string.Concat(new string[]
			{
				"TabIcon=folder-gear,NumberMin=0,HiddenWhen=\"[AutomationSend] == 'false' || (!(",
				EQB.DF(eqb_0, EQB.rF.e),
				") && (!(",
				EQB.DF(eqb_0, EQB.rF.j),
				") || !",
				Eyf.Dx(Eyf.Dw(eqb_0.LU())),
				"))\""
			}), eqb_0.Oa(EQB.rF.e, EQB.tR) || (eqb_0.Oa(EQB.rF.j, EQB.tR) && eqb_0.LU()));
			EQB.Dy(lmD, eqb_0, "ResendInterval", "The length of time that the application will wait for an asynchronous ACK receipt, in minutes, before failing the transmission with an ACK Timeout error.", 2, "10", "Automation", "Settings", "Resend Interval (minutes)", "TabIcon=folder-gear,NumberMin=0,HiddenWhen=\"!" + Eyf.Dx(Eyf.Dw(eqb_0.Cp())) + " || [AutomationSend] == 'false'\"", eqb_0.Cp());
			EQB.Dy(lmD, eqb_0, "ResendMaxAttempts", "The maximum number of times the connector will process the input file when asynchronous receipts are requested. Success is based on the return of an asynchronous receipt within the Resend Interval after a successful server acknowledgement (if a successful server acknowledgement is not returned, Max Attempts is applied instead). If this is set to 0, the connector will resend the file indefinitely.", 2, "5", "Automation", "Settings", "Max Attempts (async)", "TabIcon=folder-gear,NumberMin=0,HiddenWhen=\"!" + Eyf.Dx(Eyf.Dw(eqb_0.Cp())) + " || [AutomationSend] == 'false'\"", eqb_0.Cp());
			EQB.Dy(lmD, eqb_0, "CheckPendingInterval", "", 0, "1", "", "", "", "", eqb_0.Cp());
			text6 = "TabIcon=folder-gear,BooleanName=Enabled,CustomUI=embedded/shared/AutomationReceiveEnable,HiddenWhen=\"!(" + EQB.DF(eqb_0, EQB.rF.S) + ")\"";
			EQB.Dy(lmD, eqb_0, "AutomationReceive", "When checked, the connector will receive messages automatically.", 10, "false", "Automation", "Settings", "Receive", text6, eqb_0.Cy(EQB.tR));
			text6 = "TabIcon=folder-gear,CustomUI=embedded/shared/AutomationReceiveInterval,HiddenWhen=\"!(" + EQB.DF(eqb_0, EQB.rF.S) + ") || [AutomationReceive] == 'false'\"";
			EQB.Dy(lmD, eqb_0, "ReceiveInterval", "", 0, "0 * * * ?", "Automation", "Settings", "Receive Execution Interval", text6, eqb_0.Cy(EQB.tR));
			text6 = "TabIcon=folder-gear,CustomUI=embedded/shared/AutomationReceiveStartTime,HiddenWhen=\"!(" + EQB.DF(eqb_0, EQB.rF.S) + ") || [AutomationReceive] == 'false'\"";
			EQB.Dy(lmD, eqb_0, "ReceiveStartTime", "The date and time to use as the starting point for calculating receive intervals. If not set, automation starts using the existing scheduling behavior.", 0, "", "Automation", "Settings", "Start Date and Time", text6, eqb_0.Cy(EQB.tR));
			EQB.Dy(lmD, eqb_0, "ReceivePendingTimeout", "The length of time that the application will wait, in minutes, for a pending output message to be finalized before failing it with a Pending Timeout error. If set to 0, pending output messages never time out.", 2, "10", "Automation", "Settings", "Receive Pending Timeout (minutes)", "TabIcon=folder-gear,NumberMin=0,HiddenWhen=\"!" + Eyf.Dx(Eyf.Dw(eqb_0.CU())) + "\"", eqb_0.CU());
			EQB.Dy(lmD, eqb_0, "MaxWorkers", "The maximum number of workers to assign from the worker pool when processing files on this connector. If not set, the value from Settings (gear icon) > Advanced > Performance will be used.", 2, "", "Automation", "Performance", "Max Workers", string.Concat(new string[]
			{
				"TabIcon=folder-gear,NumberMin=0,LicenseType=Professional,HiddenWhen=\"!(",
				EQB.DF(eqb_0, EQB.rF.e),
				") && !(",
				EQB.DF(eqb_0, EQB.rF.j),
				")\""
			}), eqb_0.CF(EQB.tR));
			EQB.Dy(lmD, eqb_0, "MaxFiles", "The maximum number of files that will be processed for this connector each time workers are assigned to this connector. If not set, the value from Settings (gear icon) > Advanced > Performance will be used.<br/><br/>NOTE: When smaller numbers of connectors are configured, adjustments to this setting will have less impact, since workers will be frequently reassigned to the connector. With larger numbers of connectors, adjustments to this setting can limit the amount of time spent by workers on this connector, distributing outbound processing more evenly.", 2, "", "Automation", "Performance", "Max Files", string.Concat(new string[]
			{
				"TabIcon=folder-gear,NumberMin=0,LicenseType=Express,HiddenWhen=\"!(",
				EQB.DF(eqb_0, EQB.rF.e),
				") && !(",
				EQB.DF(eqb_0, EQB.rF.j),
				")\""
			}), eqb_0.CF(EQB.tR));
			EQB.Dy(lmD, eqb_0, "OutputFormat", "", 0, "Message", "", "", "", "InitValueSource=App:ConnectorDefaultOutputFormat", true);
			EQB.Dy(lmD, eqb_0, "SendToPort", "", 0, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "TrapPort", "", 0, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "ExcludedExtensions", "", 0, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "LogFormat", "", 0, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "PendingFolder", "", 0, "", "", "", "", "LicenseType=Express,Copyable=false", true);
			EQB.Dy(lmD, eqb_0, "PendingInfoFolder", "", 0, "", "", "", "", "LicenseType=Express,Copyable=false", true);
			EQB.Dy(lmD, eqb_0, "LogFolder", "", 0, "", "", "", "", "LicenseType=Express,Copyable=false", true);
			EQB.Dy(lmD, eqb_0, "ArchiveFolder", "", 0, "", "", "", "", "LicenseType=Express,Copyable=false", true);
			EQB.Dy(lmD, eqb_0, "MaskSensitive", "", 0, "true", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "DuplicateLog", "", 0, "true", "", "", "", "", false);
			EQB.Dy(lmD, eqb_0, "Events", "", 5, "", "", "", "", "", false);
			EQB.Dy(lmD, eqb_0, "OverrideEmailSettings", "", 10, "false", "Alerts", "Connector Email Settings", "", "TabCustomUI=embedded/shared/AlertsTab,TabIcon=bell,DisplayType=switch,BooleanName=Override global setting", true);
			EQB.Dy(lmD, eqb_0, "NotifyEmail", "", 10, "true", "Alerts", "Connector Email Settings", "Error Alert", "BooleanName=Enabled,HiddenWhen=[OverrideEmailSettings] == \"false\"", true);
			EQB.Dy(lmD, eqb_0, "NotifyEmailSubject", "", 0, "", "Alerts", "Connector Email Settings", "Subject", "HiddenWhen=[OverrideEmailSettings] == \"false\",RequiredWhen=[OverrideEmailSettings] == \"true\"", true);
			EQB.Dy(lmD, eqb_0, "AllowArcScriptInAlertsSubject", "", 10, "", "Alerts", "Connector Email Settings", "Allow ArcScript in Subject", "InternalSetting=true", true);
			EQB.Dy(lmD, eqb_0, "NotifyEmailTo", "", 0, "", "Alerts", "Connector Email Settings", "To", "HiddenWhen=[OverrideEmailSettings] == \"false\",CustomUI=embedded/shared/AlertRecipientControl", true);
			EQB.Dy(lmD, eqb_0, "SlaActionType", "SlaActionType", 0, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Action Type", "TabIcon=file-contract,TabCustomUI=embedded/shared/SLAsTab", true);
			EQB.Dy(lmD, eqb_0, "SlaExpectedTransactions", "SlaExpectedTransactions", 2, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Expected Transactions", "TabIcon=file-contract,TabCustomUI=embedded/shared/SLAsTab,LicenseType=Enterprise", true);
			EQB.Dy(lmD, eqb_0, "SlaTimeWindowType", "SlaTimeWindowType", 0, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Time Window Type", "", true);
			EQB.Dy(lmD, eqb_0, "SlaTimeWindowSize", "SlaTimeWindowSize", 2, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Time Window Size", "", true);
			EQB.Dy(lmD, eqb_0, "SlaTimeWindowStart", "SlaTimeWindowStart", 0, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Time Window Start", "", true);
			EQB.Dy(lmD, eqb_0, "SlaTimeWindowEnd", "SlaTimeWindowEnd", 0, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Time Window End", "", true);
			EQB.Dy(lmD, eqb_0, "SlaStartTime", "SlaStartTime", 0, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Start Time", "", true);
			EQB.Dy(lmD, eqb_0, "SlaAffectedDays", "SlaAffectedDays", 2, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA Affected Days", "", true);
			EQB.Dy(lmD, eqb_0, "SlaAtRiskTime", "SlaAtRiskTime", 2, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA At risk Time", "", true);
			EQB.Dy(lmD, eqb_0, "SlaAtRiskNotify", "SlaAtRiskNotify", 10, "", "SLAs", "Service Level Agreement (SLA) Settings", "SLA At risk Notify", "", true);
			if (eqb_0.Ls() == 1)
			{
				EQB.Dy(lmD, eqb_0, "__service_logs_tab__", "", 0, "", "Logs", "Service Logs", "", "TabIcon=rectangle-history,TabCustomUI=embedded/shared/ServiceLogsTab,InternalSetting=true", true);
			}
			EQB.Dy(lmD, eqb_0, "BackoffInterval", "", 0, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "BackoffMaxThreshold", "", 0, "", "", "", "", "", true);
			EQB.Dy(lmD, eqb_0, "BackoffMinThreshold", "", 0, "", "", "", "", "", true);
			if (Eyf.hD(eqb_0.LZ(), "XML", true))
			{
				EQB.Dy(lmD, eqb_0, "TransformXMLInMapping", "", 9, "", "", "", "", "InternalSetting=true,ObjectName=TransformXMLInMap.json,ObjectBackup=true", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLInSamples", "", 5, "", "", "", "", "InternalSetting=true", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLInNullValueType", "", 0, "", "", "", "", "", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLInIncludeDeclaration", "", 0, "", "", "", "", "", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLInStreaming", "", 0, "False", "", "", "", "InitValue=True", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLInSource", "", 0, "", "", "", "", "", true);
			}
			if (Eyf.hD(eqb_0.RB(), "XML", true))
			{
				EQB.Dy(lmD, eqb_0, "TransformXMLOutMapping", "", 9, "", "", "", "", "InternalSetting=true,ObjectName=TransformXMLOutMap.json,ObjectBackup=true", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLOutSamples", "", 5, "", "", "", "", "InternalSetting=true", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLOutNullValueType", "", 0, "", "", "", "", "", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLOutIncludeDeclaration", "", 0, "", "", "", "", "", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLOutStreaming", "", 0, "False", "", "", "", "InitValue=True", true);
				EQB.Dy(lmD, eqb_0, "TransformXMLOutDestination", "", 0, "", "", "", "", "", true);
			}
			return;
			IL_0F27:
			text5 = "Other Settings";
			goto IL_0040;
		}

		// Token: 0x06012AB2 RID: 76466 RVA: 0x007293B0 File Offset: 0x007275B0
		private static string DF(EQB eqb_0, EQB.rF rF_0)
		{
			string text;
			if (eqb_0.MR == null)
			{
				lmr<EQB.rF> lmr = eqb_0.LW();
				if (lmr == null || !lmr.Contains(rF_0))
				{
					text = "false";
				}
				else
				{
					text = "true";
				}
			}
			else
			{
				string text2 = eqb_0.LL();
				string[] array = eqb_0.Lk();
				if (array == null || array.Length <= 0)
				{
					text = "false";
				}
				else
				{
					lcc lcc = new lcc();
					foreach (string text3 in array)
					{
						if (eqb_0.Oa(rF_0, text3))
						{
							if (lcc.D > 0)
							{
								lcc.MPI(" || ");
							}
							lcc.MPI("([").MPI(text2).MPI("] == '")
								.MPI(text3)
								.MPI("')");
						}
					}
					if (lcc.D > 0)
					{
						text = lcc.ToString();
					}
					else
					{
						text = "false";
					}
				}
			}
			return text;
		}

		// Token: 0x06012AB3 RID: 76467 RVA: 0x007294C8 File Offset: 0x007276C8
		private static void Dy(lmD<string, EoX> lmD_0, EQB eqb_0, string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, string string_5, string string_6, bool bool_0)
		{
			EQB.Di(lmD_0, eqb_0, string_0, string_1, int_0, string_2, string_3, string_4, string_5, false, string_6, bool_0);
		}

		// Token: 0x06012AB4 RID: 76468 RVA: 0x007294F0 File Offset: 0x007276F0
		private static void Di(lmD<string, EoX> lmD_0, EQB eqb_0, string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, string string_5, bool bool_0, string string_6, bool bool_1)
		{
			if (!lmD_0.ContainsKey(Eyf.Dx(string_0)))
			{
				EoX eoX = eqb_0.le.V(string_0);
				if (eoX != null)
				{
					string_1 = ((eoX.j() != null) ? eoX.j() : string_1);
					int_0 = ((eoX.K() >= 0) ? eoX.K() : int_0);
					string_2 = ((eoX.V() != null) ? eoX.V() : string_2);
					string_3 = ((eoX.fX() != null) ? eoX.fX() : string_3);
					string_4 = ((eoX.A() != null) ? eoX.A() : string_4);
					string_5 = ((eoX.p() != null) ? eoX.p() : string_5);
					lmD<string, string> lmD = eoX.fc();
					if (lmD != null && lmD.A() > 0)
					{
						string_6 = Eyf.UO(string_6, "") + "," + EQB.De(lmD);
					}
				}
				if (!bool_1)
				{
					eqb_0.oJw(string_0, string_1, int_0, string_2, "", "", string_5, bool_0, string_6 + ",InternalSetting=true");
				}
				else
				{
					eqb_0.oJw(string_0, string_1, int_0, string_2, string_3, string_4, string_5, bool_0, string_6);
				}
			}
		}

		// Token: 0x06012AB5 RID: 76469 RVA: 0x00729640 File Offset: 0x00727840
		private static lmD<string, string> DG(string string_0)
		{
			return Eyf.Fr(string_0, ',', '=');
		}

		// Token: 0x06012AB6 RID: 76470 RVA: 0x0072965C File Offset: 0x0072785C
		private static string De(lmD<string, string> lmD_0)
		{
			return Eyf.KB(lmD_0, ',', '=');
		}

		// Token: 0x06012AB7 RID: 76471 RVA: 0x00729678 File Offset: 0x00727878
		private static void DH(EQB eqb_0)
		{
			EEa<EQZ> eea = new EEa<EQZ>();
			using (lmg<EQZ> lmg = eqb_0.vW(EQB.tR).O())
			{
				while (lmg.MoveNext())
				{
					EQZ eqz = lmg.Current;
					eea.n(eqz.r(), eqz);
				}
			}
			if (!eea.Q("beforeSend") && eqb_0.CF(EQB.tR))
			{
				lcc lcc = new lcc();
				lmr<EQB.ri> lmr = eqb_0.lF.V("beforeSend");
				if (lmr != null)
				{
					using (lmg<EQB.ri> lmg2 = lmr.O())
					{
						while (lmg2.MoveNext())
						{
							EQB.ri ri = lmg2.Current;
							lcc.MPI("  <input name=\"").MPI(ri.K).MPI("\"   desc=\"")
								.MPI(ri.r)
								.MPI("\" />\n");
						}
						goto IL_00B8;
					}
					goto IL_0155;
				}
				IL_00B8:
				eqb_0.Oy("beforeSend", Eyf.OS(EQB.tg, lcc.ToString()), new EQB.rF[]
				{
					EQB.rF.e,
					EQB.rF.j
				});
			}
			if (!eea.Q("afterSend"))
			{
				goto IL_0155;
			}
			bool flag = true;
			IL_006B:
			if (!flag)
			{
				lcc lcc = new lcc();
				lmr<EQB.ri> lmr = eqb_0.lF.V("afterSend");
				if (lmr != null)
				{
					using (lmg<EQB.ri> lmg2 = lmr.O())
					{
						while (lmg2.MoveNext())
						{
							EQB.ri ri = lmg2.Current;
							lcc.MPI("  <input name=\"").MPI(ri.K).MPI("\"   desc=\"")
								.MPI(ri.r)
								.MPI("\" />\n");
						}
						goto IL_0198;
					}
					goto IL_0235;
				}
				IL_0198:
				eqb_0.Oy("afterSend", Eyf.OS(EQB.tt, lcc.ToString()), new EQB.rF[]
				{
					EQB.rF.e,
					EQB.rF.g
				});
			}
			if (!eea.Q("afterReceive"))
			{
				goto IL_0235;
			}
			bool flag2 = true;
			IL_0081:
			if (!flag2)
			{
				lcc lcc = new lcc();
				lmr<EQB.ri> lmr = eqb_0.lF.V("afterReceive");
				if (lmr != null)
				{
					using (lmg<EQB.ri> lmg2 = lmr.O())
					{
						while (lmg2.MoveNext())
						{
							EQB.ri ri = lmg2.Current;
							lcc.MPI("  <input name=\"").MPI(ri.K).MPI("\"   desc=\"")
								.MPI(ri.r)
								.MPI("\" />\n");
						}
						goto IL_0294;
					}
					return;
				}
				IL_0294:
				eqb_0.Oy("afterReceive", Eyf.OS(EQB.tU, lcc.ToString()), new EQB.rF[]
				{
					EQB.rF.S,
					EQB.rF.U,
					EQB.rF.j,
					EQB.rF.d
				});
			}
			return;
			IL_0235:
			flag2 = !eqb_0.Cy(EQB.tR) && !eqb_0.CG(EQB.tR) && !eqb_0.Oa(EQB.rF.j, EQB.tR) && !eqb_0.Oa(EQB.rF.d, EQB.tR);
			goto IL_0081;
			IL_0155:
			flag = !eqb_0.CF(EQB.tR) && !eqb_0.Ci(EQB.tR);
			goto IL_006B;
		}

		// Token: 0x06012AB8 RID: 76472 RVA: 0x007299F4 File Offset: 0x00727BF4
		private static void DT(EQB eqb_0)
		{
			if (eqb_0.W())
			{
				bool flag = false;
				lmD<string, EoX> lmD = new lmD<string, EoX>();
				using (lmg<EoX> lmg = eqb_0.vG().O())
				{
					while (lmg.MoveNext())
					{
						EoX eoX = lmg.Current;
						lmD.H(Eyf.Dx(eoX.W()), eoX);
						if (!Eyf.lx(eoX.p()))
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					goto IL_00D9;
				}
				string text = "Logging";
				IL_006F:
				string text2 = text;
				using (lmg<EoX> lmg = EQB.tP.O())
				{
					while (lmg.MoveNext())
					{
						EoX eoX2 = lmg.Current;
						EQB.Dp(lmD, eqb_0, eoX2.W(), eoX2.K(), eoX2.p(), text2, eoX2.j(), eoX2.V(), EQB.De(eoX2.fc()));
					}
					return;
				}
				IL_00D9:
				text = "";
				goto IL_006F;
			}
		}

		// Token: 0x06012AB9 RID: 76473 RVA: 0x00729B00 File Offset: 0x00727D00
		private static void Dp(lmD<string, EoX> lmD_0, EQB eqb_0, string string_0, int int_0, string string_1, string string_2, string string_3, string string_4, string string_5)
		{
			if (!lmD_0.ContainsKey(Eyf.Dx(string_0)))
			{
				eqb_0.oJN(string_0, string_3, int_0, string_4, string_2, string_1, string_5);
			}
		}

		// Token: 0x06012ABA RID: 76474 RVA: 0x00729B30 File Offset: 0x00727D30
		private static bool DU(string string_0)
		{
			if (!Eyf.lx(string_0))
			{
				Egh egh = EQB.tw.y(string_0);
				if (egh.W())
				{
					for (;;)
					{
						string text = egh.H(1);
						if (!Eyf.hK(text, "b") && !Eyf.hK(text, "i") && !Eyf.hK(text, "span"))
						{
							break;
						}
						if (!egh.G())
						{
							goto IL_0008;
						}
					}
					return false;
				}
			}
			IL_0008:
			return true;
		}

		// Token: 0x06012ABB RID: 76475 RVA: 0x00729BA0 File Offset: 0x00727DA0
		private static lmr<EQB.rF> DZ(string string_0)
		{
			lmr<EQB.rF> lmr = new lmr<EQB.rF>();
			string[] array = Eyf.xD(string_0, true, ',', true, true);
			if (array != null && array.Length > 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					IList<EQB.rF> list = EQB.WB(array[i]);
					lmr.r(list);
				}
			}
			return lmr;
		}

		// Token: 0x06012ABC RID: 76476 RVA: 0x00729BF8 File Offset: 0x00727DF8
		private static IList<EQB.rF> WB(string string_0)
		{
			lmr<EQB.rF> lmr = new lmr<EQB.rF>();
			if (string_0 != null)
			{
				if (mcX.XMv == null)
				{
					mcX.XMv = new Dictionary<string, int>(9)
					{
						{ "ActiveSend", 0 },
						{ "ActiveReceive", 1 },
						{ "PassiveSend", 2 },
						{ "PassiveReceive", 3 },
						{ "ActiveAndPassiveSend", 4 },
						{ "ActiveAndPassiveReceive", 5 },
						{ "Transform", 6 },
						{ "ScheduledTransform", 7 },
						{ "None", 8 }
					};
				}
				int num;
				if (mcX.XMv.TryGetValue(string_0, out num))
				{
					switch (num)
					{
					case 0:
						lmr.Add(EQB.rF.e);
						break;
					case 1:
						lmr.Add(EQB.rF.S);
						break;
					case 2:
						lmr.Add(EQB.rF.g);
						break;
					case 3:
						lmr.Add(EQB.rF.U);
						break;
					case 4:
						lmr.Add(EQB.rF.e);
						lmr.Add(EQB.rF.g);
						break;
					case 5:
						lmr.Add(EQB.rF.S);
						lmr.Add(EQB.rF.U);
						break;
					case 6:
						lmr.Add(EQB.rF.j);
						break;
					case 7:
						lmr.Add(EQB.rF.d);
						break;
					case 8:
						lmr.Add(EQB.rF.p);
						break;
					default:
						goto IL_000B;
					}
					return lmr;
				}
			}
			IL_000B:
			throw new ENP("ParseSingleOperation", "Unknown operation {0}.", new object[] { string_0 });
		}

		// Token: 0x06012ABD RID: 76477 RVA: 0x00701964 File Offset: 0x006FFB64
		private static bool Wv()
		{
			return giw.wy();
		}

		// Token: 0x040085F5 RID: 34293
		public const string g = "Deprecated";

		// Token: 0x040085F6 RID: 34294
		public const string t = "Removed";

		// Token: 0x040085F7 RID: 34295
		public const string U = "Beta";

		// Token: 0x040085F8 RID: 34296
		public const string M = "Full";

		// Token: 0x040085F9 RID: 34297
		public const string l = "Uninstall";

		// Token: 0x040085FA RID: 34298
		public const string Q = "Unavailable";

		// Token: 0x040085FB RID: 34299
		private const int y = 6;

		// Token: 0x040085FC RID: 34300
		private const int P = 0;

		// Token: 0x040085FD RID: 34301
		private const int F = 1;

		// Token: 0x040085FE RID: 34302
		private const int v = 2;

		// Token: 0x040085FF RID: 34303
		private const int d = 3;

		// Token: 0x04008600 RID: 34304
		private const int K = 4;

		// Token: 0x04008601 RID: 34305
		private const int b = 5;

		// Token: 0x04008602 RID: 34306
		public const int e = 0;

		// Token: 0x04008603 RID: 34307
		public const int I = 1;

		// Token: 0x04008604 RID: 34308
		public const int J = 0;

		// Token: 0x04008605 RID: 34309
		public const int H = 1;

		// Token: 0x04008606 RID: 34310
		public const int w = 0;

		// Token: 0x04008607 RID: 34311
		public const int R = 1;

		// Token: 0x04008608 RID: 34312
		public const int n = 0;

		// Token: 0x04008609 RID: 34313
		public const int S = 1;

		// Token: 0x0400860A RID: 34314
		private const string c = "settings.rst";

		// Token: 0x0400860B RID: 34315
		private const string x = "advanced.rst";

		// Token: 0x0400860C RID: 34316
		private const string A = "profile.rst";

		// Token: 0x0400860D RID: 34317
		public const int O = 0;

		// Token: 0x0400860E RID: 34318
		public const int z = 1;

		// Token: 0x0400860F RID: 34319
		private static readonly string tg;

		// Token: 0x04008610 RID: 34320
		private static readonly string tt;

		// Token: 0x04008611 RID: 34321
		private static readonly string tU;

		// Token: 0x04008612 RID: 34322
		private static lmr<EoX> tM = new lmr<EoX>();

		// Token: 0x04008613 RID: 34323
		private static EEa<EoX> tl;

		// Token: 0x04008614 RID: 34324
		private static lmr<EoX> tQ;

		// Token: 0x04008615 RID: 34325
		private static EEa<EoX> ty;

		// Token: 0x04008616 RID: 34326
		private static lmr<EoX> tP;

		// Token: 0x04008617 RID: 34327
		private static EEa<EoX> tF;

		// Token: 0x04008618 RID: 34328
		private static lmr<EoX> tv;

		// Token: 0x04008619 RID: 34329
		private static EEa<EoX> td;

		// Token: 0x0400861A RID: 34330
		private static lmr<EoX> tK;

		// Token: 0x0400861B RID: 34331
		private static EEa<EoX> tb;

		// Token: 0x0400861C RID: 34332
		private static lmr<EoX> te;

		// Token: 0x0400861D RID: 34333
		private static EEa<EoX> tI;

		// Token: 0x0400861E RID: 34334
		private static lmr<EoX> tJ;

		// Token: 0x0400861F RID: 34335
		private static EEa<EoX> tH;

		// Token: 0x04008620 RID: 34336
		private static EgB tw = new EgB("<([a-z][a-z0-9]*)\\b", 4);

		// Token: 0x04008621 RID: 34337
		public static readonly string tR;

		// Token: 0x04008622 RID: 34338
		private static lmw<string, EQB> tn = new lmw<string, EQB>();

		// Token: 0x04008623 RID: 34339
		private static EoE tS = null;

		// Token: 0x04008624 RID: 34340
		private Eou tc = null;

		// Token: 0x04008625 RID: 34341
		private string tx = null;

		// Token: 0x04008626 RID: 34342
		private string tA = null;

		// Token: 0x04008627 RID: 34343
		private int tO = 6;

		// Token: 0x04008628 RID: 34344
		private readonly lmr<EQB.rF> tz = new lmr<EQB.rF>();

		// Token: 0x04008629 RID: 34345
		private string Ug = null;

		// Token: 0x0400862A RID: 34346
		private int Ut = 1;

		// Token: 0x0400862B RID: 34347
		private bool UU = false;

		// Token: 0x0400862C RID: 34348
		private bool UM = false;

		// Token: 0x0400862D RID: 34349
		private bool Ul = false;

		// Token: 0x0400862E RID: 34350
		private string UQ = "26.4.9813.0";

		// Token: 0x0400862F RID: 34351
		private bool Uy = false;

		// Token: 0x04008630 RID: 34352
		private bool UP = true;

		// Token: 0x04008631 RID: 34353
		private bool UF = false;

		// Token: 0x04008632 RID: 34354
		private bool Uv = false;

		// Token: 0x04008633 RID: 34355
		private string Ud = null;

		// Token: 0x04008634 RID: 34356
		private string UK = null;

		// Token: 0x04008635 RID: 34357
		private string Ub = null;

		// Token: 0x04008636 RID: 34358
		private string Ue = null;

		// Token: 0x04008637 RID: 34359
		private string UI = null;

		// Token: 0x04008638 RID: 34360
		private string UJ = null;

		// Token: 0x04008639 RID: 34361
		private string UH = null;

		// Token: 0x0400863A RID: 34362
		private readonly lmr<string> Uw = new lmr<string>();

		// Token: 0x0400863B RID: 34363
		private readonly lmr<string> UR = new lmr<string>();

		// Token: 0x0400863C RID: 34364
		private bool Un = true;

		// Token: 0x0400863D RID: 34365
		private bool US = true;

		// Token: 0x0400863E RID: 34366
		private bool Uc = true;

		// Token: 0x0400863F RID: 34367
		private bool Ux = false;

		// Token: 0x04008640 RID: 34368
		private int UA = 0;

		// Token: 0x04008641 RID: 34369
		private int UO = 0;

		// Token: 0x04008642 RID: 34370
		private string Uz = null;

		// Token: 0x04008643 RID: 34371
		private string Mg = null;

		// Token: 0x04008644 RID: 34372
		private string Mt = "When a file is received";

		// Token: 0x04008645 RID: 34373
		private string MU = "XXXXX";

		// Token: 0x04008646 RID: 34374
		private int MM = -1;

		// Token: 0x04008647 RID: 34375
		private guw Ml = null;

		// Token: 0x04008648 RID: 34376
		private bool MQ = false;

		// Token: 0x04008649 RID: 34377
		private string My = null;

		// Token: 0x0400864A RID: 34378
		private string MP = null;

		// Token: 0x0400864B RID: 34379
		private string MF = null;

		// Token: 0x0400864C RID: 34380
		private string Mv = null;

		// Token: 0x0400864D RID: 34381
		private string Md = null;

		// Token: 0x0400864E RID: 34382
		private string MK = null;

		// Token: 0x0400864F RID: 34383
		private string Mb = null;

		// Token: 0x04008650 RID: 34384
		private int Me = 0;

		// Token: 0x04008651 RID: 34385
		private string MI = null;

		// Token: 0x04008652 RID: 34386
		private int MJ = -1;

		// Token: 0x04008653 RID: 34387
		private lmD<string, string> MH = null;

		// Token: 0x04008654 RID: 34388
		private string Mw = null;

		// Token: 0x04008655 RID: 34389
		private EoX MR = null;

		// Token: 0x04008656 RID: 34390
		private EoX Mn = null;

		// Token: 0x04008657 RID: 34391
		private readonly EEa<lmr<EQB.rF>> MS = new EEa<lmr<EQB.rF>>();

		// Token: 0x04008658 RID: 34392
		private int Mc = 0;

		// Token: 0x04008659 RID: 34393
		private string[] Mx = new string[0];

		// Token: 0x0400865A RID: 34394
		private string[] MA = new string[0];

		// Token: 0x0400865B RID: 34395
		private bool MO = false;

		// Token: 0x0400865C RID: 34396
		private string Mz = null;

		// Token: 0x0400865D RID: 34397
		private string lg = null;

		// Token: 0x0400865E RID: 34398
		private string lt = null;

		// Token: 0x0400865F RID: 34399
		private string lU = null;

		// Token: 0x04008660 RID: 34400
		private int lM = 0;

		// Token: 0x04008661 RID: 34401
		private bool ll = false;

		// Token: 0x04008662 RID: 34402
		private bool lQ = false;

		// Token: 0x04008663 RID: 34403
		private bool ly = false;

		// Token: 0x04008664 RID: 34404
		private readonly lmr<string> lP = new lmr<string>();

		// Token: 0x04008665 RID: 34405
		private readonly EEa<lmr<EQB.ri>> lF = new EEa<lmr<EQB.ri>>();

		// Token: 0x04008666 RID: 34406
		private readonly lmr<EQZ> lv = new lmr<EQZ>();

		// Token: 0x04008667 RID: 34407
		private readonly EEa<EQZ> ld = new EEa<EQZ>();

		// Token: 0x04008668 RID: 34408
		private readonly lmr<EoX> lK = new lmr<EoX>();

		// Token: 0x04008669 RID: 34409
		private readonly EEa<EoX> lb = new EEa<EoX>();

		// Token: 0x0400866A RID: 34410
		private readonly EEa<EoX> le = new EEa<EoX>();

		// Token: 0x0400866B RID: 34411
		private readonly lmr<EoX> lI = new lmr<EoX>();

		// Token: 0x0400866C RID: 34412
		private readonly EEa<EoX> lJ = new EEa<EoX>();

		// Token: 0x0400866D RID: 34413
		private readonly lmr<Eom> lH = new lmr<Eom>();

		// Token: 0x0400866E RID: 34414
		private readonly EEa<Eom> lw = new EEa<Eom>();

		// Token: 0x0400866F RID: 34415
		private readonly lmr<EoX> lR = new lmr<EoX>();

		// Token: 0x04008670 RID: 34416
		private readonly EEa<EoX> ln = new EEa<EoX>();

		// Token: 0x04008671 RID: 34417
		private readonly lmr<Eoy> lS = new lmr<Eoy>();

		// Token: 0x04008672 RID: 34418
		private readonly EEa<Eoy> lc = new EEa<Eoy>();

		// Token: 0x04008673 RID: 34419
		private readonly lmr<EoD> lx = new lmr<EoD>();

		// Token: 0x04008674 RID: 34420
		private readonly lmD<string, EoD> lA = new lmD<string, EoD>();

		// Token: 0x04008675 RID: 34421
		private readonly lmD<string, lmr<Eom>> lO = new lmD<string, lmr<Eom>>();

		// Token: 0x04008676 RID: 34422
		private readonly lmD<string, EEa<Eom>> lz = new lmD<string, EEa<Eom>>();

		// Token: 0x04008677 RID: 34423
		private readonly EEa<lmr<Eoy>> Qg = new EEa<lmr<Eoy>>();

		// Token: 0x04008678 RID: 34424
		private readonly EEa<EEa<Eoy>> Qt = new EEa<EEa<Eoy>>();

		// Token: 0x04008679 RID: 34425
		private readonly EEa<lmr<EoD>> QU = new EEa<lmr<EoD>>();

		// Token: 0x0400867A RID: 34426
		private readonly EEa<lmD<string, EoD>> QM = new EEa<lmD<string, EoD>>();

		// Token: 0x0400867B RID: 34427
		private readonly EEa<EQB.rC> Ql = new EEa<EQB.rC>();

		// Token: 0x0400867C RID: 34428
		private readonly EEa<lmr<EQk>> QQ = new EEa<lmr<EQk>>();

		// Token: 0x0200136E RID: 4974
		public enum rF
		{
			// Token: 0x0400867E RID: 34430
			p,
			// Token: 0x0400867F RID: 34431
			e,
			// Token: 0x04008680 RID: 34432
			S,
			// Token: 0x04008681 RID: 34433
			g,
			// Token: 0x04008682 RID: 34434
			U,
			// Token: 0x04008683 RID: 34435
			j,
			// Token: 0x04008684 RID: 34436
			d
		}

		// Token: 0x0200136F RID: 4975
		private sealed class ri
		{
			// Token: 0x06012ABE RID: 76478 RVA: 0x0007A4E0 File Offset: 0x000786E0
			public ri(string string_0, string string_1)
			{
				lZh.B(string_0, "Name", new object[0]);
				this.K = string_0;
				this.r = string_1;
			}

			// Token: 0x04008685 RID: 34437
			public readonly string K;

			// Token: 0x04008686 RID: 34438
			public readonly string r;
		}

		// Token: 0x02001370 RID: 4976
		private sealed class rC
		{
			// Token: 0x06012ABF RID: 76479 RVA: 0x0007A507 File Offset: 0x00078707
			public rC(int int_0)
			{
				this.s = int_0;
			}

			// Token: 0x04008687 RID: 34439
			public readonly int s;
		}
	}
}
