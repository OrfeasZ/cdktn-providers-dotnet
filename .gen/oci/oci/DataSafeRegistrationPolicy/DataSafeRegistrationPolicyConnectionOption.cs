using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeRegistrationPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeRegistrationPolicy.DataSafeRegistrationPolicyConnectionOption")]
    public class DataSafeRegistrationPolicyConnectionOption : oci.DataSafeRegistrationPolicy.IDataSafeRegistrationPolicyConnectionOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_registration_policy#connection_type DataSafeRegistrationPolicy#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_registration_policy#identifiers DataSafeRegistrationPolicy#identifiers}.</summary>
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Identifiers
        {
            get;
            set;
        }
    }
}
