using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration")]
    public class DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration : oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#instance_shape DatascienceComputeTarget#instance_shape}.</summary>
        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceShape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#boot_volume_size_in_gbs DatascienceComputeTarget#boot_volume_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BootVolumeSizeInGbs
        {
            get;
            set;
        }

        /// <summary>instance_shape_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#instance_shape_details DatascienceComputeTarget#instance_shape_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceShapeDetails", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails\"}", isOptional: true)]
        public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails? InstanceShapeDetails
        {
            get;
            set;
        }
    }
}
