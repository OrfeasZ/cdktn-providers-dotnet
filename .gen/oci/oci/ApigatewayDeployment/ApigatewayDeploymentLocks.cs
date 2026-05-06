using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentLocks")]
    public class ApigatewayDeploymentLocks : oci.ApigatewayDeployment.IApigatewayDeploymentLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#message ApigatewayDeployment#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }
    }
}
