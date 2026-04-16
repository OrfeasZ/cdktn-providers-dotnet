using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountMember
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountMemberRolesPermissionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountMemberRolesPermissionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountMemberRolesPermissionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountMemberRolesPermissionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "analytics", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsAnalyticsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsAnalyticsOutputReference Analytics
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "billing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsBillingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsBillingOutputReference Billing
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsBillingOutputReference>()!;
        }

        [JsiiProperty(name: "cachePurge", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsCachePurgeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsCachePurgeOutputReference CachePurge
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsCachePurgeOutputReference>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsDnsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsDnsOutputReference Dns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsDnsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsDnsRecordsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsDnsRecordsOutputReference DnsRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsDnsRecordsOutputReference>()!;
        }

        [JsiiProperty(name: "lb", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsLbOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsLbOutputReference Lb
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsLbOutputReference>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsLogsOutputReference>()!;
        }

        [JsiiProperty(name: "organization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsOrganizationOutputReference Organization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsSslOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsSslOutputReference Ssl
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsSslOutputReference>()!;
        }

        [JsiiProperty(name: "waf", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsWafOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsWafOutputReference Waf
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsWafOutputReference>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsZonesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsZonesOutputReference Zones
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsZonesOutputReference>()!;
        }

        [JsiiProperty(name: "zoneSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsZoneSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsZoneSettingsOutputReference ZoneSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissionsZoneSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMember.DataCloudflareAccountMemberRolesPermissions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountMember.IDataCloudflareAccountMemberRolesPermissions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMember.IDataCloudflareAccountMemberRolesPermissions?>();
            set => SetInstanceProperty(value);
        }
    }
}
