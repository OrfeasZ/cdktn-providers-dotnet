using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.NfsAccessPoint
{
    [JsiiByValue(fqn: "digitalocean.nfsAccessPoint.NfsAccessPointAccessPolicy")]
    public class NfsAccessPointAccessPolicy : digitalocean.NfsAccessPoint.INfsAccessPointAccessPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/nfs_access_point#anongid NfsAccessPoint#anongid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "anongid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Anongid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/nfs_access_point#anonuid NfsAccessPoint#anonuid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "anonuid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Anonuid
        {
            get;
            set;
        }

        private object? _identityEnforcementEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/nfs_access_point#identity_enforcement_enabled NfsAccessPoint#identity_enforcement_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityEnforcementEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IdentityEnforcementEnabled
        {
            get => _identityEnforcementEnabled;
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
                _identityEnforcementEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/nfs_access_point#protocols NfsAccessPoint#protocols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Protocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/nfs_access_point#squash_config NfsAccessPoint#squash_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "squashConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SquashConfig
        {
            get;
            set;
        }
    }
}
