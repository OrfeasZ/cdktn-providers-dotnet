using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainGroupConfigureDataAccess
{
    [JsiiByValue(fqn: "oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeouts")]
    public class IotIotDomainGroupConfigureDataAccessTimeouts : oci.IotIotDomainGroupConfigureDataAccess.IIotIotDomainGroupConfigureDataAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/iot_iot_domain_group_configure_data_access#create IotIotDomainGroupConfigureDataAccess#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/iot_iot_domain_group_configure_data_access#delete IotIotDomainGroupConfigureDataAccess#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/iot_iot_domain_group_configure_data_access#update IotIotDomainGroupConfigureDataAccess#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
