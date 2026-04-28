using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecServiceLogDestination")]
    public interface IAppSpecServiceLogDestination
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
        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationDatadog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceLogDestinationDatadog? Datadog
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
        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationLogtail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceLogDestinationLogtail? Logtail
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
        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationOpenSearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceLogDestinationOpenSearch? OpenSearch
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
        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationPapertrail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceLogDestinationPapertrail? Papertrail
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecServiceLogDestination")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceLogDestination
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
            [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationDatadog\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceLogDestinationDatadog? Datadog
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationDatadog?>();
            }

            /// <summary>logtail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#logtail App#logtail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationLogtail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceLogDestinationLogtail? Logtail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationLogtail?>();
            }

            /// <summary>open_search block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#open_search App#open_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationOpenSearch\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceLogDestinationOpenSearch? OpenSearch
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationOpenSearch?>();
            }

            /// <summary>papertrail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#papertrail App#papertrail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationPapertrail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceLogDestinationPapertrail? Papertrail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationPapertrail?>();
            }
        }
    }
}
