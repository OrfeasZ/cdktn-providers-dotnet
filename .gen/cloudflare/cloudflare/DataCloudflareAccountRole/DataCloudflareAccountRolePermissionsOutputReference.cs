using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountRole
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountRolePermissionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountRolePermissionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountRolePermissionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountRolePermissionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "analytics", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsAnalyticsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsAnalyticsOutputReference Analytics
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "billing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsBillingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsBillingOutputReference Billing
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsBillingOutputReference>()!;
        }

        [JsiiProperty(name: "cachePurge", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsCachePurgeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsCachePurgeOutputReference CachePurge
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsCachePurgeOutputReference>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsDnsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsDnsOutputReference Dns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsDnsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsDnsRecordsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsDnsRecordsOutputReference DnsRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsDnsRecordsOutputReference>()!;
        }

        [JsiiProperty(name: "lb", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsLbOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsLbOutputReference Lb
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsLbOutputReference>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsLogsOutputReference>()!;
        }

        [JsiiProperty(name: "organization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsOrganizationOutputReference Organization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsSslOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsSslOutputReference Ssl
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsSslOutputReference>()!;
        }

        [JsiiProperty(name: "waf", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsWafOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsWafOutputReference Waf
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsWafOutputReference>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsZonesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsZonesOutputReference Zones
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsZonesOutputReference>()!;
        }

        [JsiiProperty(name: "zoneSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissionsZoneSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsZoneSettingsOutputReference ZoneSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.DataCloudflareAccountRolePermissionsZoneSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRole.DataCloudflareAccountRolePermissions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountRole.IDataCloudflareAccountRolePermissions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRole.IDataCloudflareAccountRolePermissions?>();
            set => SetInstanceProperty(value);
        }
    }
}
