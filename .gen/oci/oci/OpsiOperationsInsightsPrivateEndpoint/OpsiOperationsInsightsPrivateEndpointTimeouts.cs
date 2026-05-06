using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiOperationsInsightsPrivateEndpoint
{
    [JsiiByValue(fqn: "oci.opsiOperationsInsightsPrivateEndpoint.OpsiOperationsInsightsPrivateEndpointTimeouts")]
    public class OpsiOperationsInsightsPrivateEndpointTimeouts : oci.OpsiOperationsInsightsPrivateEndpoint.IOpsiOperationsInsightsPrivateEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_private_endpoint#create OpsiOperationsInsightsPrivateEndpoint#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_private_endpoint#delete OpsiOperationsInsightsPrivateEndpoint#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_private_endpoint#update OpsiOperationsInsightsPrivateEndpoint#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
