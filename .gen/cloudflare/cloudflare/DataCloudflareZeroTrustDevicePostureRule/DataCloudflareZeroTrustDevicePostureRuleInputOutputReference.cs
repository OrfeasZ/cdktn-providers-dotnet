using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDevicePostureRule
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDevicePostureRule.DataCloudflareZeroTrustDevicePostureRuleInputOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDevicePostureRule.DataCloudflareZeroTrustDevicePostureRuleInputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDevicePostureRuleInputOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDevicePostureRuleInputOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDevicePostureRuleInputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDevicePostureRuleInputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeThreats", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActiveThreats
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checkDisks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CheckDisks
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "checkPrivateKey", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CheckPrivateKey
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "complianceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComplianceStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "countOperator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CountOperator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eidLastSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EidLastSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "exists", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Exists
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "extendedKeyUsage", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExtendedKeyUsage
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Infected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isActive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsActive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issueCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssueCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDevicePostureRule.DataCloudflareZeroTrustDevicePostureRuleInputLocationsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDevicePostureRule.DataCloudflareZeroTrustDevicePostureRuleInputLocationsOutputReference Locations
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDevicePostureRule.DataCloudflareZeroTrustDevicePostureRuleInputLocationsOutputReference>()!;
        }

        [JsiiProperty(name: "networkStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationalState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationalState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Os
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osDistroName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsDistroName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osDistroRevision", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsDistroRevision
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osVersionExtra", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsVersionExtra
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overall", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Overall
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requireAll", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireAll
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RiskLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Score
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scoreOperator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScoreOperator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sensorConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensorConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sha256
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubjectAlternativeNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Thumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "updateWindowDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UpdateWindowDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionOperator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionOperator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDevicePostureRule.DataCloudflareZeroTrustDevicePostureRuleInput\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDevicePostureRule.IDataCloudflareZeroTrustDevicePostureRuleInput? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDevicePostureRule.IDataCloudflareZeroTrustDevicePostureRuleInput?>();
            set => SetInstanceProperty(value);
        }
    }
}
