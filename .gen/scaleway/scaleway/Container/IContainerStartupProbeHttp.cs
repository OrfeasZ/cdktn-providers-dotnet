using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    [JsiiInterface(nativeType: typeof(IContainerStartupProbeHttp), fullyQualifiedName: "scaleway.container.ContainerStartupProbeHttp")]
    public interface IContainerStartupProbeHttp
    {
        /// <summary>Path to use for the HTTP health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#path Container#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerStartupProbeHttp), fullyQualifiedName: "scaleway.container.ContainerStartupProbeHttp")]
        internal sealed class _Proxy : DeputyBase, scaleway.Container.IContainerStartupProbeHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path to use for the HTTP health check.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#path Container#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
