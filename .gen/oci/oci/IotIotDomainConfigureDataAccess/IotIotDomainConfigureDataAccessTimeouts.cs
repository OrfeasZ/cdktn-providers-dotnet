using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainConfigureDataAccess
{
    [JsiiByValue(fqn: "oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeouts")]
    public class IotIotDomainConfigureDataAccessTimeouts : oci.IotIotDomainConfigureDataAccess.IIotIotDomainConfigureDataAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/iot_iot_domain_configure_data_access#create IotIotDomainConfigureDataAccess#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/iot_iot_domain_configure_data_access#delete IotIotDomainConfigureDataAccess#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/iot_iot_domain_configure_data_access#update IotIotDomainConfigureDataAccess#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
