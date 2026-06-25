using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRngsBackend")]
    public class DomainDevicesRngsBackend : libvirt.Domain.IDomainDevicesRngsBackend
    {
        private object? _builtIn;

        /// <summary>Enables use of the hypervisor’s built-in RNG backend when set (presence-only);</summary>
        /// <remarks>
        /// omit this field to avoid configuring a built-in backend.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
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

        /// <summary>Configures an external entropy gathering daemon (EGD) as the RNG backend, including protocol and source details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#egd Domain#egd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "egd", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackendEgd\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsBackendEgd? Egd
        {
            get;
            set;
        }

        /// <summary>Selects the host random backend for the RNG device, typically mapping to a host RNG source such as /dev/random or /dev/urandom;</summary>
        /// <remarks>
        /// details are user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#random Domain#random}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "random", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Random
        {
            get;
            set;
        }
    }
}
