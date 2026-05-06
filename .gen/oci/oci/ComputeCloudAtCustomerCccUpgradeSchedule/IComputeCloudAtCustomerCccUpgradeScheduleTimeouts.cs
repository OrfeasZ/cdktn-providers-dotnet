using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ComputeCloudAtCustomerCccUpgradeSchedule
{
    [JsiiInterface(nativeType: typeof(IComputeCloudAtCustomerCccUpgradeScheduleTimeouts), fullyQualifiedName: "oci.computeCloudAtCustomerCccUpgradeSchedule.ComputeCloudAtCustomerCccUpgradeScheduleTimeouts")]
    public interface IComputeCloudAtCustomerCccUpgradeScheduleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#create ComputeCloudAtCustomerCccUpgradeSchedule#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#delete ComputeCloudAtCustomerCccUpgradeSchedule#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#update ComputeCloudAtCustomerCccUpgradeSchedule#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeCloudAtCustomerCccUpgradeScheduleTimeouts), fullyQualifiedName: "oci.computeCloudAtCustomerCccUpgradeSchedule.ComputeCloudAtCustomerCccUpgradeScheduleTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.ComputeCloudAtCustomerCccUpgradeSchedule.IComputeCloudAtCustomerCccUpgradeScheduleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#create ComputeCloudAtCustomerCccUpgradeSchedule#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#delete ComputeCloudAtCustomerCccUpgradeSchedule#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#update ComputeCloudAtCustomerCccUpgradeSchedule#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
