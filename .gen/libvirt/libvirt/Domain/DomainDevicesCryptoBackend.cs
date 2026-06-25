using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesCryptoBackend")]
    public class DomainDevicesCryptoBackend : libvirt.Domain.IDomainDevicesCryptoBackend
    {
        private object? _builtIn;

        /// <summary>Enables the built-in backend for the crypto device when set;</summary>
        /// <remarks>
        /// this is a presence-only flag, so omitting or setting it to false leaves the element out.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#built_in Domain#built_in}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "builtIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BuiltIn
        {
            get => _builtIn;
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
                _builtIn = value;
            }
        }

        private object? _lkcf;

        /// <summary>Enables the LKCF-based backend for the crypto device when set;</summary>
        /// <remarks>
        /// this is a presence-only flag, so omitting or setting it to false leaves the element out.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#lkcf Domain#lkcf}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lkcf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Lkcf
        {
            get => _lkcf;
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
                _lkcf = value;
            }
        }

        /// <summary>Sets the number of queues used by the crypto backend;</summary>
        /// <remarks>
        /// the value is a user-provided non-negative integer tuned for performance.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#queues Domain#queues}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Queues
        {
            get;
            set;
        }
    }
}
