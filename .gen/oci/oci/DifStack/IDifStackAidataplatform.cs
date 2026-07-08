using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackAidataplatform), fullyQualifiedName: "oci.difStack.DifStackAidataplatform")]
    public interface IDifStackAidataplatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#default_workspace_name DifStack#default_workspace_name}.</summary>
        [JsiiProperty(name: "defaultWorkspaceName", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultWorkspaceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackAidataplatform), fullyQualifiedName: "oci.difStack.DifStackAidataplatform")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackAidataplatform
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#default_workspace_name DifStack#default_workspace_name}.</summary>
            [JsiiProperty(name: "defaultWorkspaceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultWorkspaceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
