using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorkerLogDestinationLogtail), fullyQualifiedName: "digitalocean.app.AppSpecWorkerLogDestinationLogtail")]
    public interface IAppSpecWorkerLogDestinationLogtail
    {
        /// <summary>Logtail token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#token App#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorkerLogDestinationLogtail), fullyQualifiedName: "digitalocean.app.AppSpecWorkerLogDestinationLogtail")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorkerLogDestinationLogtail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Logtail token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#token App#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
