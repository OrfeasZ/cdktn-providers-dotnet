using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiPlatformApiPlatformInstance
{
    [JsiiByValue(fqn: "oci.apiPlatformApiPlatformInstance.ApiPlatformApiPlatformInstanceTimeouts")]
    public class ApiPlatformApiPlatformInstanceTimeouts : oci.ApiPlatformApiPlatformInstance.IApiPlatformApiPlatformInstanceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/api_platform_api_platform_instance#create ApiPlatformApiPlatformInstance#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/api_platform_api_platform_instance#delete ApiPlatformApiPlatformInstance#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
