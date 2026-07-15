using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiInterface(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration")]
    public interface IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_compute_target#instance_shape DatascienceComputeTarget#instance_shape}.</summary>
        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_compute_target#boot_volume_size_in_gbs DatascienceComputeTarget#boot_volume_size_in_gbs}.</summary>
        [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BootVolumeSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_shape_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_compute_target#instance_shape_details DatascienceComputeTarget#instance_shape_details}
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

        [JsiiTypeProxy(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_compute_target#instance_shape DatascienceComputeTarget#instance_shape}.</summary>
            [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceShape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_compute_target#boot_volume_size_in_gbs DatascienceComputeTarget#boot_volume_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BootVolumeSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>instance_shape_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_compute_target#instance_shape_details DatascienceComputeTarget#instance_shape_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceShapeDetails", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails\"}", isOptional: true)]
            public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails? InstanceShapeDetails
            {
                get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails?>();
            }
        }
    }
}
