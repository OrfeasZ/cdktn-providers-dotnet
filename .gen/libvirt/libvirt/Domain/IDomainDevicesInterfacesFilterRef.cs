using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesFilterRef), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesFilterRef")]
    public interface IDomainDevicesInterfacesFilterRef
    {
        /// <summary>Specifies the name of the nwfilter profile to apply to this interface;</summary>
        /// <remarks>
        /// value is a user-provided filter name that must refer to an existing nwfilter definition (for example, "clean-traffic").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#filter Domain#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        string Filter
        {
            get;
        }

        /// <summary>Provides one or more parameter overrides for the selected nwfilter, each supplying a named value used by the filter’s rules.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#parameters Domain#parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesFilterRefParameters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRefParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesFilterRef), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesFilterRef")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesFilterRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the name of the nwfilter profile to apply to this interface;</summary>
            /// <remarks>
            /// value is a user-provided filter name that must refer to an existing nwfilter definition (for example, "clean-traffic").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#filter Domain#filter}
            /// </remarks>
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
            public string Filter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Provides one or more parameter overrides for the selected nwfilter, each supplying a named value used by the filter’s rules.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#parameters Domain#parameters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesFilterRefParameters" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRefParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parameters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
