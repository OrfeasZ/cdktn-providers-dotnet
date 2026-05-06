using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewaySubscriber
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewaySubscriber.ApigatewaySubscriberClients")]
    public class ApigatewaySubscriberClients : oci.ApigatewaySubscriber.IApigatewaySubscriberClients
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_subscriber#name ApigatewaySubscriber#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_subscriber#token ApigatewaySubscriber#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }
    }
}
