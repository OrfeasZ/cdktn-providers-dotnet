using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayDomainName
{
    [JsiiByValue(fqn: "aws.apiGatewayDomainName.ApiGatewayDomainNameTimeouts")]
    public class ApiGatewayDomainNameTimeouts : aws.ApiGatewayDomainName.IApiGatewayDomainNameTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/api_gateway_domain_name#create ApiGatewayDomainName#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/api_gateway_domain_name#update ApiGatewayDomainName#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
