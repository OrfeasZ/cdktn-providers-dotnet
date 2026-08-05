using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails")]
    public interface IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#environment_configuration_type DatascienceModelDeployment#environment_configuration_type}.</summary>
        [JsiiProperty(name: "environmentConfigurationType", typeJson: "{\"primitive\":\"string\"}")]
        string EnvironmentConfigurationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#cmd DatascienceModelDeployment#cmd}.</summary>
        [JsiiProperty(name: "cmd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Cmd
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_http_endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#custom_http_endpoints DatascienceModelDeployment#custom_http_endpoints}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customHttpEndpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomHttpEndpoints
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#default_environment_variables DatascienceModelDeployment#default_environment_variables}.</summary>
        [JsiiProperty(name: "defaultEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefaultEnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#entrypoint DatascienceModelDeployment#entrypoint}.</summary>
        [JsiiProperty(name: "entrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Entrypoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#environment_variables DatascienceModelDeployment#environment_variables}.</summary>
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#health_check_port DatascienceModelDeployment#health_check_port}.</summary>
        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#image DatascienceModelDeployment#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#image_digest DatascienceModelDeployment#image_digest}.</summary>
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageDigest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#image_signature_id DatascienceModelDeployment#image_signature_id}.</summary>
        [JsiiProperty(name: "imageSignatureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageSignatureId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#predict_api_specification DatascienceModelDeployment#predict_api_specification}.</summary>
        [JsiiProperty(name: "predictApiSpecification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PredictApiSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#server_port DatascienceModelDeployment#server_port}.</summary>
        [JsiiProperty(name: "serverPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ServerPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#environment_configuration_type DatascienceModelDeployment#environment_configuration_type}.</summary>
            [JsiiProperty(name: "environmentConfigurationType", typeJson: "{\"primitive\":\"string\"}")]
            public string EnvironmentConfigurationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#cmd DatascienceModelDeployment#cmd}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cmd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Cmd
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>custom_http_endpoints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#custom_http_endpoints DatascienceModelDeployment#custom_http_endpoints}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customHttpEndpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsCustomHttpEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomHttpEndpoints
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#default_environment_variables DatascienceModelDeployment#default_environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefaultEnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#entrypoint DatascienceModelDeployment#entrypoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Entrypoint
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#environment_variables DatascienceModelDeployment#environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#health_check_port DatascienceModelDeployment#health_check_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#image DatascienceModelDeployment#image}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Image
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#image_digest DatascienceModelDeployment#image_digest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageDigest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#image_signature_id DatascienceModelDeployment#image_signature_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageSignatureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageSignatureId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#predict_api_specification DatascienceModelDeployment#predict_api_specification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predictApiSpecification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PredictApiSpecification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_model_deployment#server_port DatascienceModelDeployment#server_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ServerPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
