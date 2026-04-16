using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureRule
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDevicePostureRuleInput), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleInput")]
    public interface IZeroTrustDevicePostureRuleInput
    {
        /// <summary>The Number of active threats.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#active_threats ZeroTrustDevicePostureRule#active_threats}
        /// </remarks>
        [JsiiProperty(name: "activeThreats", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ActiveThreats
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID of Cloudflare managed certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#certificate_id ZeroTrustDevicePostureRule#certificate_id}
        /// </remarks>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of volume names to be checked for encryption.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#check_disks ZeroTrustDevicePostureRule#check_disks}
        /// </remarks>
        [JsiiProperty(name: "checkDisks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CheckDisks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Confirm the certificate was not imported from another device.</summary>
        /// <remarks>
        /// We recommend keeping this enabled unless the certificate was deployed without a private key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#check_private_key ZeroTrustDevicePostureRule#check_private_key}
        /// </remarks>
        [JsiiProperty(name: "checkPrivateKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CheckPrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Common Name that is protected by the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#cn ZeroTrustDevicePostureRule#cn}
        /// </remarks>
        [JsiiProperty(name: "cn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Compliance Status. Available values: "compliant", "noncompliant", "unknown", "notapplicable", "ingraceperiod", "error".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#compliance_status ZeroTrustDevicePostureRule#compliance_status}
        /// </remarks>
        [JsiiProperty(name: "complianceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComplianceStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Posture Integration ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#connection_id ZeroTrustDevicePostureRule#connection_id}
        /// </remarks>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Count Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#count_operator ZeroTrustDevicePostureRule#count_operator}
        /// </remarks>
        [JsiiProperty(name: "countOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CountOperator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#domain ZeroTrustDevicePostureRule#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>For more details on eid last seen, refer to the Tanium documentation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#eid_last_seen ZeroTrustDevicePostureRule#eid_last_seen}
        /// </remarks>
        [JsiiProperty(name: "eidLastSeen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EidLastSeen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#enabled ZeroTrustDevicePostureRule#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether or not file exists.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#exists ZeroTrustDevicePostureRule#exists}
        /// </remarks>
        [JsiiProperty(name: "exists", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Exists
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of values indicating purposes for which the certificate public key can be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#extended_key_usage ZeroTrustDevicePostureRule#extended_key_usage}
        /// </remarks>
        [JsiiProperty(name: "extendedKeyUsage", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExtendedKeyUsage
        {
            get
            {
                return null;
            }
        }

        /// <summary>List ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#id ZeroTrustDevicePostureRule#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether device is infected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#infected ZeroTrustDevicePostureRule#infected}
        /// </remarks>
        [JsiiProperty(name: "infected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Infected
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether device is active.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#is_active ZeroTrustDevicePostureRule#is_active}
        /// </remarks>
        [JsiiProperty(name: "isActive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsActive
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Number of Issues.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#issue_count ZeroTrustDevicePostureRule#issue_count}
        /// </remarks>
        [JsiiProperty(name: "issueCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IssueCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>For more details on last seen, please refer to the Crowdstrike documentation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#last_seen ZeroTrustDevicePostureRule#last_seen}
        /// </remarks>
        [JsiiProperty(name: "lastSeen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastSeen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#locations ZeroTrustDevicePostureRule#locations}.</summary>
        [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleInputLocations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleInputLocations? Locations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Network status of device. Available values: "connected", "disconnected", "disconnecting", "connecting".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#network_status ZeroTrustDevicePostureRule#network_status}
        /// </remarks>
        [JsiiProperty(name: "networkStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Operating system. Available values: "windows", "linux", "mac", "android", "ios", "chromeos".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#operating_system ZeroTrustDevicePostureRule#operating_system}
        /// </remarks>
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Agent operational state. Available values: "na", "partially_disabled", "auto_fully_disabled", "fully_disabled", "auto_partially_disabled", "disabled_error", "db_corruption".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#operational_state ZeroTrustDevicePostureRule#operational_state}
        /// </remarks>
        [JsiiProperty(name: "operationalState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperationalState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#operator ZeroTrustDevicePostureRule#operator}
        /// </remarks>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Os Version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os ZeroTrustDevicePostureRule#os}
        /// </remarks>
        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Os
        {
            get
            {
                return null;
            }
        }

        /// <summary>Operating System Distribution Name (linux only).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os_distro_name ZeroTrustDevicePostureRule#os_distro_name}
        /// </remarks>
        [JsiiProperty(name: "osDistroName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OsDistroName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version of OS Distribution (linux only).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os_distro_revision ZeroTrustDevicePostureRule#os_distro_revision}
        /// </remarks>
        [JsiiProperty(name: "osDistroRevision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OsDistroRevision
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional operating system version details.</summary>
        /// <remarks>
        /// For Windows, the UBR (Update Build Revision). For Mac or iOS, the Product Version Extra. For Linux, the distribution name and version.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os_version_extra ZeroTrustDevicePostureRule#os_version_extra}
        /// </remarks>
        [JsiiProperty(name: "osVersionExtra", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OsVersionExtra
        {
            get
            {
                return null;
            }
        }

        /// <summary>Overall.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#overall ZeroTrustDevicePostureRule#overall}
        /// </remarks>
        [JsiiProperty(name: "overall", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Overall
        {
            get
            {
                return null;
            }
        }

        /// <summary>File path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#path ZeroTrustDevicePostureRule#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to check all disks for encryption.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#require_all ZeroTrustDevicePostureRule#require_all}
        /// </remarks>
        [JsiiProperty(name: "requireAll", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>For more details on risk level, refer to the Tanium documentation. Available values: "low", "medium", "high", "critical".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#risk_level ZeroTrustDevicePostureRule#risk_level}
        /// </remarks>
        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RiskLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>A value between 0-100 assigned to devices set by the 3rd party posture provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#score ZeroTrustDevicePostureRule#score}
        /// </remarks>
        [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Score
        {
            get
            {
                return null;
            }
        }

        /// <summary>Score Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#score_operator ZeroTrustDevicePostureRule#score_operator}
        /// </remarks>
        [JsiiProperty(name: "scoreOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScoreOperator
        {
            get
            {
                return null;
            }
        }

        /// <summary>SensorConfig.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#sensor_config ZeroTrustDevicePostureRule#sensor_config}
        /// </remarks>
        [JsiiProperty(name: "sensorConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SensorConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>SHA-256.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#sha256 ZeroTrustDevicePostureRule#sha256}
        /// </remarks>
        [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sha256
        {
            get
            {
                return null;
            }
        }

        /// <summary>For more details on state, please refer to the Crowdstrike documentation. Available values: "online", "offline", "unknown".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#state ZeroTrustDevicePostureRule#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of certificate Subject Alternative Names.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#subject_alternative_names ZeroTrustDevicePostureRule#subject_alternative_names}
        /// </remarks>
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubjectAlternativeNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Signing certificate thumbprint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#thumbprint ZeroTrustDevicePostureRule#thumbprint}
        /// </remarks>
        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Thumbprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>For more details on total score, refer to the Tanium documentation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#total_score ZeroTrustDevicePostureRule#total_score}
        /// </remarks>
        [JsiiProperty(name: "totalScore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalScore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of days that the antivirus should be updated within.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#update_window_days ZeroTrustDevicePostureRule#update_window_days}
        /// </remarks>
        [JsiiProperty(name: "updateWindowDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UpdateWindowDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version of OS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#version ZeroTrustDevicePostureRule#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#version_operator ZeroTrustDevicePostureRule#version_operator}
        /// </remarks>
        [JsiiProperty(name: "versionOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionOperator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDevicePostureRuleInput), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleInput")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Number of active threats.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#active_threats ZeroTrustDevicePostureRule#active_threats}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeThreats", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ActiveThreats
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>UUID of Cloudflare managed certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#certificate_id ZeroTrustDevicePostureRule#certificate_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of volume names to be checked for encryption.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#check_disks ZeroTrustDevicePostureRule#check_disks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkDisks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CheckDisks
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Confirm the certificate was not imported from another device.</summary>
            /// <remarks>
            /// We recommend keeping this enabled unless the certificate was deployed without a private key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#check_private_key ZeroTrustDevicePostureRule#check_private_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkPrivateKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CheckPrivateKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Common Name that is protected by the certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#cn ZeroTrustDevicePostureRule#cn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Compliance Status. Available values: "compliant", "noncompliant", "unknown", "notapplicable", "ingraceperiod", "error".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#compliance_status ZeroTrustDevicePostureRule#compliance_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "complianceStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComplianceStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Posture Integration ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#connection_id ZeroTrustDevicePostureRule#connection_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Count Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#count_operator ZeroTrustDevicePostureRule#count_operator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "countOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CountOperator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#domain ZeroTrustDevicePostureRule#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For more details on eid last seen, refer to the Tanium documentation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#eid_last_seen ZeroTrustDevicePostureRule#eid_last_seen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eidLastSeen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EidLastSeen
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#enabled ZeroTrustDevicePostureRule#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether or not file exists.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#exists ZeroTrustDevicePostureRule#exists}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exists", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Exists
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of values indicating purposes for which the certificate public key can be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#extended_key_usage ZeroTrustDevicePostureRule#extended_key_usage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extendedKeyUsage", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExtendedKeyUsage
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#id ZeroTrustDevicePostureRule#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether device is infected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#infected ZeroTrustDevicePostureRule#infected}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "infected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Infected
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether device is active.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#is_active ZeroTrustDevicePostureRule#is_active}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isActive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsActive
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Number of Issues.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#issue_count ZeroTrustDevicePostureRule#issue_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "issueCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IssueCount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For more details on last seen, please refer to the Crowdstrike documentation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#last_seen ZeroTrustDevicePostureRule#last_seen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastSeen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastSeen
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#locations ZeroTrustDevicePostureRule#locations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDevicePostureRule.ZeroTrustDevicePostureRuleInputLocations\"}", isOptional: true)]
            public cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleInputLocations? Locations
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDevicePostureRule.IZeroTrustDevicePostureRuleInputLocations?>();
            }

            /// <summary>Network status of device. Available values: "connected", "disconnected", "disconnecting", "connecting".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#network_status ZeroTrustDevicePostureRule#network_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Operating system. Available values: "windows", "linux", "mac", "android", "ios", "chromeos".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#operating_system ZeroTrustDevicePostureRule#operating_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Agent operational state. Available values: "na", "partially_disabled", "auto_fully_disabled", "fully_disabled", "auto_partially_disabled", "disabled_error", "db_corruption".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#operational_state ZeroTrustDevicePostureRule#operational_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operationalState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperationalState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#operator ZeroTrustDevicePostureRule#operator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Os Version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os ZeroTrustDevicePostureRule#os}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Os
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Operating System Distribution Name (linux only).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os_distro_name ZeroTrustDevicePostureRule#os_distro_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osDistroName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OsDistroName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Version of OS Distribution (linux only).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os_distro_revision ZeroTrustDevicePostureRule#os_distro_revision}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osDistroRevision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OsDistroRevision
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Additional operating system version details.</summary>
            /// <remarks>
            /// For Windows, the UBR (Update Build Revision). For Mac or iOS, the Product Version Extra. For Linux, the distribution name and version.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#os_version_extra ZeroTrustDevicePostureRule#os_version_extra}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osVersionExtra", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OsVersionExtra
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Overall.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#overall ZeroTrustDevicePostureRule#overall}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overall", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Overall
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>File path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#path ZeroTrustDevicePostureRule#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to check all disks for encryption.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#require_all ZeroTrustDevicePostureRule#require_all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireAll", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireAll
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>For more details on risk level, refer to the Tanium documentation. Available values: "low", "medium", "high", "critical".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#risk_level ZeroTrustDevicePostureRule#risk_level}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RiskLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A value between 0-100 assigned to devices set by the 3rd party posture provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#score ZeroTrustDevicePostureRule#score}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Score
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Score Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#score_operator ZeroTrustDevicePostureRule#score_operator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scoreOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScoreOperator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>SensorConfig.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#sensor_config ZeroTrustDevicePostureRule#sensor_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sensorConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SensorConfig
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>SHA-256.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#sha256 ZeroTrustDevicePostureRule#sha256}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sha256
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For more details on state, please refer to the Crowdstrike documentation. Available values: "online", "offline", "unknown".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#state ZeroTrustDevicePostureRule#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of certificate Subject Alternative Names.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#subject_alternative_names ZeroTrustDevicePostureRule#subject_alternative_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubjectAlternativeNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Signing certificate thumbprint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#thumbprint ZeroTrustDevicePostureRule#thumbprint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Thumbprint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For more details on total score, refer to the Tanium documentation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#total_score ZeroTrustDevicePostureRule#total_score}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalScore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalScore
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of days that the antivirus should be updated within.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#update_window_days ZeroTrustDevicePostureRule#update_window_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updateWindowDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UpdateWindowDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Version of OS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#version ZeroTrustDevicePostureRule#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Version Operator. Available values: "&lt;", "&lt;=", "&gt;", "&gt;=", "==".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_posture_rule#version_operator ZeroTrustDevicePostureRule#version_operator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionOperator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
