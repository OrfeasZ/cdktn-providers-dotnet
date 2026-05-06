using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnics")]
    public class CoreInstanceConfigurationInstanceDetailsSecondaryVnics : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnics
    {
        /// <summary>create_vnic_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#create_vnic_details CoreInstanceConfiguration#create_vnic_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails? CreateVnicDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#display_name CoreInstanceConfiguration#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#nic_index CoreInstanceConfiguration#nic_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nicIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NicIndex
        {
            get;
            set;
        }
    }
}
