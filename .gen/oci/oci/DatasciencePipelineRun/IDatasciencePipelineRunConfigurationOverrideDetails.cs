using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineRunConfigurationOverrideDetails), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunConfigurationOverrideDetails")]
    public interface IDatasciencePipelineRunConfigurationOverrideDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#type DatasciencePipelineRun#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#command_line_arguments DatasciencePipelineRun#command_line_arguments}.</summary>
        [JsiiProperty(name: "commandLineArguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommandLineArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#environment_variables DatasciencePipelineRun#environment_variables}.</summary>
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#maximum_runtime_in_minutes DatasciencePipelineRun#maximum_runtime_in_minutes}.</summary>
        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumRuntimeInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineRunConfigurationOverrideDetails), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunConfigurationOverrideDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipelineRun.IDatasciencePipelineRunConfigurationOverrideDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#type DatasciencePipelineRun#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#command_line_arguments DatasciencePipelineRun#command_line_arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commandLineArguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommandLineArguments
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#environment_variables DatasciencePipelineRun#environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#maximum_runtime_in_minutes DatasciencePipelineRun#maximum_runtime_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumRuntimeInMinutes
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
