using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_model_deployment#endpoint_uri_suffix DatascienceModelDeployment#endpoint_uri_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointUriSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointUriSuffix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_model_deployment#http_methods DatascienceModelDeployment#http_methods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HttpMethods
        {
            get;
            set;
        }
    }
}
