using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelGroupMemberModelEntries), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntries")]
    public interface IDatascienceModelGroupMemberModelEntries
    {
        /// <summary>member_model_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#member_model_details DatascienceModelGroup#member_model_details}
        /// </remarks>
        [JsiiProperty(name: "memberModelDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MemberModelDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelGroupMemberModelEntries), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntries")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>member_model_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#member_model_details DatascienceModelGroup#member_model_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memberModelDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MemberModelDetails
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
