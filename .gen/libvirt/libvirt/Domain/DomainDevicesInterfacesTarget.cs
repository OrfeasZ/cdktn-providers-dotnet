using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesTarget")]
    public class DomainDevicesInterfacesTarget : libvirt.Domain.IDomainDevicesInterfacesTarget
    {
        /// <summary>Sets the target device name for the interface (for example, "vnet0" or "tap0") that will be created or used on the host.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#overriding-the-target-element">https://libvirt.org/formatdomain.html#overriding-the-target-element</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        public string Dev
        {
            get;
            set;
        }

        private object? _managed;

        /// <summary>Controls whether libvirt manages the lifecycle of the target device; boolean is encoded as "yes" or "no" in XML.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#generic-ethernet-connection">https://libvirt.org/formatdomain.html#generic-ethernet-connection</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#managed Domain#managed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Managed
        {
            get => _managed;
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
                _managed = value;
            }
        }
    }
}
