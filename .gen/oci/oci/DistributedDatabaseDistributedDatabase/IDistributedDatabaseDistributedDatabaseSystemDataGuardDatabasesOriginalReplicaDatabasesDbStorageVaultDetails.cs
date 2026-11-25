using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesOriginalReplicaDatabasesDbStorageVaultDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesOriginalReplicaDatabasesDbStorageVaultDetails")]
    public interface IDistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesOriginalReplicaDatabasesDbStorageVaultDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#additional_flash_cache_in_percent DistributedDatabaseDistributedDatabase#additional_flash_cache_in_percent}.</summary>
        [JsiiProperty(name: "additionalFlashCacheInPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AdditionalFlashCacheInPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#autoscale_limit_in_gbs DistributedDatabaseDistributedDatabase#autoscale_limit_in_gbs}.</summary>
        [JsiiProperty(name: "autoscaleLimitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoscaleLimitInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#compartment_id DistributedDatabaseDistributedDatabase#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#high_capacity_database_storage DistributedDatabaseDistributedDatabase#high_capacity_database_storage}.</summary>
        [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HighCapacityDatabaseStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#is_autoscale_enabled DistributedDatabaseDistributedDatabase#is_autoscale_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoscaleEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoscaleEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#subscription_id DistributedDatabaseDistributedDatabase#subscription_id}.</summary>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubscriptionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesOriginalReplicaDatabasesDbStorageVaultDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesOriginalReplicaDatabasesDbStorageVaultDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesOriginalReplicaDatabasesDbStorageVaultDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#additional_flash_cache_in_percent DistributedDatabaseDistributedDatabase#additional_flash_cache_in_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalFlashCacheInPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AdditionalFlashCacheInPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#autoscale_limit_in_gbs DistributedDatabaseDistributedDatabase#autoscale_limit_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoscaleLimitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoscaleLimitInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#compartment_id DistributedDatabaseDistributedDatabase#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#high_capacity_database_storage DistributedDatabaseDistributedDatabase#high_capacity_database_storage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HighCapacityDatabaseStorage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#is_autoscale_enabled DistributedDatabaseDistributedDatabase#is_autoscale_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoscaleEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoscaleEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#subscription_id DistributedDatabaseDistributedDatabase#subscription_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
