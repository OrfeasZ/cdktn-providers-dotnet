using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiInterface(nativeType: typeof(IDevopsTriggerActionsFilterExcludeFileFilter), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter")]
    public interface IDevopsTriggerActionsFilterExcludeFileFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_paths DevopsTrigger#file_paths}.</summary>
        [JsiiProperty(name: "filePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FilePaths
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsTriggerActionsFilterExcludeFileFilter), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_paths DevopsTrigger#file_paths}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FilePaths
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
