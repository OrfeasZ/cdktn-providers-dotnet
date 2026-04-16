using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecFunctionLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecFunctionLogDestination")]
    public interface IAppSpecFunctionLogDestination
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
        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationDatadog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionLogDestinationDatadog? Datadog
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
        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationLogtail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionLogDestinationLogtail? Logtail
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
        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationOpenSearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch? OpenSearch
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
        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationPapertrail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionLogDestinationPapertrail? Papertrail
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecFunctionLogDestination), fullyQualifiedName: "digitalocean.app.AppSpecFunctionLogDestination")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecFunctionLogDestination
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
            [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationDatadog\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionLogDestinationDatadog? Datadog
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationDatadog?>();
            }

            /// <summary>logtail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#logtail App#logtail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationLogtail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionLogDestinationLogtail? Logtail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationLogtail?>();
            }

            /// <summary>open_search block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#open_search App#open_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationOpenSearch\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch? OpenSearch
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch?>();
            }

            /// <summary>papertrail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#papertrail App#papertrail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationPapertrail\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionLogDestinationPapertrail? Papertrail
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationPapertrail?>();
            }
        }
    }
}
