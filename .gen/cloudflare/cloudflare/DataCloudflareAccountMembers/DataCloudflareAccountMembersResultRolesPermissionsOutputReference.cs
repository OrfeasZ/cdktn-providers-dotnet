using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountMembers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountMembersResultRolesPermissionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountMembersResultRolesPermissionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountMembersResultRolesPermissionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountMembersResultRolesPermissionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "analytics", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsAnalyticsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsAnalyticsOutputReference Analytics
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "billing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsBillingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsBillingOutputReference Billing
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsBillingOutputReference>()!;
        }

        [JsiiProperty(name: "cachePurge", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsCachePurgeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsCachePurgeOutputReference CachePurge
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsCachePurgeOutputReference>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsDnsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsDnsOutputReference Dns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsDnsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsDnsRecordsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsDnsRecordsOutputReference DnsRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsDnsRecordsOutputReference>()!;
        }

        [JsiiProperty(name: "lb", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsLbOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsLbOutputReference Lb
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsLbOutputReference>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsLogsOutputReference>()!;
        }

        [JsiiProperty(name: "organization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsOrganizationOutputReference Organization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsSslOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsSslOutputReference Ssl
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsSslOutputReference>()!;
        }

        [JsiiProperty(name: "waf", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsWafOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsWafOutputReference Waf
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsWafOutputReference>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsZonesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsZonesOutputReference Zones
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsZonesOutputReference>()!;
        }

        [JsiiProperty(name: "zoneSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsZoneSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsZoneSettingsOutputReference ZoneSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissionsZoneSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesPermissions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountMembers.IDataCloudflareAccountMembersResultRolesPermissions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.IDataCloudflareAccountMembersResultRolesPermissions?>();
            set => SetInstanceProperty(value);
        }
    }
}
