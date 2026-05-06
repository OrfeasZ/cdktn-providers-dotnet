using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelGroupMemberModelEntriesMemberModelDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails")]
    public interface IDatascienceModelGroupMemberModelEntriesMemberModelDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#inference_key DatascienceModelGroup#inference_key}.</summary>
        [JsiiProperty(name: "inferenceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InferenceKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_id DatascienceModelGroup#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelGroupMemberModelEntriesMemberModelDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntriesMemberModelDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#inference_key DatascienceModelGroup#inference_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InferenceKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#model_id DatascienceModelGroup#model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
