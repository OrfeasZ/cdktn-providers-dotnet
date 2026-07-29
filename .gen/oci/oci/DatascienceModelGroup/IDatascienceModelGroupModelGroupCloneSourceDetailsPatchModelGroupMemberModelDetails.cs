using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails")]
    public interface IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datascience_model_group#items DatascienceModelGroup#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/datascience_model_group#items DatascienceModelGroup#items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItems" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
