using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiInterface(nativeType: typeof(IDevopsTriggerActions), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActions")]
    public interface IDevopsTriggerActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#build_pipeline_id DevopsTrigger#build_pipeline_id}.</summary>
        [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        string BuildPipelineId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#type DevopsTrigger#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#filter DevopsTrigger#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsTrigger.IDevopsTriggerActionsFilter? Filter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsTriggerActions), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActions")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsTrigger.IDevopsTriggerActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#build_pipeline_id DevopsTrigger#build_pipeline_id}.</summary>
            [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
            public string BuildPipelineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#type DevopsTrigger#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#filter DevopsTrigger#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilter\"}", isOptional: true)]
            public oci.DevopsTrigger.IDevopsTriggerActionsFilter? Filter
            {
                get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilter?>();
            }
        }
    }
}
