using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints")]
    public interface IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datascience_model_deployment#endpoint_uri_suffix DatascienceModelDeployment#endpoint_uri_suffix}.</summary>
        [JsiiProperty(name: "endpointUriSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointUriSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datascience_model_deployment#http_methods DatascienceModelDeployment#http_methods}.</summary>
        [JsiiProperty(name: "httpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HttpMethods
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datascience_model_deployment#endpoint_uri_suffix DatascienceModelDeployment#endpoint_uri_suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointUriSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointUriSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/datascience_model_deployment#http_methods DatascienceModelDeployment#http_methods}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HttpMethods
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
