using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesFilterRef")]
    public class DomainDevicesInterfacesFilterRef : libvirt.Domain.IDomainDevicesInterfacesFilterRef
    {
        /// <summary>Specifies the name of the nwfilter profile to apply to this interface;</summary>
        /// <remarks>
        /// value is a user-provided filter name that must refer to an existing nwfilter definition (for example, "clean-traffic").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#filter Domain#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        public string Filter
        {
            get;
            set;
        }

        private object? _parameters;

        /// <summary>Provides one or more parameter overrides for the selected nwfilter, each supplying a named value used by the filter’s rules.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#parameters Domain#parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesFilterRefParameters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRefParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameters
        {
            get => _parameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfacesFilterRefParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesFilterRefParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameters = value;
            }
        }
    }
}
