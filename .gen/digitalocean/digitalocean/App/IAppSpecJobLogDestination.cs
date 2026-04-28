using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecJobLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecJobLogDestination")]
    public interface IAppSpecJobLogDestination
    {
        /// <summary>Name of the log destination.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>datadog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#datadog App#datadog}
        /// </remarks>
        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationDatadog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecJobLogDestinationDatadog? Datadog
        {
            get
            {
                return null;
            }
        }

        /// <summary>logtail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#logtail App#logtail}
        /// </remarks>
        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationLogtail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecJobLogDestinationLogtail? Logtail
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#open_search App#open_search}
        /// </remarks>
        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecJobLogDestinationOpenSearch? OpenSearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>papertrail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#papertrail App#papertrail}
        /// </remarks>
        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationPapertrail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecJobLogDestinationPapertrail? Papertrail
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecJobLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecJobLogDestination")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecJobLogDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the log destination.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#name App#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>datadog block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#datadog App#datadog}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationDatadog\"}", isOptional: true)]
            public digitalocean.App.IAppSpecJobLogDestinationDatadog? Datadog
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationDatadog?>();
            }

            /// <summary>logtail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#logtail App#logtail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationLogtail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecJobLogDestinationLogtail? Logtail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationLogtail?>();
            }

            /// <summary>open_search block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#open_search App#open_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearch\"}", isOptional: true)]
            public digitalocean.App.IAppSpecJobLogDestinationOpenSearch? OpenSearch
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationOpenSearch?>();
            }

            /// <summary>papertrail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#papertrail App#papertrail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationPapertrail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecJobLogDestinationPapertrail? Papertrail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationPapertrail?>();
            }
        }
    }
}
