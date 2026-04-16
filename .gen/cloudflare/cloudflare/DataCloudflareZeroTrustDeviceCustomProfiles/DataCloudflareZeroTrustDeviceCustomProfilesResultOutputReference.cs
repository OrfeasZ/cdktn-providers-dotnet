using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustDeviceCustomProfilesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustDeviceCustomProfilesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDeviceCustomProfilesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDeviceCustomProfilesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedToLeave", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowedToLeave
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowModeSwitch", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowModeSwitch
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowUpdates", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowUpdates
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autoConnect", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutoConnect
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "captivePortal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CaptivePortal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "default", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Default
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableAutoFallback", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DisableAutoFallback
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultExcludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultExcludeList Exclude
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultExcludeList>()!;
        }

        [JsiiProperty(name: "excludeOfficeIps", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ExcludeOfficeIps
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "fallbackDomains", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultFallbackDomainsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultFallbackDomainsList FallbackDomains
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultFallbackDomainsList>()!;
        }

        [JsiiProperty(name: "gatewayUniqueId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayUniqueId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultIncludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultIncludeList Include
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultIncludeList>()!;
        }

        [JsiiProperty(name: "lanAllowMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LanAllowMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lanAllowSubnetSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LanAllowSubnetSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Match
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Precedence
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "registerInterfaceIpWithDns", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RegisterInterfaceIpWithDns
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sccmVpnBoundarySupport", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SccmVpnBoundarySupport
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "serviceModeV2", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference ServiceModeV2
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultServiceModeV2OutputReference>()!;
        }

        [JsiiProperty(name: "supportUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "switchLocked", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SwitchLocked
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "targetTests", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultTargetTestsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultTargetTestsList TargetTests
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResultTargetTestsList>()!;
        }

        [JsiiProperty(name: "tunnelProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TunnelProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDeviceCustomProfiles.DataCloudflareZeroTrustDeviceCustomProfilesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.IDataCloudflareZeroTrustDeviceCustomProfilesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDeviceCustomProfiles.IDataCloudflareZeroTrustDeviceCustomProfilesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
