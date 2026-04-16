using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceAlert), fullyQualifiedName: "digitalocean.app.AppSpecServiceAlert")]
    public interface IAppSpecServiceAlert
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#operator App#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#rule App#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        string Rule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#value App#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#window App#window}.</summary>
        [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"string\"}")]
        string Window
        {
            get;
        }

        /// <summary>destinations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#destinations App#destinations}
        /// </remarks>
        [JsiiProperty(name: "destinations", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAlertDestinations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceAlertDestinations? Destinations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#disabled App#disabled}.</summary>
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceAlert), fullyQualifiedName: "digitalocean.app.AppSpecServiceAlert")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceAlert
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#operator App#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#rule App#rule}.</summary>
            [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
            public string Rule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#value App#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#window App#window}.</summary>
            [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"string\"}")]
            public string Window
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destinations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#destinations App#destinations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinations", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAlertDestinations\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceAlertDestinations? Destinations
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAlertDestinations?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#disabled App#disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Disabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
