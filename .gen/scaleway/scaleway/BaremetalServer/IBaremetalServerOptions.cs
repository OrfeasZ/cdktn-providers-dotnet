using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.BaremetalServer
{
    [JsiiInterface(nativeType: typeof(IBaremetalServerOptions), fullyQualifiedName: "scaleway.baremetalServer.BaremetalServerOptions")]
    public interface IBaremetalServerOptions
    {
        /// <summary>IDs of the options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/baremetal_server#id BaremetalServer#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Auto expire the option after this date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/baremetal_server#expires_at BaremetalServer#expires_at}
        /// </remarks>
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpiresAt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBaremetalServerOptions), fullyQualifiedName: "scaleway.baremetalServer.BaremetalServerOptions")]
        internal sealed class _Proxy : DeputyBase, scaleway.BaremetalServer.IBaremetalServerOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IDs of the options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/baremetal_server#id BaremetalServer#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Auto expire the option after this date.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/baremetal_server#expires_at BaremetalServer#expires_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpiresAt
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
