using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceServer
{
    [JsiiInterface(nativeType: typeof(IInstanceServerFilesystems), fullyQualifiedName: "scaleway.instanceServer.InstanceServerFilesystems")]
    public interface IInstanceServerFilesystems
    {
        /// <summary>The filesystem ID attached to the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_server#filesystem_id InstanceServer#filesystem_id}
        /// </remarks>
        [JsiiProperty(name: "filesystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilesystemId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceServerFilesystems), fullyQualifiedName: "scaleway.instanceServer.InstanceServerFilesystems")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceServer.IInstanceServerFilesystems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The filesystem ID attached to the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_server#filesystem_id InstanceServer#filesystem_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilesystemId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
