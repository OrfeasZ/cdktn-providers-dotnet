using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorkerLogDestinationPapertrail), fullyQualifiedName: "digitalocean.app.AppSpecWorkerLogDestinationPapertrail")]
    public interface IAppSpecWorkerLogDestinationPapertrail
    {
        /// <summary>Papertrail syslog endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#endpoint App#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorkerLogDestinationPapertrail), fullyQualifiedName: "digitalocean.app.AppSpecWorkerLogDestinationPapertrail")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorkerLogDestinationPapertrail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Papertrail syslog endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#endpoint App#endpoint}
            /// </remarks>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
