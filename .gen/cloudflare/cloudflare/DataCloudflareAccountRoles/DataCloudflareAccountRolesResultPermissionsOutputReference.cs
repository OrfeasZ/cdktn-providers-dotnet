using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountRoles
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountRolesResultPermissionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountRolesResultPermissionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountRolesResultPermissionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountRolesResultPermissionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "analytics", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsAnalyticsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsAnalyticsOutputReference Analytics
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "billing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsBillingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsBillingOutputReference Billing
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsBillingOutputReference>()!;
        }

        [JsiiProperty(name: "cachePurge", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsCachePurgeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsCachePurgeOutputReference CachePurge
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsCachePurgeOutputReference>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsDnsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsDnsOutputReference Dns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsDnsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsDnsRecordsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsDnsRecordsOutputReference DnsRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsDnsRecordsOutputReference>()!;
        }

        [JsiiProperty(name: "lb", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsLbOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsLbOutputReference Lb
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsLbOutputReference>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsLogsOutputReference>()!;
        }

        [JsiiProperty(name: "organization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsOrganizationOutputReference Organization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsSslOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsSslOutputReference Ssl
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsSslOutputReference>()!;
        }

        [JsiiProperty(name: "waf", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsWafOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsWafOutputReference Waf
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsWafOutputReference>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsZonesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsZonesOutputReference Zones
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsZonesOutputReference>()!;
        }

        [JsiiProperty(name: "zoneSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsZoneSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsZoneSettingsOutputReference ZoneSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissionsZoneSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountRoles.DataCloudflareAccountRolesResultPermissions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountRoles.IDataCloudflareAccountRolesResultPermissions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountRoles.IDataCloudflareAccountRolesResultPermissions?>();
            set => SetInstanceProperty(value);
        }
    }
}
