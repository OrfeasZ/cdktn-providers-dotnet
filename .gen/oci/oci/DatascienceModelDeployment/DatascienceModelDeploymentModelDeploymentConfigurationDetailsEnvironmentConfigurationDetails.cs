using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#environment_configuration_type DatascienceModelDeployment#environment_configuration_type}.</summary>
        [JsiiProperty(name: "environmentConfigurationType", typeJson: "{\"primitive\":\"string\"}")]
        public string EnvironmentConfigurationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#cmd DatascienceModelDeployment#cmd}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cmd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Cmd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#entrypoint DatascienceModelDeployment#entrypoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Entrypoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#environment_variables DatascienceModelDeployment#environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#health_check_port DatascienceModelDeployment#health_check_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#image DatascienceModelDeployment#image}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Image
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#image_digest DatascienceModelDeployment#image_digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageDigest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#server_port DatascienceModelDeployment#server_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ServerPort
        {
            get;
            set;
        }
    }
}
