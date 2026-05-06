using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildRun
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildRunBuildRunArguments), fullyQualifiedName: "oci.devopsBuildRun.DevopsBuildRunBuildRunArguments")]
    public interface IDevopsBuildRunBuildRunArguments
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#items DevopsBuildRun#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildRunArgumentsItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildRunBuildRunArguments), fullyQualifiedName: "oci.devopsBuildRun.DevopsBuildRunBuildRunArguments")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildRun.IDevopsBuildRunBuildRunArguments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#items DevopsBuildRun#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildRun.DevopsBuildRunBuildRunArgumentsItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
