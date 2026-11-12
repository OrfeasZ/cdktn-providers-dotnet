using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiInterface(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration")]
    public interface IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#instance_shape DatascienceComputeTarget#instance_shape}.</summary>
        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#boot_volume_size_in_gbs DatascienceComputeTarget#boot_volume_size_in_gbs}.</summary>
        [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BootVolumeSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#capacity_reservation_ids DatascienceComputeTarget#capacity_reservation_ids}.</summary>
        [JsiiProperty(name: "capacityReservationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CapacityReservationIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_shape_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#instance_shape_details DatascienceComputeTarget#instance_shape_details}
        /// </remarks>
        [JsiiProperty(name: "instanceShapeDetails", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails? InstanceShapeDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#network_configuration_details DatascienceComputeTarget#network_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "networkConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationNetworkConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationNetworkConfigurationDetails? NetworkConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#instance_shape DatascienceComputeTarget#instance_shape}.</summary>
            [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#boot_volume_size_in_gbs DatascienceComputeTarget#boot_volume_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BootVolumeSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#capacity_reservation_ids DatascienceComputeTarget#capacity_reservation_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CapacityReservationIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>instance_shape_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#instance_shape_details DatascienceComputeTarget#instance_shape_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceShapeDetails", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails\"}", isOptional: true)]
            public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails? InstanceShapeDetails
            {
                get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails?>();
            }

            /// <summary>network_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_compute_target#network_configuration_details DatascienceComputeTarget#network_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationNetworkConfigurationDetails\"}", isOptional: true)]
            public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationNetworkConfigurationDetails? NetworkConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationNetworkConfigurationDetails?>();
            }
        }
    }
}
