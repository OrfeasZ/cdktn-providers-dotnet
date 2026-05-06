using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails")]
    public interface IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#memory_in_gbs DatasciencePipeline#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#memory_in_gbs_parameterized DatasciencePipeline#memory_in_gbs_parameterized}.</summary>
        [JsiiProperty(name: "memoryInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MemoryInGbsParameterized
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#ocpus DatasciencePipeline#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ocpus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#ocpus_parameterized DatasciencePipeline#ocpus_parameterized}.</summary>
        [JsiiProperty(name: "ocpusParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OcpusParameterized
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#memory_in_gbs DatasciencePipeline#memory_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#memory_in_gbs_parameterized DatasciencePipeline#memory_in_gbs_parameterized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MemoryInGbsParameterized
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#ocpus DatasciencePipeline#ocpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ocpus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#ocpus_parameterized DatasciencePipeline#ocpus_parameterized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpusParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OcpusParameterized
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
