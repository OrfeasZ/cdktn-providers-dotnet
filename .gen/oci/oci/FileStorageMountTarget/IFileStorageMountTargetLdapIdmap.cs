using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageMountTarget
{
    [JsiiInterface(nativeType: typeof(IFileStorageMountTargetLdapIdmap), fullyQualifiedName: "oci.fileStorageMountTarget.FileStorageMountTargetLdapIdmap")]
    public interface IFileStorageMountTargetLdapIdmap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#cache_lifetime_seconds FileStorageMountTarget#cache_lifetime_seconds}.</summary>
        [JsiiProperty(name: "cacheLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CacheLifetimeSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#cache_refresh_interval_seconds FileStorageMountTarget#cache_refresh_interval_seconds}.</summary>
        [JsiiProperty(name: "cacheRefreshIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CacheRefreshIntervalSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#group_search_base FileStorageMountTarget#group_search_base}.</summary>
        [JsiiProperty(name: "groupSearchBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupSearchBase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#negative_cache_lifetime_seconds FileStorageMountTarget#negative_cache_lifetime_seconds}.</summary>
        [JsiiProperty(name: "negativeCacheLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NegativeCacheLifetimeSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#outbound_connector1id FileStorageMountTarget#outbound_connector1id}.</summary>
        [JsiiProperty(name: "outboundConnector1Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundConnector1Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#outbound_connector2id FileStorageMountTarget#outbound_connector2id}.</summary>
        [JsiiProperty(name: "outboundConnector2Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundConnector2Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#schema_type FileStorageMountTarget#schema_type}.</summary>
        [JsiiProperty(name: "schemaType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#user_search_base FileStorageMountTarget#user_search_base}.</summary>
        [JsiiProperty(name: "userSearchBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserSearchBase
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageMountTargetLdapIdmap), fullyQualifiedName: "oci.fileStorageMountTarget.FileStorageMountTargetLdapIdmap")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageMountTarget.IFileStorageMountTargetLdapIdmap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#cache_lifetime_seconds FileStorageMountTarget#cache_lifetime_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CacheLifetimeSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#cache_refresh_interval_seconds FileStorageMountTarget#cache_refresh_interval_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheRefreshIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CacheRefreshIntervalSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#group_search_base FileStorageMountTarget#group_search_base}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupSearchBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupSearchBase
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#negative_cache_lifetime_seconds FileStorageMountTarget#negative_cache_lifetime_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "negativeCacheLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NegativeCacheLifetimeSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#outbound_connector1id FileStorageMountTarget#outbound_connector1id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundConnector1Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundConnector1Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#outbound_connector2id FileStorageMountTarget#outbound_connector2id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundConnector2Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundConnector2Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#schema_type FileStorageMountTarget#schema_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#user_search_base FileStorageMountTarget#user_search_base}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userSearchBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserSearchBase
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
