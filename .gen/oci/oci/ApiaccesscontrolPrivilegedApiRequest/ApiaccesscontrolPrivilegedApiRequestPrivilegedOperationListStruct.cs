using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct")]
    public class ApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct : oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#api_name ApiaccesscontrolPrivilegedApiRequest#api_name}.</summary>
        [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#attribute_names ApiaccesscontrolPrivilegedApiRequest#attribute_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AttributeNames
        {
            get;
            set;
        }
    }
}
