using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecFunctionAlert")]
    public class AppSpecFunctionAlert : digitalocean.App.IAppSpecFunctionAlert
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#operator App#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#rule App#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public string Rule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#value App#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#window App#window}.</summary>
        [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"string\"}")]
        public string Window
        {
            get;
            set;
        }

        /// <summary>destinations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#destinations App#destinations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinations", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionAlertDestinations\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionAlertDestinations? Destinations
        {
            get;
            set;
        }

        private object? _disabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#disabled App#disabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Disabled
        {
            get => _disabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disabled = value;
            }
        }
    }
}
