using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesInsertDg
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseDbStorageVaultDetails")]
    public class DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseDbStorageVaultDetails : oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseDbStorageVaultDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#additional_flash_cache_in_percent DistributedDatabaseDistributedDatabasesInsertDg#additional_flash_cache_in_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalFlashCacheInPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdditionalFlashCacheInPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#autoscale_limit_in_gbs DistributedDatabaseDistributedDatabasesInsertDg#autoscale_limit_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscaleLimitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoscaleLimitInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#compartment_id DistributedDatabaseDistributedDatabasesInsertDg#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#high_capacity_database_storage DistributedDatabaseDistributedDatabasesInsertDg#high_capacity_database_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HighCapacityDatabaseStorage
        {
            get;
            set;
        }

        private object? _isAutoscaleEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#is_autoscale_enabled DistributedDatabaseDistributedDatabasesInsertDg#is_autoscale_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoscaleEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoscaleEnabled
        {
            get => _isAutoscaleEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAutoscaleEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#subscription_id DistributedDatabaseDistributedDatabasesInsertDg#subscription_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubscriptionId
        {
            get;
            set;
        }
    }
}
