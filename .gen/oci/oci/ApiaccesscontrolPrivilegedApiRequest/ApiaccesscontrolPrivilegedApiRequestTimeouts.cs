using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiRequest
{
    [JsiiByValue(fqn: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestTimeouts")]
    public class ApiaccesscontrolPrivilegedApiRequestTimeouts : oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#create ApiaccesscontrolPrivilegedApiRequest#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#delete ApiaccesscontrolPrivilegedApiRequest#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#update ApiaccesscontrolPrivilegedApiRequest#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
