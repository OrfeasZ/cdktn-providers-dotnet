using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorkerLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecWorkerLogDestination")]
    public interface IAppSpecWorkerLogDestination
    {
        /// <summary>Name of the log destination.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>datadog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#datadog App#datadog}
        /// </remarks>
        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationDatadog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerLogDestinationDatadog? Datadog
        {
            get
            {
                return null;
            }
        }

        /// <summary>logtail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#logtail App#logtail}
        /// </remarks>
        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationLogtail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerLogDestinationLogtail? Logtail
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#open_search App#open_search}
        /// </remarks>
        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationOpenSearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerLogDestinationOpenSearch? OpenSearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>papertrail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#papertrail App#papertrail}
        /// </remarks>
        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationPapertrail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerLogDestinationPapertrail? Papertrail
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorkerLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecWorkerLogDestination")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorkerLogDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the log destination.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>datadog block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#datadog App#datadog}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationDatadog\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerLogDestinationDatadog? Datadog
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationDatadog?>();
            }

            /// <summary>logtail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#logtail App#logtail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationLogtail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerLogDestinationLogtail? Logtail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationLogtail?>();
            }

            /// <summary>open_search block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#open_search App#open_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationOpenSearch\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerLogDestinationOpenSearch? OpenSearch
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationOpenSearch?>();
            }

            /// <summary>papertrail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#papertrail App#papertrail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationPapertrail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerLogDestinationPapertrail? Papertrail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationPapertrail?>();
            }
        }
    }
}
