using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceReplaceNodeAction
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceReplaceNodeActionTimeouts), fullyQualifiedName: "oci.bdsBdsInstanceReplaceNodeAction.BdsBdsInstanceReplaceNodeActionTimeouts")]
    public interface IBdsBdsInstanceReplaceNodeActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_replace_node_action#create BdsBdsInstanceReplaceNodeAction#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceReplaceNodeActionTimeouts), fullyQualifiedName: "oci.bdsBdsInstanceReplaceNodeAction.BdsBdsInstanceReplaceNodeActionTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceReplaceNodeAction.IBdsBdsInstanceReplaceNodeActionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_replace_node_action#create BdsBdsInstanceReplaceNodeAction#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
