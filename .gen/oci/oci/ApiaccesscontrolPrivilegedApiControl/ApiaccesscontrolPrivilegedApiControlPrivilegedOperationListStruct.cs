using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiControl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apiaccesscontrolPrivilegedApiControl.ApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct")]
    public class ApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct : oci.ApiaccesscontrolPrivilegedApiControl.IApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#api_name ApiaccesscontrolPrivilegedApiControl#api_name}.</summary>
        [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#attribute_names ApiaccesscontrolPrivilegedApiControl#attribute_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AttributeNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#entity_type ApiaccesscontrolPrivilegedApiControl#entity_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntityType
        {
            get;
            set;
        }
    }
}
