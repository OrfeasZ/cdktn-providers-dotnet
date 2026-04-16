using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecIngress")]
    public class AppSpecIngress : digitalocean.App.IAppSpecIngress
    {
        private object? _rule;

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#rule App#rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecIngressRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rule
        {
            get => _rule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecIngressRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecIngressRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rule = value;
            }
        }

        /// <summary>secure_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#secure_header App#secure_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secureHeader", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressSecureHeader\"}", isOptional: true)]
        public digitalocean.App.IAppSpecIngressSecureHeader? SecureHeader
        {
            get;
            set;
        }
    }
}
